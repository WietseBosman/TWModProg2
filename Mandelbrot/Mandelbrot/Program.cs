using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Mandelbrot
{
    static class Program
    {
             
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        

        
        public static int Mandelbrot(double x, double y, int iter)
        {
            double a = 0;
            double b = 0;
            for (int i = 1; i <= iter; i++)
            {
                a = a * a - b * b + x;
                b = 2 * a * b + y;
                if (Math.Sqrt(a * a + b * b) > 2)
                return i;
            
            }    
            return 0;
        }
    }
}
