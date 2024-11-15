using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatUI
{
    public class funcClasscs
    {
        public funcClasscs() { }

        public double calculateFunction(int x)
        {
            double result = 0;
            
            return result;
        }

        public bool updatePar(long Np, double ap, double k1p, double x1, double kd, double dx)
        {
            bool res = false;
            try
            {
                res = true;
            }
            catch (InvalidCastException ex)
            {
                // Types error exceprion
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {

            }


            return res;
        }

    }
}
