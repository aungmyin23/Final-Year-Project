using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace CCS_DesktopApp
{
    public partial class AnalysisForm : Form
    {
        double[] data = new double[3648];
        double[] wavelengthData = new double[3648];
        double[] ramanValue = new double[3648];
        double[] testRamanValue = new double[3648];
        double[] finalAnalysis = new double[5];
        double sumtestRaman = 0.00;
        double sumdiffRaman = 0.00;
        double finalDiff = 0.00;
        private string databasePath;
        DataTable testTable = new DataTable();

        public AnalysisForm()
        {
            InitializeComponent();
        }

        public double[] get_Results()
        {
            return finalAnalysis;
        }

        public void get_Path(string path, DataTable test, double [] values)
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
                testRamanValue[i] = values[i];
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

        public double checkSimilarities(DataTable referenceTable, string filePath)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filePath))
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
                            referenceTable.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                        }
                        if (splitStr.Length == 2)
                        {
                            data[i] = Double.Parse(splitStr[1], styles);
                            wavelengthData[i] = Double.Parse(splitStr[0], styles);
                            ramanValue[i] = (1.00 / 532.00) - (1.00 / wavelengthData[i]);
                            referenceTable.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                        }
                        double diff = ramanValue[i] - testRamanValue[i];
                        sumdiffRaman += diff;
                        sumtestRaman += ramanValue[i];
                        //MessageBox.Show(testRamanValue[i].ToString());
                        i++;
                    }
                }
            }
            catch
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
            }
            finalDiff = (sumdiffRaman / sumtestRaman);
            if(finalDiff <0)
            {
                return finalDiff = 100 + finalDiff;
            }
            else
            {
                return finalDiff = 100 - finalDiff;
            }
        }

        private void analysis_button_Click(object sender, EventArgs e)
        {
            string firstPath, secondPath, thirdPath, fourthPath, fifthPath;
            
            if (!string.IsNullOrEmpty(itemBox1.Text))
            {
                firstPath = databasePath + @itemBox1.Text + ".txt";
                DataTable Firsttable = createDatatables();
                finalAnalysis[0] = checkSimilarities(Firsttable, firstPath);
                /*try
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
                                Firsttable.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                            }
                            if (splitStr.Length == 2)
                            {
                                data[i] = Double.Parse(splitStr[1], styles);
                                wavelengthData[i] = Double.Parse(splitStr[0], styles);
                                ramanValue[i] = (1.00 / 532.00) - (1.00 / wavelengthData[i]);
                                Firsttable.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                            }
                            var diff = ramanValue[i] - testRamanValue[i];
                            sumdiffRaman += diff;
                            sumtestRaman += ramanValue[i];
                            //MessageBox.Show(testRamanValue[i].ToString());
                            i++;
                        }
                    }
                }
                catch
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                }
                finalDiff = 100 - (sumdiffRaman / sumtestRaman);
                MessageBox.Show(finalDiff.ToString());
                /*foreach (DataRow dataRow in Firsttable.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        MessageBox.Show(item.ToString());
                    }
                }
                */
            }
            else
            {
                firstPath = "0";
                finalAnalysis[0] = 0;
            }

            if (!string.IsNullOrEmpty(itemBox2.Text))
            {
                secondPath = databasePath + @itemBox2.Text + ".txt";
                DataTable secondTable = createDatatables();
                finalAnalysis[1] = checkSimilarities(secondTable, secondPath);
                //MessageBox.Show(secondPath);
            }
            else
            {
                secondPath = "0";
                finalAnalysis[1] = 0;
            }

            if (!string.IsNullOrEmpty(itemBox3.Text))
            {
                thirdPath = databasePath + @itemBox3.Text + ".txt";
                DataTable thirdTable = createDatatables();
                finalAnalysis[2] = checkSimilarities(thirdTable, thirdPath);
                //MessageBox.Show(thirdPath);
            }
            else
            {
                thirdPath = "0";
                finalAnalysis[2] = 0;

            }
            if (!string.IsNullOrEmpty(itemBox4.Text))
            {
                fourthPath = databasePath + @itemBox4.Text + ".txt";
                DataTable fourthTable = createDatatables();
                finalAnalysis[3] = checkSimilarities(fourthTable, fourthPath);
                //MessageBox.Show(fourthPath);
            }
            else
            {
                fourthPath = "0";
                finalAnalysis[3] = 0;

            }

            if (!string.IsNullOrEmpty(itemBox5.Text))
            {
                fifthPath = databasePath + @itemBox5.Text + ".txt";
                DataTable fifthTable = createDatatables();
                finalAnalysis[4] = checkSimilarities(fifthTable, fifthPath);
                //MessageBox.Show(fifthPath);
            }
            else
            {
                fifthPath = "0";
                finalAnalysis[4] = 0;
            }

        }
    }
}
