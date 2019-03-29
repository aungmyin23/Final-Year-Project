using System;
using System.Windows.Forms;

namespace CCS_DesktopApp
{
    public partial class RangeSettingform : Form
    {
        public double fromXvalue { get; set; }
        public double toXvalue { get; set; }
        public double fromYvalue { get; set; }
        public double toYvalue { get; set; }
        public bool setXaxis { get; set; }
        public bool setYaxis { get; set; }


        public RangeSettingform()
        {
            InitializeComponent();
        }

        private void ok_button_click(object sender, EventArgs e)
        {
            fromXvalue = (double)startXnumericUpDown.Value;
            toXvalue = (double)endXnumericUpDown.Value;
            
            /*if ((fromXvalue != 0.00 && toXvalue == 0.00) || (fromXvalue == 0.00 && toXvalue != 0.00))
            {
                MessageBox.Show("Please enter the correct range.");
                return;
            }*/

            fromYvalue = (double)startYnumericUpDown.Value;
            toYvalue = (double)endYnumericUpDown.Value;

            /*if ((fromYvalue != 0.00 && toYvalue == 0.00) || (fromYvalue == 0.00 && toYvalue != 0.00))
            {
                MessageBox.Show("Please enter the correct range.");
                return;
            }*/

            if (xaxisCheckbox.Checked)
            {
                setXaxis = true;
            }
            if (yaxisCheckbox.Checked)
            {
                setYaxis = true;
            }

        }

    }
}
