using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;
// using ZedGraphControl;

namespace FlatUI
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        //private ZedGraphControl zedGraphControl;

        public FormMainMenu()
        {
            InitializeComponent();

            // Создаем новый график
            chart1.Series.Clear(); // Очищаем все серии

            Series series = new Series("function"); // Создаем новую серию
            series.ChartType = SeriesChartType.Line; // Тип графика - линия

            // Добавляем точки данных
            series.Points.AddXY(1, 10); // (x, y)
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 30);
            series.Points.AddXY(4, 40);

            // Добавляем серию на график
            chart1.Series.Add(series);

            // Настраиваем оси
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "f(x)";

            // Показываем легенду
            chart1.Legends[0].Enabled = true;
        }


        //Constructor
        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        //Common methods
        private Color selectThemeColor()
        {
            int randIndex = random.Next(ThemeColor.colorName.Count - 1) + 1;
            if( tempIndex == randIndex)
            {
                randIndex += 1;
            }
            tempIndex = randIndex;

            string color = ThemeColor.colorName[tempIndex];
            return ColorTranslator.FromHtml(color);

        }

        private void activateButton(object ButtonSender)
        {
            if (ButtonSender != null)
            {
                Color color = selectThemeColor();
                currentButton = (Button)ButtonSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;   
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
