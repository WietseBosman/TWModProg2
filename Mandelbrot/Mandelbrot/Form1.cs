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
    public partial class MainForm : Form
    {
        const int maxIterations = 3000;
        const string defaultZoom = "0,02";

        //iterations is used for the actual number of iterations, and is equal to iterationsInput in case the latter doesn't exceed maxIterations
        int iterations, iterationsInput; 
        double midx, midy, scale;

        Color c = new Color();

        int paletBlackWhite = 0;
        int paletWaves = 1;
        int paletLightning = 2;
        int paletColorfull = 3;

        int preset = 0;

        public MainForm()
        {
            InitializeComponent();
            listBox2.SelectedIndex = 0;
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    textBoxMidX.Text = "-1,50156114578247";
                    textBoxMidY.Text = "-0,00221261978149415";
                    textBoxScale.Text = "4,76837158203125E-09";
                    textBoxIterations.Text = "100";
                    listBox1.SelectedIndex = 0;
                    break;
                case 1:
                    textBoxMidX.Text = "0,2361376953125";
                    textBoxMidY.Text = "0,5633056640625";
                    textBoxScale.Text = "9,765625E-06";
                    textBoxIterations.Text = "100";
                    listBox1.SelectedIndex = 1;
                    break;
                case 2:
                    textBoxMidX.Text = "-1,24619293212891";
                    textBoxMidY.Text = "0,093323669433593";
                    textBoxScale.Text = "1,953125E-05";
                    textBoxIterations.Text = "100";
                    listBox1.SelectedIndex = 2;
                    break;
                case 3:
                    textBoxMidX.Text = "-1,2547265625";
                    textBoxMidY.Text = "-0,3851171875";
                    textBoxScale.Text = "7,8125E-05";
                    textBoxIterations.Text = "100";
                    listBox1.SelectedIndex = 3;
                    break;
                default:
                    break;
            }


            this.pictureUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMidX.Text = "0";
            textBoxMidY.Text = "0";
            textBoxScale.Text = defaultZoom;
        }

        public static int Mandelbrot(double x, double y, int iter)
        {
            double a = 0;
            double b = 0;
            for (int i = 1; i <= iter; i++)
            {
                double newA = a * a - b * b + x;
                b = 2 * a * b + y;
                a = newA;
                if (Math.Sqrt(a * a + b * b) > 2)
                    return i;

            }
            return 0;
        }
        private void pictureUpdate()
        {
            Bitmap bm = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            iterations = checkBox1.Checked ? iterationsInput : Math.Min(iterationsInput, maxIterations);
            for (int x = 0; x < this.pictureBox1.Width; x++)
            {
                for (int y = 0; y < this.pictureBox1.Height; y++)
                {
                    int mandel = Mandelbrot(
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
                    if (mandel == 0)
                        bm.SetPixel(x, y, Color.Black);
                    else
                    switch (mandel % 2)
                    {
                        case 0:
                            bm.SetPixel(x, y, Color.White);
                            break;
                        case 1:
                            bm.SetPixel(x, y, Color.Black);
                            break;
                        default:
                            break;
                    }
                    break;

                case 1: //kleurtjes
                    if (mandel == 0)
                        c = Color.FromArgb(40, 180, 190);
                    else if (mandel == 1)
                        c = Color.FromArgb(40, 180, 190);
                    else
                        c = Color.FromArgb(
                        40
                        , 12 * (int)Math.Floor((double)(mandel / 12))
                        , 15 * Math.Abs(16 - (mandel % 32))
                        );
                    bm.SetPixel(x, y, c);


                    break;

                case 2:
                    if (mandel == 0)
                        c = Color.FromArgb(40, 255, 255);
                    else
                        c = Color.FromArgb(
                        0
                        , 255 * mandel / iterations
                        , 255 * mandel / iterations
                        );
                    bm.SetPixel(x, y, c);
                    break;

                case 3:
                    if (mandel == 0)
                        bm.SetPixel(x, y, Color.White);
                    else
                        switch (mandel % 8)
                        {
                            case 0:
                                bm.SetPixel(x, y, Color.Red);
                                break;
                            case 1:
                                bm.SetPixel(x, y, Color.Black);
                                break;
                            case 2:
                                bm.SetPixel(x, y, Color.Green);
                                break;
                            case 3:
                                bm.SetPixel(x, y, Color.Blue);
                                break;
                            case 4:
                                bm.SetPixel(x, y, Color.Yellow);
                                break;
                            case 5:
                                bm.SetPixel(x, y, Color.Cyan);
                                break;
                            case 6:
                                bm.SetPixel(x, y, Color.Orange);
                                break;
                            case 7:
                                bm.SetPixel(x, y, Color.Purple);
                                break;
                            default:
                                break;
                        }
                    break;

                default:
                    break;
            }

        }
    }
}
