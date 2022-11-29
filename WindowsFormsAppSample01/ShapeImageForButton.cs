using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSample01
{
    public static class ShapeImageForButton
    {
        public static void CreateShapeImage(Infragistics.Win.Misc.UltraButton button)
        {
            // create a bitmap that will be used to provide the shape
            // of the button.
            Bitmap bitmap = new Bitmap(100, 100);

            // create a temporary graphics object so we can render into it
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // draw the background in white. whatever color
                // is in the lower left hand pixel will be assumed
                // to be transparent
                g.Clear(Color.White);

                // draw our circle in a different color
                g.DrawEllipse(Pens.Black, 0, 0, 99, 99);

                // make sure to fill it in or the only displayed
                // part of the button will be the outline of the
                // circle
                g.FillEllipse(Brushes.Black, 0, 0, 99, 99);
            }

            // set the shape
            button.ShapeImage = bitmap;

            // autosize to the shape image
            button.AutoSize = true;
        }
    }
}
