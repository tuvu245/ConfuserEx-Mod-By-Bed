using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Arithmetic_Obfuscation.Arithmetic;
using Confuser.Core;
using Confuser.Core.Helpers;
using Confuser.Core.Services;
using Confuser.Renamer;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Confuser.Protections.Constants {
	internal class FieldPhase : ProtectionPhase {
		public FieldPhase(MutationProtection parent)
			: base(parent) { }

		public override ProtectionTargets Targets {
			get { return ProtectionTargets.Methods; }
		}

		public override string Name {
			get { return "Local to Field"; }
		}
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ᅠᅠOPVWXYZ0123456789qwertyuiopasdfghjklzxxcvbnm,./;[]*^$&@$!|}{><?_+";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private Dictionary<Local, FieldDef> convertedLocals = new Dictionary<Local, FieldDef>();
        protected override void Execute(ConfuserContext context, ProtectionParameters parameters) {


            using (IEnumerator<MethodDef> enumerator = parameters.Targets.OfType<MethodDef>().GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    MethodDef method = enumerator.Current;
                    bool flag = !method.HasBody;
                    if (!flag)
                    {
                        method.Body.SimplifyMacros(method.Parameters);
                        IList<Instruction> instructions = method.Body.Instructions;
                        for (int i = 0; i < instructions.Count; i++)
                        {
                            object operand = instructions[i].Operand;
                            Local local = operand as Local;
                            bool flag2 = local != null;
                            if (flag2)
                            {
                                bool flag3 = !this.convertedLocals.ContainsKey(local);
                                FieldDef def;
                                if (flag3)
                                {
                                    def = new FieldDefUser(RandomString(20), new FieldSig(local.Type), FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static);
                                    context.CurrentModule.GlobalType.Fields.Add(def);
                                    this.convertedLocals.Add(local, def);
                                }
                                else
                                {
                                    def = this.convertedLocals[local];
                                }
                                OpCode eq = null;
                                switch (instructions[i].OpCode.Code)
                                {
                                    case Code.Ldloc:
                                        eq = OpCodes.Ldsfld;
                                        break;
                                    case Code.Ldloca:
                                        eq = OpCodes.Ldsflda;
                                        break;
                                    case Code.Stloc:
                                        eq = OpCodes.Stsfld;
                                        break;
                                }
                                instructions[i].OpCode = eq;
                                instructions[i].Operand = def;
                            }
                        }
                        this.convertedLocals.ToList<KeyValuePair<Local, FieldDef>>().ForEach(delegate (KeyValuePair<Local, FieldDef> x)
                        {
                            method.Body.Variables.Remove(x.Key);
                        });
                        this.convertedLocals = new Dictionary<Local, FieldDef>();
                    }
                }
            }

        }

        

 


    }
}