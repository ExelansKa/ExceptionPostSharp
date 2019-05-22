using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTupleSample01
{
    public class Product
    {
        public Product()
        {
            //Categories = new List<string>();
            CategoriesLazy = new Lazy<List<string>>( ()=> Doldur() );
        }
        private List<string> Doldur()
        {
            List<string> deger = new List<string>();
            deger.Add("hede");
            deger.Add("hidi");
            throw new MyException();
            return deger;
        }

        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Lazy<List<string>> CategoriesLazy { get; set; }

        public List<string> CategoriesNormal { get; set; }
    }
}
