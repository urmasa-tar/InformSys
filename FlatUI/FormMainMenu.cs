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
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public FormMainMenu()
        {
            InitializeComponent();
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
    }
}
