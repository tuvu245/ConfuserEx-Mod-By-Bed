
using System;
using System.Collections.Generic;
using System.Linq;
using Confuser.Core;
using Confuser.Core.Helpers;
using Confuser.Core.Services;
using Confuser.Renamer;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.IO;
using dnlib.DotNet.Writer;

namespace Confuser.Protections
{
    [BeforeProtection( "Ki.Constants", "Ki.AntiDebug","Ki.AntiDump")]
    internal class CalliProtection : Protection
    {
        public const string _Id = "Calli Protection";
        public const string _FullId = "Ki.Calli";

        public override string Name
        {
            get { return "Calli Protection"; }
        }

        public override string Description
        {
            get { return "This protection will convert calls to calli"; }
        }

        public override string Id
        {
            get { return _Id; }
        }

        public override string FullId
        {
            get { return _FullId; }
        }

        public override ProtectionPreset Preset
        {
            get { return ProtectionPreset.Minimum; }
        }

        protected override void Initialize(ConfuserContext context)
        {
            //
        }

        protected override void PopulatePipeline(ProtectionPipeline pipeline)
        {
            pipeline.InsertPreStage(PipelineStage.ProcessModule, new CalliPhase(this));
        }
        #region
        static bool CanObfuscate(MemberRef mRef, Instruction instruction)
        {
           // if (ctx.Excluded.Contains(instruction)) return false;
            //if (mRef.HasThis) return false;
            if (mRef.ResolveMethodDef().ParamDefs.Any(x => x.IsOut)) return false;
            if (mRef.ResolveMethodDef().IsVirtual) return false;
            if (mRef.ResolveMethodDef().ReturnType.FullName.ToLower().Contains("bool")) return false;
            if (mRef.ResolveMethodDef().ReturnType.FullName.ToLower().Contains("read")) return false;
            return true;
        }
        class CalliPhase : ProtectionPhase
        {
            public CalliPhase(CalliProtection parent)
                : base(parent) { }

            public override ProtectionTargets Targets
            {
                get { return ProtectionTargets.Modules; }
            }

            public override string Name
            {
                get { return "Call to Calli conversion"; }
            }
            public static int tokentocalli = 0;
            public static List<MemberRef> listmember = new List<MemberRef>();
            public static List<int> listtoken = new List<int>();
            protected override void Execute(ConfuserContext context, ProtectionParameters parameters)
            {
                var rt = context.Registry.GetService<IRuntimeService>();
                foreach (ModuleDef module in parameters.Targets.OfType<ModuleDef>())
                {
                    var marker = context.Registry.GetService<IMarkerService>();
                    var name = context.Registry.GetService<INameService>();
                    TypeDef typeDef = rt.GetRuntimeType("Confuser.Runtime.CalliInj");
                    IEnumerable<IDnlibDef> members = InjectHelper.Inject(typeDef, module.GlobalType, module);
                    var init = (MethodDef)members.Single(methodddd => methodddd.Name == "ResolveToken");
                    foreach (IDnlibDef member in members)
                    name.MarkHelper(member, marker, (Protection)Parent);
   foreach (TypeDef type in module.Types.ToArray())
                    {

   foreach (MethodDef method in type.Methods.ToArray())
                        {
                            if (method.Equals(init))
                            {

                            }
                            else if (method.Equals(module.EntryPoint)) { }
                      
                            else
                            {
                                if (method.HasBody)
                                {
                                    if (method.Body.HasInstructions)
                                    {
                                        for (int i = 0; i < method.Body.Instructions.Count - 1; i++)
                                        {
                                            try
                                            {


                                                if (method.Body.Instructions[i].OpCode == OpCodes.Call || method.Body.Instructions[i].OpCode == OpCodes.Callvirt/* || method.Body.Instructions[i].OpCode == OpCodes.Ldloc_S*/)
                                                {
                                                    Console.WriteLine(method.Body.Instructions[i].Operand.ToString());
                                                    if (!method.Body.Instructions[i].Operand.ToString().Contains("System.Type"))
                                                    {
                                                        if (!method.Body.Instructions[i].Operand.ToString().Contains("MessageBoxButtons"))
                                                            try
                                                        {

                                                            MemberRef membertocalli = (MemberRef)method.Body.Instructions[i].Operand;
                                                            tokentocalli = membertocalli.MDToken.ToInt32();
                                                            if (CanObfuscate(membertocalli, method.Body.Instructions[i]))
                                                            {


                                                                listmember.Add(membertocalli);
                                                                listtoken.Add(tokentocalli);
                                                                if (!membertocalli.ToString().Contains("ResolveToken"))

                                                                {
                                                                    if (!membertocalli.HasThis)
                                                                    {
                                                                        if (listmember.Contains(membertocalli))
                                                                        {
                                                                            method.Body.Instructions[i].OpCode = OpCodes.Calli;
                                                                            method.Body.Instructions[i].Operand = listmember[listmember.IndexOf(membertocalli)].MethodSig;
                                                                            method.Body.Instructions.Insert(i, Instruction.Create(OpCodes.Call, init));
                                                                            method.Body.Instructions.Insert(i, Instruction.Create(OpCodes.Ldc_I4, (listtoken[listmember.IndexOf(membertocalli)])));
                                                                        }
                                                                        else
                                                                        {
                                                                            MethodSig MethodSign = membertocalli.MethodSig;
                                                                            method.Body.Instructions[i].OpCode = OpCodes.Calli;
                                                                            method.Body.Instructions[i].Operand = MethodSign;
                                                                            method.Body.Instructions.Insert(i, Instruction.Create(OpCodes.Call, init));
                                                                            method.Body.Instructions.Insert(i, Instruction.CreateLdcI4(tokentocalli));

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            string str = ex.Message;
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {

                                            }

                                        }
                                    }
                                    else
                                    {

                                    }
                                }

                            }
                        }
                        foreach (MethodDef md in module.GlobalType.Methods)
                        {
                            if (md.Name == ".ctor")
                            {
                                module.GlobalType.Remove(md);
                                break;
                            }
                           
                        }
                    }
                }
            }
        }
        #endregion
    }
}