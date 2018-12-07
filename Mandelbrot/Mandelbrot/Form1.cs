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
        const int maxIterations = 3000;
        const string defaultZoom = "0,02";

        int iterationsInput;
        double midx, midy, scale;

        public Form1()
        {
            InitializeComponent();
            textBoxMidX.Text = "0";
            textBoxMidY.Text = "0";
            textBoxScale.Text = defaultZoom;
            textBoxIterations.Text = "100";
            listBox1.SelectedIndex = 0;

        }


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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                textBoxMidX.Text = ((e.X - pictureBox1.Width / 2) * scale + midx).ToString();
                textBoxMidY.Text = ((e.Y - pictureBox1.Height / 2) * scale + midy).ToString();
                textBoxScale.Text = (scale / 2).ToString();
            }
            
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                textBoxMidX.Text = ((e.X - pictureBox1.Width / 2) * scale + midx).ToString();
                textBoxMidY.Text = ((e.Y - pictureBox1.Height / 2) * scale + midy).ToString();
                textBoxScale.Text = (scale * 2).ToString();
            }
        }

        private void textBoxIterations_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxIterations.Text, out iterationsInput);
            this.pictureUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMidX.Text = "0";
            textBoxMidY.Text = "0";
            textBoxScale.Text = defaultZoom;
        }

        private void pictureUpdate()
        {
            Bitmap bm = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            int iterations = checkBox1.Checked ? iterationsInput : Math.Min(iterationsInput, maxIterations);
            for (int x = 0; x < this.pictureBox1.Width; x++)
            {
                for (int y = 0; y < this.pictureBox1.Height; y++)
                {
                    int mandel = Program.Mandelbrot(
                        (x - this.pictureBox1.Width / 2) * scale + midx,
                        (y - this.pictureBox1.Height / 2) * scale + midy,
                        iterations
                        );
                    this.colorUpdate(x, y, mandel, bm);
                    
                }
            }
            pictureBox1.Image = bm;
            
        }

        private void colorUpdate (int x, int y, int mandel, Bitmap bm)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: //zwart wit
                    switch (mandel % 2)
                    {
                        case 0:
                            bm.SetPixel(x, y, Color.Black);
                            break;
                        case 1:
                            bm.SetPixel(x, y, Color.White);
                            break;
                        default:
                            break;
                    }
                    break;

                case 1: //kleurtjes
                    Color c = new Color();
                    c = Color.FromArgb(
                        (mandel % 10) * 25,
                        (mandel % 2) * 255,
                        (mandel % 4) * 63);
                    bm.SetPixel(x, y, c);
                    break;

                default:
                    break;
            }

        }
    }
}
