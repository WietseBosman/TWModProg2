using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class Form1 : Form
    {
        int iterations;
        double midx, midy, scale;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           Double.TryParse(textBoxMidX.Text, out midx);
            this.pictureUpdate();
        }

        private void textBoxMidY_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBoxMidY.Text, out midy);
            this.pictureUpdate();
        }

        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBoxScale.Text, out scale);
            
            this.pictureUpdate();
        }

        private void textBoxIterations_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxIterations.Text, out iterations);
            this.pictureUpdate();
        }

        public Form1()
        {
            InitializeComponent();
            this.pictureUpdate();
            
        }

        private void pictureUpdate()
        {
            Bitmap bm = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            
            for (int x = 0; x < this.pictureBox1.Width; x++)
            {
                for (int y = 0; y < this.pictureBox1.Height; y++)
                {
                    int mandel = Program.Mandelbrot(
                        (x - this.pictureBox1.Width / 2) * scale + midx,
                        (y - this.pictureBox1.Height / 2) * scale + midy, 100
                        );
                    if (mandel % 2 == 0)
                        bm.SetPixel(x, y, Color.Black);
                    else
                        bm.SetPixel(x, y, Color.White);
                }
            }
            pictureBox1.Image = bm;
            //commitTest1
        }
    }
}
