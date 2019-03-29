using System;
using System.Windows.Forms;

namespace CCS_DesktopApp
{
    public partial class SaveFileform : Form
    {
        public string saveName { get; set; }
        public string saveProduct { get; set; }
        public string saveTestnum { get; set; }

        public SaveFileform()
        {
            InitializeComponent();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
        
            saveName = textbox_researchername.Text.ToString();
            saveProduct = textbox_Testitem.Text.ToString();
            saveTestnum = numericUpDown_testnumber.Value.ToString();       
        }
        
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
