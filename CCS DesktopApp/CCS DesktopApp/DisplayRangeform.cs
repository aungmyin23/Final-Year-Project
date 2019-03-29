using System;
using System.Windows.Forms;

namespace CCS_DesktopApp
{
    public partial class DisplayRangeform : Form
    {
        public double fromValue { get; set; }
        public double toValue { get; set; }

        public DisplayRangeform()
        {
            InitializeComponent();
        }

        private void display_Button_Click(object sender, EventArgs e)
        {

            fromValue = (double)waveFromnumericUpDown.Value;
            toValue = (double)waveTonumericUpDown.Value;
        }
    }
}
