using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCacheExceptionSample01
{
    [PSerializable]
    public class LoggingAspect : OnMethodBoundaryAspect
    {

        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("The {0} method has been entered.", args.Method.Name);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine("The {0} method executed successfully.", args.Method.Name);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("The {0} method has exited.", args.Method.Name);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("An exception was thrown in {0}.", args.Method.Name);
        }
    }

    class Program
    {
        [LoggingAspect]
        static void Main(string[] args)
        {
            Getir();

            //Console.Read();
        }

        [MyException]
        private static void Getir()
        {
            throw new Exception();
        }
    }
}
