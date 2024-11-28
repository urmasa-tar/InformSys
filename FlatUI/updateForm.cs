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
                FormMainMenu.Instance.N = int.Parse(txtBN.Text);
                FormMainMenu.Instance.a = double.Parse(txta.Text);
                FormMainMenu.Instance.k1 = double.Parse(txtBN.Text);
                FormMainMenu.Instance.x1 = double.Parse(txtk1.Text);
                FormMainMenu.Instance.kd = double.Parse(txtx1.Text);
                FormMainMenu.Instance.dx = double.Parse(txtKd.Text);

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
