using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Confuser.Runtime
{
    internal static class CalliInj
    {
        public static IntPtr ResolveToken(int token)
        {
            System.Reflection.Module module = typeof(CalliInj).Module;
            return module.ResolveMethod(token).MethodHandle.GetFunctionPointer();
        }
        //static Module module()
        //{
        //    System.Reflection.Module module = typeof(CalliInj).Module;
        //    return typeof(CalliInj).Module;
        //}
    }
}

