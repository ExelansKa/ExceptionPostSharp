using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTupleSample01
{
    class MyException : Exception 
    {
        public MyException(string myErorMessage) : base(myErorMessage)
        {

        }

        public MyException() : base("My Exception istisnası algıladı")
        {

        }
    }
}
