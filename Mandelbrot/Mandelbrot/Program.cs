using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
        
        static int Mandelbrot(int iter, double x, double y)
        {
            double a = 0;
            double b = 0;
            for (int i = 0; i < iter; i++)
            {
                a = a * a - b * b + x;
                b = 2 * a * b + y;
                if (Math.Sqrt(a * a + b * b) >= 2)
                return i;
            
            }    
            return 0;
        }
    }
}
