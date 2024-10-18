

using System.Xml.Serialization;

namespace GraphAplication
{
    public partial class Form1 : Form
    {

        protected double A = 1;
        protected double k = 1;
        protected int n = 1000;
        protected double dx = 1;
        protected int kd = 1;

        protected double Ap = -1;
        protected double kp = 1;
        protected int np = 1;
        protected double dxp = 1;
        protected int kdp = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool kqCheck(int x)
        {
            bool res = false;
            if (((double)x) < A * k)
            {
                res = true;
            }
            return res;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            // grapPicter.Image = null;
            Graphics graph = grapPicter.CreateGraphics();
            formulClass formObj = new formulClass();
            Pen pen = new Pen(Color.Black, 3f);

            Point[] pointsArr = new Point[n];

            for (int point = 0; point < pointsArr.Length; point++)
            {
                double pointVar = formObj.Calculation(A, n, k, kd, point);

                pointsArr[point] = new Point(point, (int)(pointVar * 100) + 200);
            }

            graph.DrawLines(pen, pointsArr);
        }

        private void referBtn_Click(object sender, EventArgs e)
        {
            referenceForm refWindow = new referenceForm();

            refWindow.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            Ap = A;
            kp = k;
            np = n;
            dxp = dx;
            kdp = kd;
          
            A = Convert.ToDouble(AtextBox.Text);
            k = Convert.ToDouble(ktextBox.Text);
            n = Convert.ToInt16(NtextBox.Text);
            kd = (int)Convert.ToInt16(kdtextBox.Text);
            dx = Convert.ToDouble(dxtextBox.Text);
            OutDorCorner();
        }

        private void OutDorCorner()
        {
            textBox6.Text = Convert.ToString(Ap) + "          " + Convert.ToString(np) + "             " + Convert.ToString(kp)
                + "             " + Convert.ToString(dxp) + "             " + Convert.ToString(kdp);
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            // Создаем диалог для сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить текстовый файл";

                // Если пользователь нажал кнопку "Сохранить"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем путь файла
                    string filePath = saveFileDialog.FileName;

                    // Сохраняем содержимое текстового поля в файл
                    File.WriteAllText(filePath, AtextBox.Text + " " + ktextBox.Text
                        + " " + NtextBox.Text + " " + kdtextBox.Text + " " + dxtextBox.Text);
                }
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            // Создаем диалог для сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить текстовый файл";

                // Если пользователь нажал кнопку "Сохранить"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем путь файла
                    string filePath = saveFileDialog.FileName;

                    // Сохраняем содержимое текстового поля в файл
                    File.WriteAllText(filePath, AtextBox.Text + " " + ktextBox.Text
                        + " " + NtextBox.Text + " " + kdtextBox.Text + " " + dxtextBox.Text);
                }
            }
        }
    }
}
