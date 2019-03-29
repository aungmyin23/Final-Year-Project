using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCS_DesktopApp
{
    public partial class AnalysisForm : Form
    {
        double[] data = new double[3648];
        double[] wavelengthData = new double[3648];
        double[] ramanValue = new double[3648];
        double[] testRamanValue = new double[3648];
        double sumtestRaman = 0.00;
        double sumdiffRaman = 0.00;
        double finalDiff = 0.00;
        private string databasePath;
        DataTable testTable = new DataTable();

        public AnalysisForm()
        {
            InitializeComponent();
        }

        public void get_Path(string path, DataTable test, double [] ramanValues)
        {
            databasePath = path.ToString();
            string[] filePaths = Directory.GetFiles(databasePath, "*.txt");
            foreach (string file in filePaths)
            {
                string result = Path.GetFileNameWithoutExtension(file);
                itemBox1.Items.Add(result);
                itemBox2.Items.Add(result);
                itemBox3.Items.Add(result);
                itemBox4.Items.Add(result);
                itemBox5.Items.Add(result);
            }
            testTable = test;

            for (int i = 0; i< testRamanValue.Length; i++)
            {
                testRamanValue[i] = ramanValues[i];
                //sumtestRaman += testRamanValue[i];
                //MessageBox.Show(sumtestRaman.ToString());
            }
            //MessageBox.Show(sumtestRaman.ToString());
        }

        static DataTable createDatatables()
        {
            DataTable newTable = new DataTable();
            newTable.Columns.Add("Wavelength", typeof(double));
            newTable.Columns.Add("Intensity", typeof(double));
            newTable.Columns.Add("Raman", typeof(double));
            return newTable;
        }

        private void analysis_button_Click(object sender, EventArgs e)
        {
            string firstPath, secondPath, thirdPath, fourthPath, fifthPath;

            if (!string.IsNullOrEmpty(itemBox1.Text))
            {
                firstPath = databasePath + @itemBox1.Text + ".txt";
                DataTable Firsttable = createDatatables();
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader(firstPath))
                    {
                        string line;
                        string[] splitStr = new string[2];
                        int i = 0;
                        NumberStyles styles;
                        styles = NumberStyles.AllowExponent | NumberStyles.Number;
                        // Read and display lines from the file until the end of 
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            line = line.Trim();
                            splitStr = line.Split(';');
                            if (splitStr.Length == 3)
                            {
                                data[i] = Double.Parse(splitStr[1], styles);
                                wavelengthData[i] = Double.Parse(splitStr[0], styles);
                                ramanValue[i] = Double.Parse(splitStr[2], styles);
                                sumtestRaman += ramanValue[i];
                                Firsttable.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                            }
                            if (splitStr.Length == 2)
                            {
                                data[i] = Double.Parse(splitStr[1], styles);
                                wavelengthData[i] = Double.Parse(splitStr[0], styles);
                                ramanValue[i] = (1.00 / 532.00) - (1.00 / wavelengthData[i]);
                                sumtestRaman += ramanValue[i];
                                Firsttable.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                            }
                            sumdiffRaman += (ramanValue[i] - testRamanValue[i]);
                            i++;
                            MessageBox.Show(sumdiffRaman.ToString());
                        }
                    }
                }
                catch
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                }
                finalDiff = sumdiffRaman / sumtestRaman;
                MessageBox.Show(finalDiff.ToString());
                /*foreach (DataRow dataRow in Firsttable.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        MessageBox.Show(item.ToString());
                    }
                }*/
            }
            else
            {
                firstPath = "0";
            }

            if (!string.IsNullOrEmpty(itemBox2.Text))
            {
                secondPath = databasePath + @itemBox2.Text + ".txt";
                DataTable secondTable = createDatatables();
                MessageBox.Show(secondPath);
            }
            else
            {
                secondPath = "0";
            }

            if (!string.IsNullOrEmpty(itemBox3.Text))
            {
                thirdPath = databasePath + @itemBox3.Text + ".txt";
                DataTable thirdTable = createDatatables();
                MessageBox.Show(thirdPath);
            }
            else
            {
                thirdPath = "0";
            }
            if (!string.IsNullOrEmpty(itemBox4.Text))
            {
                fourthPath = databasePath + @itemBox4.Text + ".txt";
                DataTable fourthTable = createDatatables();
                MessageBox.Show(fourthPath);
            }
            else
            {
                fourthPath = "0";
            }

            if (!string.IsNullOrEmpty(itemBox5.Text))
            {
                fifthPath = databasePath + @itemBox5.Text + ".txt";
                DataTable fifthTable = createDatatables();
                MessageBox.Show(fifthPath);
            }
            else
            {
                fifthPath = "0";
            }

        }
    }
}
