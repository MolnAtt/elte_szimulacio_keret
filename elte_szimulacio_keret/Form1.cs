using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elte_szimulacio_keret
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Bolyongo b;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;

            b = new Bolyongo();
            b.pb = pictureBox1;
            b.bmp = bmp;
        }

        private void lepes_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 50; i++)
            {
                bmp.SetPixel(10 + i, 10 + i, Color.Black);
            }
            pictureBox1.Refresh();
             */
            b.Lép();
            b.Kirajzol();

        }

        bool fut;
        private void button1_Click(object sender, EventArgs e)
        {
            fut = true;
            while (fut)
            {
                b.Lép();
                if (!checkBox1.Checked)
                {
                    b.Kirajzol();
                }
                Application.DoEvents();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fut = false;
        }
    }
}
