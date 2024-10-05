

namespace GraphAplication
{
    public partial class Form1 : Form
    {

        protected double A = 1;


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

            return res;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            Graphics graph = grapPicter.CreateGraphics();

            Pen pen = new Pen(Color.Black, 3f);

            Point[] pointsArr = new Point[1000];

            for(int point = 0; point < pointsArr.Length; point++)
            {
                pointsArr[point] = new Point(point, (int)(Math.Sin((double)point) * 100) + 200);
            }

            graph.DrawLines(pen, pointsArr);
        }
    }
}
