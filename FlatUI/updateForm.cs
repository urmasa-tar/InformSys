using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatUI
{
    public partial class updateForm : Form
    {
        public updateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FormMainMenu.Instance.mainFunction.updatePar();
            // FormMainMenu.Instance.N = txtBN.Text;

            try
            {
                FormMainMenu.Instance.N = 12345;
                FormMainMenu.Instance.a = 12345;
                FormMainMenu.Instance.k1 = 12345;
                FormMainMenu.Instance.x1 = 12345;
                FormMainMenu.Instance.kd = 12345;
                FormMainMenu.Instance.dx = 12345;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Введенное значение не является числом.");
            }
            finally
            {
            }

        }

        /*
        private void ProcessInput(string input)
        {
            try
            {
                int number = Convert.ToInt32(input); // Преобразуем строку в число
                MessageBox.Show($"Вы ввели число: {number}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка! Введенное значение не является числом.");
            }
        }
        */
    }
}
