using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;


namespace elte_szimulacio_keret
{
    class Bolyongo
    {
        int x = 100;
        int y = 100;
        Random r = new Random();
        public PictureBox pb;
        public Bitmap bmp;

        public void Lép() 
        {
            int xnext = x+r.Next(3) - 1;
            int ynext = y+r.Next(3) - 1;

            if (!(xnext < 0 || bmp.Width <= xnext))
            {
                x = xnext;
            }
            if (!(ynext < 0 || bmp.Height <= ynext))
            {
                y = ynext;
            }
            // MessageBox.Show($"Ide került: ({x};{y})");
        }

        public void Kirajzol()
        {
            bmp.SetPixel(x, y, Color.Black);
            pb.Refresh();
        }



    }
}
