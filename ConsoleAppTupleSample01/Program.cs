using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTupleSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tuples
            ////(int a, double b, float c, (string d, int f)) tuple1 = (1, 2.3, 3.44f, ("asd", 5));
            ////(int a, double b, float c, (string d, int f)) tuple2 = (1, 2.3, 3.44f, ("asd", 5));

            //(int a, int b) tuple3 = (1, 2);
            //(int c, int d) tuple4 = (1, 2);

            //var values = tuple3.GetType().GetProperties().Select(property => property.GetValue(tuple3));
            //if(values.GetType().IsEnum)
            //{

            //}
            #endregion
            try
            {
                Product product = new Product();
                product.CategoryId = 1;
                List<string> list = product.CategoriesLazy.Value;
            }
            catch (MyException e)
            {
                Console.WriteLine("MyException Fırladı...{0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("MyException Fırladı...{0}", e.Message);
            }
        }
    }
}
