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
        const int maxIterations = 2000;
        const string defaultScale = "0,011";

        //iterations is used for the actual number of iterations, and is equal to iterationsInput in case the latter doesn't exceed maxIterations
        int iterations, iterationsInput; 
        double midx, midy, scale;

        Color c = new Color();

        const int paletteBlackWhite = 0;
        const int paletteWaves = 1;
        const int paletteLightning = 2;
        const int paletteColorfull = 3;
         
        const int presetMagic = 0;
        const int presetSpiral = 1;
        const int presetIcy = 2;
        const int presetDisco = 3;

        //initializes the form and displays the default mandelbrot figure
        public MainForm()
        {
            InitializeComponent();
            this.textBoxMidX.Text = "0";
            this.textBoxMidY.Text = "0";
            this.textBoxScale.Text = defaultScale;
            this.textBoxIterations.Text = "100";
            this.listBoxPalettes.SelectedIndex = paletteBlackWhite;
        }

        //update the displayed figure to the newly used variables
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           Double.TryParse(textBoxMidX.Text, out midx);
           this.PictureUpdate();
        }
        private void textBoxMidY_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBoxMidY.Text, out midy);
            this.PictureUpdate();
        }
        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBoxScale.Text, out scale);
            
            this.PictureUpdate();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                textBoxMidX.Text = ((e.X - pictureBoxMandelbrot.Width / 2) * scale + midx).ToString();
                textBoxMidY.Text = ((e.Y - pictureBoxMandelbrot.Height / 2) * scale + midy).ToString();
                textBoxScale.Text = (scale / 2).ToString();
            }
            
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                textBoxMidX.Text = ((e.X - pictureBoxMandelbrot.Width / 2) * scale + midx).ToString();
                textBoxMidY.Text = ((e.Y - pictureBoxMandelbrot.Height / 2) * scale + midy).ToString();
                textBoxScale.Text = (scale * 2).ToString();
            }
        }
        private void textBoxIterations_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxIterations.Text, out iterationsInput);
            this.PictureUpdate();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PictureUpdate();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxPresets.SelectedIndex)
            {
                case presetMagic:
                    textBoxMidX.Text = "-1,50156114578247";
                    textBoxMidY.Text = "-0,00221261978149415";
                    textBoxScale.Text = "4,76837158203125E-09";
                    textBoxIterations.Text = "100";
                    listBoxPalettes.SelectedIndex = paletteBlackWhite;
                    break;
                case presetSpiral:
                    textBoxMidX.Text = "0,2361376953125";
                    textBoxMidY.Text = "0,5633056640625";
                    textBoxScale.Text = "9,765625E-06";
                    textBoxIterations.Text = "100";
                    listBoxPalettes.SelectedIndex = paletteWaves;
                    break;
                case presetIcy:
                    textBoxMidX.Text = "-1,24619293212891";
                    textBoxMidY.Text = "0,093323669433593";
                    textBoxScale.Text = "1,953125E-05";
                    textBoxIterations.Text = "100";
                    listBoxPalettes.SelectedIndex = paletteLightning;
                    break;
                case presetDisco:
                    textBoxMidX.Text = "-1,2547265625";
                    textBoxMidY.Text = "-0,3851171875";
                    textBoxScale.Text = "7,8125E-05";
                    textBoxIterations.Text = "100";
                    listBoxPalettes.SelectedIndex = paletteColorfull;
                    break;
                default:
                    break;
            }
            this.PictureUpdate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMidX.Text = "0";
            textBoxMidY.Text = "0";
            textBoxScale.Text = defaultScale;
        }

        //calculates and returns the mandelbrot nummer
        public static int Mandelbrot(double x, double y, int iter)
        {
            double a = 0;
            double b = 0;
            double newA;
            for (int i = 1; i <= iter; i++)
            {
                newA = a * a - b * b + x;
                b = 2 * a * b + y;
                a = newA;
                if (Math.Sqrt(a * a + b * b) > 2)
                    return i;
            }
            return 0;
        }

        //generates bitmap and displays it to pictureBoxMandelbrot
        private void PictureUpdate()
        {
            Bitmap bm = new Bitmap(this.pictureBoxMandelbrot.Width, this.pictureBoxMandelbrot.Height);
            iterations = checkBoxDisableMaxIterations.Checked ? iterationsInput : Math.Min(iterationsInput, maxIterations); //limits the numbers
            for (int x = 0; x < this.pictureBoxMandelbrot.Width; x++)
            {
                for (int y = 0; y < this.pictureBoxMandelbrot.Height; y++)
                {
                    int mandel = Mandelbrot(
                        (x - this.pictureBoxMandelbrot.Width / 2) * scale + midx,
                        (y - this.pictureBoxMandelbrot.Height / 2) * scale + midy,
                        iterations
                        );
                    this.ColorUpdate(x, y, mandel, bm);
                    
                }
            }
            pictureBoxMandelbrot.Image = bm;
            
        }

        //assigns a color value to a pair of coordinates based on the selected pallete
        private void ColorUpdate (int x, int y, int mandel, Bitmap bm)
        {
            switch (listBoxPalettes.SelectedIndex)
            {
                case paletteBlackWhite:
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

                case paletteWaves:
                    if (mandel == 0)
                        c = Color.FromArgb(40, 180, 190);
                    else if (mandel == 1)
                        c = Color.FromArgb(40, 180, 190);
                    else
                        c = Color.FromArgb(
                        40
                        , 12 * (int)Math.Floor((double)(mandel / iterations * 100 / 12))
                        , 15 * Math.Abs(16 - (mandel % 32))
                        );
                    bm.SetPixel(x, y, c);

                    break;

                case paletteLightning:
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

                case paletteColorfull:
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
