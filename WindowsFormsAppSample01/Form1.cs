using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSample01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            (int a, double b, float c, (string d, int f)) tuple1 = (1, 2.3, 3.44f, ("asd", 5));
            (int a, double b, float c, (string d, int f)) tuple2 = (1, 2.3, 3.44f, ("asd", 5));
            var deger = tuple1 = tuple2;

            //if(tuple1 == tuple2)
            //{
                
            //}
        }

        static (int, int) Hede()
        {
            int sayi1 = 0;
            int sayi2 = 2;

            return (sayi1, sayi2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deger = Hede();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ShapeImageForButton.CreateShapeImage(this.ultraButton1);
            
        }
    }
}
