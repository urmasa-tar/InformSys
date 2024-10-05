using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAplication
{
    class formulClass
    {
        public formulClass() { }


        public bool updateForF()
        {
            bool res = true;

            return res;
        }

        private bool chedkForC(double a, double k, double x)
        {
            bool res = false;
            if (x < a * k) { res = true; }
            return res;
        }

        public double Calculation(double A, double n, double k, double kd, double x)
        { 
            double res = 0;
            if (chedkForC(A, k, x))
            {
                res = A * Math.Pow(Math.Abs(x + 2 * A), 2);
            }
            else
            {
                res = A * Math.Cos(x + 1) + A; 
            }
            return res;
        }
    }
}
