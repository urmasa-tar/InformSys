using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;
// using ZedGraphControl;

namespace FlatUI
{
    public partial class FormMainMenu : Form
    {

        private static FormMainMenu _instance;

        private Button currentButton;
        private Random random;
        private int tempIndex;
        public funcClasscs mainFunction;
        private const string ConnectionString = "Server=localhost; Database=MyDatabase; User Id=mrBooter; Password=123456;";

        //private ZedGraphControl zedGraphControl;

        // Parametrs for function graph
        //
        public long N; // Count of points
        public double a; // Value of argument
        public double k1; // koef for first value in function
        public double x1; // first value for functions argument
        public double kd; // koef for function step
        public double dx; // step for function changing

        public static FormMainMenu Instance
        {
            get { return _instance ?? throw new InvalidOperationException("Форма еще не создана!"); }
        }

        public FormMainMenu()
        {
            InitializeComponent();
            _instance = this;
            mainFunction = new funcClasscs();
            // base value for global varibles
            N = 57; //
            a = -5; //
            dx = 0.4; //
            k1 = 0; //
            x1 = 0; //
            kd = 1; // 


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
            chartForFormula.Series.Clear();

            // Параметры функции
            /*
            double A = 1;
            double x1 = -10;
            double k = 0.5;
            double a = 4;
            */

            // Первая серия для первой части функции
            var series1 = new Series("FirstPart")
            {
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Line
            };

            // Вторая серия для второй части функции
            var series2 = new Series("SecondPart")
            {
                Color = System.Drawing.Color.Red,
                ChartType = SeriesChartType.Line
            };

            // Генерация точек для первой части функции
            for (double x = x1; x < k1 * a; x += 0.01)
            {
                double y = Math.Sqrt(a * Math.Abs(x + 2 * a));
                series1.Points.AddXY(x, y);
            }

            // Генерация точек для второй части функции
            for (double x = k1 * a; x <= 30; x += 0.01)
            {
                double y = a * Math.Cos(x + 1) + a;
                series2.Points.AddXY(x, y);
            }

            // Добавляем серии к чарту
            chartForFormula.Series.Add(series1);
            chartForFormula.Series.Add(series2);

            // Настройки осей
            chartForFormula.ChartAreas[0].AxisX.Minimum = x1;
            chartForFormula.ChartAreas[0].AxisX.Maximum = 30;
            chartForFormula.ChartAreas[0].AxisY.Minimum = -10;
            chartForFormula.ChartAreas[0].AxisY.Maximum = 10;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm setForm = new settingsForm();
            setForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateForm updateF = new updateForm();
            updateF.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO MyParameters (N, a, dx, k1, x1, kd) " +
                                 "VALUES (@N, @a, @dx, @k1, @x1, @kd)";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@N", N);
                        command.Parameters.AddWithValue("@a", a);
                        command.Parameters.AddWithValue("@dx", dx);
                        command.Parameters.AddWithValue("@k1", k1);
                        command.Parameters.AddWithValue("@x1", x1);
                        command.Parameters.AddWithValue("@kd", kd);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Запись добавлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM MyParameters WHERE Id = (SELECT MAX(Id) FROM MyParameters)";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Последняя запись удалена.");
                        }
                        else
                        {
                            MessageBox.Show("Нет записей для удаления.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
