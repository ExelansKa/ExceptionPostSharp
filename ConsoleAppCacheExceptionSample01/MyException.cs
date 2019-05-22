using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace ConsoleAppCacheExceptionSample01
{
    [PSerializable]
    public class MyException : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine(args.Exception.Message + " " +
                args.Method.Name);

            args.FlowBehavior = FlowBehavior.RethrowException;
        }
    }
}
