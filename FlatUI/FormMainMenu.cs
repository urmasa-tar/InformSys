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
        private Button currentButton;
        private Random random;
        private int tempIndex;

        private const string ConnectionString = "Server=localhost;Database=MyDatabase; User Id=mrBooter; Password=123456;";

        //private ZedGraphControl zedGraphControl;

        // Parametrs for function graph
        //
        long N; // Count of points
        double a; // Value of argument
        double k1; // koef for first value in function
        double x1; // first value for functions argument
        double kd; // koef for function step
        double dx; // step for function changing

        public FormMainMenu()
        {
            InitializeComponent();

            // base value for global varibles
            N = 57;
            a = -5;
            dx = 0.4;
            k1 = 0;
            x1 = 0;
            kd = 1;

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
            // Создаем новый график
            chartForFormula.Series.Clear(); // Очищаем все серии

            Series series = new Series("function"); // Создаем новую серию
            series.ChartType = SeriesChartType.Line; // Тип графика - линия

            // Добавляем точки данных
            /*
            series.Points.AddXY(1, 10); // (x, y)
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 30);
            series.Points.AddXY(4, 40);
            */

            // Добавляем серию на график
            chartForFormula.Series.Add(series);

            // Настраиваем оси
            chartForFormula.ChartAreas[0].AxisX.Title = "x";
            chartForFormula.ChartAreas[0].AxisY.Title = "F(x, a)";

            // Показываем легенду
            chartForFormula.Legends[0].Enabled = true;
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
