using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Thorlabs.CCS_Series;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace CCS_DesktopApp
{
    public partial class Form1 : Form
    {
        public TLCCS CCS100;
        public double xRange_Start = 0.00;
        public double xRange_End = 0.00;
        public double yRange_Start = 0.00;
        public double yRange_End = 0.00;
        public bool rangeXFlag = false;
        public bool rangeYFlag = false;
        public bool rangeFlag = false;
        double[] data = new double[3648];
        double[] wavelengthData = new double[3648];
        double[] ramanValue = new double[3648];
        double[] analysisResults = new double[5];
        double min_Wave = 0.00, max_Wave = 0.00;
        DataTable dt = new DataTable();

        private bool firstScan = true;
        private bool ramanGraph = false;
        string path, databasePath;
        private string researcherName;
        private string testNum;
        private string testProduct;
        private double startWave;
        private double toWave;

        DataTable dataValues = new DataTable();

        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();
        private ManualResetEvent locker = new ManualResetEvent(true);

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            button_scan.Enabled = false;
            button_scanonce.Enabled = false;
            button_stop.Enabled = false;
            //button_displayrange.Enabled = false;
            dataValues.Columns.Add("Wavelength", typeof(double));
            dataValues.Columns.Add("Intensity", typeof(double));
            dataValues.Columns.Add("Raman", typeof(double));

            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Scan data\";
            databasePath = path + @"Database\";
         
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    return;
                }

                // Try to create the directory.
                //DirectoryInfo di = Directory.CreateDirectory(path);
                System.IO.Directory.CreateDirectory(databasePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }

        }

        // Set up the BackgroundWorker object by 
        // attaching event handlers. 
        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        //The FormClosing event occurs as the form is being closed. When a form is closed, it is disposed, releasing all resources associated with the form.
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            // release the device
            if (CCS100 != null)
                CCS100.Dispose();
        }

        //To connect to the spectrometer
        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (textbox_serialNo.Text.Length == 0)
            {
                MessageBox.Show("Please enter the device information");
                return;
            }

            // set the busy cursor
            this.Cursor = Cursors.WaitCursor;

            // connect the ccs device and start the sample c application. Read out the instrument resource name from the sample application
            // the instrument number 0x8081 is used for the CCS100 device. If you have another CCS instrument please change the number.
            // 0x8081: CCS100
            // 0x8083: CCS125
            // 0x8085: CCS150
            // 0x8087: CCS175
            // 0x8089: CCS200
            string instrumentNumber = "0";
            string serialNumber = textbox_serialNo.Text.ToString();
            string caseSwitch = devicemodel_combobox.Text;

            switch (caseSwitch)
            {
                case "CCS100":
                    instrumentNumber = "0x8081";
                    break;
                case "CCS125":
                    instrumentNumber = "0x8083";
                    break;
                case "CCS150":
                    instrumentNumber = "0x8085";
                    break;
                case "CCS175":
                    instrumentNumber = "0x8087";
                    break;
                case "CCS200":
                    instrumentNumber = "0x8089";
                    break;
                default:
                    MessageBox.Show("Please enter the correct information!");
                    return;
            }

            string resourceName = "USB0::0x1313::" + instrumentNumber + "::M" + serialNumber + "::RAW";

            // initialize device with the resource name (be sure the device is still connected)
            CCS100 = new TLCCS(resourceName, true, true);
            CCS100.identificationQuery(new StringBuilder(256), new StringBuilder(256), new StringBuilder(256), new StringBuilder(256), new StringBuilder(256));
            //MessageBox.Show("Device connected!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            statusText.Text = "Device connected!";
            button_connect.Enabled = false;
            this.Cursor = Cursors.Default;
        }

        //Settin of integration time in the program
        private void button_Set_Click(object sender, EventArgs e)
        {
            double integrationTime = 0.00;
            if ((double)numerialupdown_integrationTime.Value == 0.0000)
            {
                MessageBox.Show("Please re-enter the integrtion time.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;

            }
            CCS100.setIntegrationTime((double)numerialupdown_integrationTime.Value);
            CCS100.getIntegrationTime(out integrationTime);
            statusText.Text = "Integration time is set to: " + integrationTime;
            button_scan.Enabled = true;
            button_scanonce.Enabled = true;
        }

        //Scanning once and save the scanned data 
        private void button_Scanonce_Click(object sender, EventArgs e)
        {
            int delayTime;
            double integration_Time;
            button_scan.Enabled = false;
            button_scanonce.Enabled = false;
            button_stop.Enabled = false;
            statusText.Text = "Scanning";
            this.Cursor = Cursors.WaitCursor;

            CCS100.getIntegrationTime(out integration_Time);
            delayTime = (int)Math.Ceiling(integration_Time) * 1000;
            CCS100.getWavelengthData(0, wavelengthData, out min_Wave, out max_Wave);
            CCS100.startScan();
            Thread.Sleep(delayTime);
            CCS100.getScanData(data);
            dataValues.Clear();
            string scanPath = path + @"\Scan.txt";
            StreamWriter sw = new StreamWriter(scanPath, false);
            for (int i = 0; i < data.Length; i++)
            {
                {
                    ramanValue[i] = (1.00/ 532.00) - (1.00/ wavelengthData[i]);
                    string writeString = wavelengthData[i] + ";" + data[i].ToString() + ";" + ramanValue[i].ToString();
                    sw.WriteLine(writeString);
                    sw.Write("\t");
                    dataValues.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                }
            }
            sw.Write("\r\n");
            show_Wavelengthgraph(dataValues);
            scanChart.MouseWheel += chart_MouseWheel;
            scanChart.MouseMove += chart_MouseMove;
            this.tooltip.AutomaticDelay = 10;
            sw.Flush();
            sw.Close();
            button_scan.Enabled = true;
            button_scanonce.Enabled = true;
            button_stop.Enabled = true;
            statusText.Text = "Scan completed.";
            this.Cursor = Cursors.Default;
        }

        //show wavelength in x-axis
        private void show_Wavelengthgraph (DataTable dt)
        {
            axisText.Text = "Wavelength.";
            scanChart.DataSource = dt;
            scanChart.Series["Series1"].XValueMember = "Wavelength";
            scanChart.Series["Series1"].YValueMembers = "Intensity";
            scanChart.Series["Series1"].ChartType = SeriesChartType.Line;
            scanChart.ChartAreas[0].AxisY.LabelStyle.Format = "";
            scanChart.ChartAreas[0].AxisX.LabelStyle.Format = "#.##";
            //scanChart.ChartAreas[0].AxisX.Minimum = wavelengthData[0];
            //scanChart.ChartAreas[0].AxisX.Maximum = wavelengthData[3647];
            if (rangeXFlag)
            {
                scanChart.ChartAreas[0].AxisX.Minimum = xRange_Start;
                scanChart.ChartAreas[0].AxisX.Maximum = xRange_End;
            }
            if(rangeYFlag)
            {
                scanChart.ChartAreas[0].AxisY.Minimum = yRange_Start;
                scanChart.ChartAreas[0].AxisY.Maximum = yRange_End;
            }
            scanChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            scanChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        }

        //show raman in x-axis
        private void show_Ramangraph(DataTable dt)
        {
            axisText.Text = "Raman.";
            scanChart.DataSource = dt;
            scanChart.Series["Series1"].XValueMember = "Raman";
            scanChart.Series["Series1"].YValueMembers = "Intensity";
            scanChart.Series["Series1"].ChartType = SeriesChartType.Line;
            scanChart.ChartAreas[0].AxisY.LabelStyle.Format = "";
            if (rangeYFlag)
            {
                scanChart.ChartAreas[0].AxisY.Minimum = yRange_Start;
                scanChart.ChartAreas[0].AxisY.Maximum = yRange_End;
            }
            scanChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            scanChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        }

        //For the live scanning using backgroundworker
        private void button_Scan_Click(object sender, EventArgs e)
        {
            if (firstScan == true)
            {
                statusText.Text = "Live scanning.";
                backgroundWorker1.RunWorkerAsync();
                // Disable the scan button.
                button_scan.Enabled = false;
                button_stop.Enabled = true;
                button_scanonce.Enabled = false;
                firstScan = false;
            } else
            {
                //BackgroundWorker worker = sender as BackgroundWorker;
                //scan_Cont(worker, e);
                statusText.Text = "Live scanning.";
                locker.Set();
                button_scan.Enabled = false;
                button_stop.Enabled = true;
                button_scanonce.Enabled = false;
            }
        }

        //For the live scanning using backgroundworker. This stop the live scanning
        private void button_Stop_Click(System.Object sender,System.EventArgs e)
        {
            locker.Reset();
            statusText.Text = "Scanning stopped.";
            button_stop.Enabled = false;
            button_scan.Enabled = true;
            button_scanonce.Enabled = true;
        }

        // This event handler is where the actual,
        // potentially time-consuming work is done.
        //For the live scanning using backgroundworker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            scan_Cont(worker, e);
        }

        //For the live scanning using backgroundworker
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ramanGraph)
            {
                show_Ramangraph(dataValues);
            }
            else
            {
                show_Wavelengthgraph(dataValues);
            }
            scanChart.MouseWheel += chart_MouseWheel;
            scanChart.MouseMove += chart_MouseMove;
            this.tooltip.AutomaticDelay = 10;
        }

        //For the live scanning using backgroundworker
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {

            }
            // Enable the Start button.
            button_scan.Enabled = true;
            button_scanonce.Enabled = true;
            // Disable the Cancel button.
            button_stop.Enabled = false;
        }

        //For the live scanning using backgrounworker
        private void scan_Cont(BackgroundWorker worker, DoWorkEventArgs e)
        {
            int status = 1, delayTime;
            double integration_Time;
            dataValues.Clear();
            CCS100.getIntegrationTime(out integration_Time);
            delayTime = (int)Math.Ceiling(integration_Time) * 1000;
            CCS100.getWavelengthData(0, wavelengthData, out min_Wave, out max_Wave);
            
            while (status == 1)
            {
                locker.WaitOne(Timeout.Infinite);

                dataValues.Clear();
                CCS100.startScan();
                Thread.Sleep(delayTime);
                CCS100.getScanData(data);

                string scanPath = path + @"\ScanCon.txt";
                StreamWriter sw = new StreamWriter(scanPath, false);
                for (int i = 0; i < data.Length; i++)
                {
                    {
                        ramanValue[i] = (1.00 / 532.00) - (1.00 / wavelengthData[i]);
                        string writeString = wavelengthData[i] + ";" + data[i].ToString() + ";" + ramanValue[i].ToString();
                        sw.WriteLine(writeString);
                        sw.Write("\t");
                        dataValues.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                    }
                }
                sw.Write("\r\n");
                worker.ReportProgress(1);
                Thread.Sleep(500);
                sw.Flush();
                sw.Close();                                 
            }
        }

        //This function allows user to use the mouse and read the value of the point/
        void chart_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = scanChart.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around)
                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            if (ramanGraph)
                            {
                                tooltip.Show("Raman=" + prop.XValue + ", Intensity=" + prop.YValues[0], this.scanChart,
                                           pos.X, pos.Y - 15);
                            }
                            else
                            {
                                tooltip.Show("Wavelength=" + prop.XValue + ", Intensity=" + prop.YValues[0], this.scanChart,
                                            pos.X, pos.Y - 15);
                            }                            
                        }
                    }
                }
            }
        }

        /*Loading of the .txt file and plotting the values.
         * This can load both txt format in 2 and 3 columns.
         * however, placement of wavelength, intensity and ramn values cannot be change in the txt
         * If the format of the column is not the same the graph will come out rubbish.*/
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strFilename = "0";
            string[] splitStr = new string[2];
            dataValues.Clear();
            int i = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Wavelength", typeof(double));
            dt.Columns.Add("Intensity", typeof(double));
            NumberStyles styles;
            styles = NumberStyles.AllowExponent | NumberStyles.Number;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strFilename = openFileDialog.FileName;
            }

            if (strFilename == "0")
            {
                return;
            }

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(openFileDialog.OpenFile()))
                {
                    string line;
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
                            dataValues.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                        }
                        if (splitStr.Length == 2)
                        {
                            data[i] = Double.Parse(splitStr[1], styles);
                            wavelengthData[i] = Double.Parse(splitStr[0], styles);
                            ramanValue[i] = (1.00 / 532.00) - (1.00 / wavelengthData[i]);
                            dataValues.Rows.Add(wavelengthData[i], data[i], ramanValue[i]);
                        }
                        i++;
                    }
                }
            }
            catch
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
            }           
            show_Wavelengthgraph(dataValues);
            scanChart.MouseWheel += chart_MouseWheel;
            scanChart.MouseMove += chart_MouseMove;
            this.tooltip.AutomaticDelay = 10;
        }

        /*This function allow the user to zoom in the graph using mousewheel
        * Reference from_ 
        * https://stackoverflow.com/questions/16787050/enabling-mouse-wheel-zooming-in-a-microsoft-chart-control*/
        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        //Link as a place holder for now
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("https://github.com/aungmyin23/Final-Year-Project");

        }

        /*Display the graph in the selected range.
        *Unlike the setting this is just temporary and it will be back to original
        * when scan again*/
        private void button_displayrange_Click(object sender, EventArgs e)
        {
            int startNum = 0, endNum = 0;
            int i = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Wavelength", typeof(double));
            dt.Columns.Add("Intensity", typeof(double));
            if (wavelengthData[0] == 0)
            {
                MessageBox.Show("There is no data to display!");
                return;
            }
            else
            {
                using (DisplayRangeform displayRangeform = new DisplayRangeform())
                {
                    if (displayRangeform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.startWave = displayRangeform.fromValue;
                        this.toWave = displayRangeform.toValue;
                        if (startWave == 0.0000 || toWave == 0.0000)
                        {
                            MessageBox.Show("Please enter the wavelength between 350 and 750", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }

            while (startWave > wavelengthData[i])
            {
                i++;
                startNum = i;
            }

            i = 0;
            while (toWave > wavelengthData[i])
            {
                i++;
                endNum = i;
            }

            for ( i = startNum; i < endNum; i++)
            {
                ramanValue[i] = (1.00 / 532.00) - (1.00 / wavelengthData[i]);
                dt.Rows.Add(ramanValue[i], data[i]);
            }
            rangeFlag = true;
            scanChart.DataSource = dt;
            scanChart.Series["Series1"].XValueMember = "Wavelength";
            scanChart.Series["Series1"].YValueMembers = "Intensity";
            scanChart.Series["Series1"].ChartType = SeriesChartType.Line;
            scanChart.ChartAreas[0].AxisY.LabelStyle.Format = "";
            scanChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            scanChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            scanChart.MouseWheel += chart_MouseWheel;
            scanChart.MouseMove += chart_MouseMove;
            this.tooltip.AutomaticDelay = 10;
        }

        /*All the user to set the x-axis and y-axis that is display in the graph
         * Boolean is set to tell which axis is being set when the graph is being plotted*/
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RangeSettingform rangesetting = new RangeSettingform())
            {
                if (rangesetting.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.rangeXFlag = rangesetting.setXaxis;
                    this.rangeYFlag = rangesetting.setYaxis;
                    if (rangeXFlag)
                    {
                        this.xRange_Start = rangesetting.fromXvalue;
                        this.xRange_End = rangesetting.toXvalue;
                    }
                    if (rangeYFlag)
                    {
                        this.yRange_Start = rangesetting.fromYvalue;
                        this.yRange_End = rangesetting.toYvalue;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        //Display Raman as x-axis
        private void button_raman_Click(object sender, EventArgs e)
        {
            show_Ramangraph(dataValues);
            ramanGraph = true;
        }

        //Display wavelength as x-axis
        private void button_wavelenght_Click(object sender, EventArgs e)
        {
            show_Wavelengthgraph(dataValues);
            ramanGraph = false;
        }

        //Change back the defualt limit which is set in setting
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rangeFlag)
            {
                show_Wavelengthgraph(dataValues);
                rangeFlag = false;
            }else
            {
                rangeXFlag = false;
                rangeYFlag = false;
                scanChart.ChartAreas[0].AxisX.Minimum = double.NaN;
                scanChart.ChartAreas[0].AxisX.Maximum = double.NaN;
                scanChart.ChartAreas[0].AxisY.Minimum = double.NaN;
                scanChart.ChartAreas[0].AxisY.Maximum = double.NaN;
                //MessageBox.Show("Reset");
                //scanChart.ChartAreas[0].RecalculateAxesScale();
            }
        }

        private void analysis_button_Click(object sender, EventArgs e)
        {
            using (AnalysisForm analysisForm = new AnalysisForm())
            {
                analysisForm.get_Path(databasePath.ToString(), dataValues, ramanValue);
                analysisForm.ShowDialog();
                analysisResults = analysisForm.get_Results();
                //for (int i = 0; i<analysisResults.Length; i++)
                //{
                //    MessageBox.Show(analysisResults[i].ToString());
                //}
                result_1.Text = analysisResults[0].ToString("n2");
                result_2.Text = analysisResults[1].ToString("n2");
                result_3.Text = analysisResults[2].ToString("n2");
                result_4.Text = analysisResults[3].ToString("n2");
                result_5.Text = analysisResults[4].ToString("n2");


            }

            /*using (SaveFileform saveFileform = new SaveFileform())
            {
                if (saveFileform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.researcherName = saveFileform.saveName;
                    this.testProduct = saveFileform.saveProduct;
                    this.testNum = saveFileform.saveTestnum;
                    if (string.IsNullOrEmpty(researcherName) || string.IsNullOrEmpty(testProduct) || string.IsNullOrEmpty(testNum))
                    {
                        MessageBox.Show("Please enter all the fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }*/
        }

        /*Save the grpah and scanned data into 3 different formats. txt, csv and png
         * the files will be save in the folder wheich is created using test product 
         * while the format of the file is in ResearcherName_TestProdut_Attempt_DateTime*/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileform saveFileform = new SaveFileform())
            {
                if (saveFileform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.researcherName = saveFileform.saveName;
                    this.testProduct = saveFileform.saveProduct;
                    this.testNum = saveFileform.saveTestnum;
                    if (string.IsNullOrEmpty(researcherName) || string.IsNullOrEmpty(testProduct) || string.IsNullOrEmpty(testNum))
                    {
                        MessageBox.Show("Please enter all the fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                } else
                {
                    return;
                }
                string testPath = System.IO.Path.Combine(path, testProduct);
                if (testPath == null || testProduct == null)
                {
                    return;
                }
                try
                {
                    // Determine whether the directory exists.
                    if (Directory.Exists(testPath))
                    {
                        Console.WriteLine("That path ia already exists.");
                        return;
                    }
                    // Try to create the directory.
                    System.IO.Directory.CreateDirectory(testPath);
                }
                catch (Exception f)
                {
                    Console.WriteLine("The process failed: {0}", f.ToString());
                }
                finally { }

                string newFolder = testProduct + "_" + researcherName + "_" + testNum;
                string folderPath;
                folderPath = System.IO.Path.Combine(testPath, newFolder);
                try
                {
                    // Determine whether the directory exists.
                    if (Directory.Exists(folderPath))
                    {
                        Console.WriteLine("That path ia already exists.");
                    }
                    // Try to create the directory.
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                catch (Exception f)
                {
                    Console.WriteLine("The process failed: {0}", f.ToString());
                }
                finally { }
                                            
                string newfileTxt = newFolder + "_" + DateTime.Now.ToString("yyyy_MM_dd_THHmm") + ".txt";
                string newfileCsv = newFolder + "_" + DateTime.Now.ToString("yyyy_MM_dd_THHmm") + ".csv";
                string newfilePng = newFolder + "_" + DateTime.Now.ToString("yyyy_MM_dd_THHmm") + ".png";
                string textfile = System.IO.Path.Combine(folderPath, newfileTxt);
                string csvfile = System.IO.Path.Combine(folderPath, newfileCsv);
                string pngfile = System.IO.Path.Combine(folderPath, newfilePng);
               //MessageBox.Show(textfile);

                if (File.Exists(newfileTxt) || File.Exists(newfileCsv) || File.Exists(newfilePng)){
                    MessageBox.Show("File exists! Please check again your name and test number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    StreamWriter swtext = new StreamWriter(textfile, false);
                    StreamWriter swcsv = new StreamWriter(csvfile, false);
                    for (int i = 0; i < wavelengthData.Length; i++)
                    {
                        {
                            string writeString = wavelengthData[i].ToString() + ";" + data[i].ToString() + ";" + ramanValue[i].ToString();
                            swtext.WriteLine(writeString);
                            string newLine = string.Format("{0},{1},{2}", wavelengthData[i].ToString() , data[i].ToString(), ramanValue[i].ToString());
                            swcsv.WriteLine(newLine);
                        }
                    }
                    scanChart.SaveImage(pngfile, ChartImageFormat.Png);
                    swtext.Flush();
                    swtext.Close();
                    swcsv.Flush();
                    swcsv.Close();
                }               
            }
        }
    }
}
