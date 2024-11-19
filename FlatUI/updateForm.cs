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
