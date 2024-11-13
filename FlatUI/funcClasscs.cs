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
        funcClasscs() { }

        public double calculateFunction(int x)
        {
            double result = 0;
            
            return result;
        }

        public bool updatePar()
        {
            bool res = false;
            try
            {

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
