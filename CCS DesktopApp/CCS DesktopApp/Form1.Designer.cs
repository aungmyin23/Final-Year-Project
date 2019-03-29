namespace CCS_DesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_connect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_serialNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.devicemodel_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_setintegration = new System.Windows.Forms.Button();
            this.numerialupdown_integrationTime = new System.Windows.Forms.NumericUpDown();
            this.button_scanonce = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_scan = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.analysis_button = new System.Windows.Forms.Button();
            this.button_wavelenght = new System.Windows.Forms.Button();
            this.button_raman = new System.Windows.Forms.Button();
            this.button_displayrange = new System.Windows.Forms.Button();
            this.scanChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusText = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.axisText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerialupdown_integrationTime)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(886, 627);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(204, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here for more information!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(58, 129);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(111, 31);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Serial no.";
            // 
            // textbox_serialNo
            // 
            this.textbox_serialNo.Location = new System.Drawing.Point(80, 89);
            this.textbox_serialNo.Name = "textbox_serialNo";
            this.textbox_serialNo.Size = new System.Drawing.Size(125, 22);
            this.textbox_serialNo.TabIndex = 1;
            this.textbox_serialNo.Text = "00493606";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Device model";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.devicemodel_combobox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textbox_serialNo);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 180);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // devicemodel_combobox
            // 
            this.devicemodel_combobox.FormattingEnabled = true;
            this.devicemodel_combobox.Items.AddRange(new object[] {
            "CCS100",
            "CCS125",
            "CCS150",
            "CCS175",
            "CCS200"});
            this.devicemodel_combobox.Location = new System.Drawing.Point(48, 51);
            this.devicemodel_combobox.Name = "devicemodel_combobox";
            this.devicemodel_combobox.Size = new System.Drawing.Size(121, 24);
            this.devicemodel_combobox.TabIndex = 11;
            this.devicemodel_combobox.Text = "CCS175";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.button_setintegration);
            this.groupBox2.Controls.Add(this.numerialupdown_integrationTime);
            this.groupBox2.Location = new System.Drawing.Point(236, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 82);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Integration Time";
            // 
            // button_setintegration
            // 
            this.button_setintegration.AutoSize = true;
            this.button_setintegration.Location = new System.Drawing.Point(182, 26);
            this.button_setintegration.Name = "button_setintegration";
            this.button_setintegration.Size = new System.Drawing.Size(85, 35);
            this.button_setintegration.TabIndex = 4;
            this.button_setintegration.Text = "Set";
            this.button_setintegration.UseVisualStyleBackColor = true;
            this.button_setintegration.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // numerialupdown_integrationTime
            // 
            this.numerialupdown_integrationTime.DecimalPlaces = 4;
            this.numerialupdown_integrationTime.Location = new System.Drawing.Point(17, 33);
            this.numerialupdown_integrationTime.Name = "numerialupdown_integrationTime";
            this.numerialupdown_integrationTime.Size = new System.Drawing.Size(150, 22);
            this.numerialupdown_integrationTime.TabIndex = 3;
            // 
            // button_scanonce
            // 
            this.button_scanonce.AutoSize = true;
            this.button_scanonce.Location = new System.Drawing.Point(6, 25);
            this.button_scanonce.Name = "button_scanonce";
            this.button_scanonce.Size = new System.Drawing.Size(85, 35);
            this.button_scanonce.TabIndex = 12;
            this.button_scanonce.Text = "Scan once";
            this.button_scanonce.UseVisualStyleBackColor = true;
            this.button_scanonce.Click += new System.EventHandler(this.button_Scanonce_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.button_stop);
            this.groupBox3.Controls.Add(this.button_scan);
            this.groupBox3.Controls.Add(this.button_scanonce);
            this.groupBox3.Location = new System.Drawing.Point(236, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 81);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functions";
            // 
            // button_stop
            // 
            this.button_stop.AutoSize = true;
            this.button_stop.Location = new System.Drawing.Point(188, 25);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(85, 35);
            this.button_stop.TabIndex = 14;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_scan
            // 
            this.button_scan.AutoSize = true;
            this.button_scan.Location = new System.Drawing.Point(97, 25);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(85, 35);
            this.button_scan.TabIndex = 13;
            this.button_scan.Text = "Live";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_Scan_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.analysis_button);
            this.groupBox4.Controls.Add(this.button_wavelenght);
            this.groupBox4.Controls.Add(this.button_raman);
            this.groupBox4.Controls.Add(this.button_displayrange);
            this.groupBox4.Location = new System.Drawing.Point(521, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 168);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display";
            // 
            // analysis_button
            // 
            this.analysis_button.Location = new System.Drawing.Point(156, 19);
            this.analysis_button.Name = "analysis_button";
            this.analysis_button.Size = new System.Drawing.Size(132, 36);
            this.analysis_button.TabIndex = 7;
            this.analysis_button.Text = "Analysis";
            this.analysis_button.UseVisualStyleBackColor = true;
            this.analysis_button.Click += new System.EventHandler(this.analysis_button_Click);
            // 
            // button_wavelenght
            // 
            this.button_wavelenght.AutoSize = true;
            this.button_wavelenght.Location = new System.Drawing.Point(18, 112);
            this.button_wavelenght.Name = "button_wavelenght";
            this.button_wavelenght.Size = new System.Drawing.Size(132, 35);
            this.button_wavelenght.TabIndex = 6;
            this.button_wavelenght.Text = "Wavelength";
            this.button_wavelenght.UseVisualStyleBackColor = true;
            this.button_wavelenght.Click += new System.EventHandler(this.button_wavelenght_Click);
            // 
            // button_raman
            // 
            this.button_raman.AutoSize = true;
            this.button_raman.Location = new System.Drawing.Point(18, 66);
            this.button_raman.Name = "button_raman";
            this.button_raman.Size = new System.Drawing.Size(132, 36);
            this.button_raman.TabIndex = 5;
            this.button_raman.Text = "Raman";
            this.button_raman.UseVisualStyleBackColor = true;
            this.button_raman.Click += new System.EventHandler(this.button_raman_Click);
            // 
            // button_displayrange
            // 
            this.button_displayrange.AutoSize = true;
            this.button_displayrange.Location = new System.Drawing.Point(18, 19);
            this.button_displayrange.Name = "button_displayrange";
            this.button_displayrange.Size = new System.Drawing.Size(132, 36);
            this.button_displayrange.TabIndex = 4;
            this.button_displayrange.Text = "Range";
            this.button_displayrange.UseVisualStyleBackColor = true;
            this.button_displayrange.Click += new System.EventHandler(this.button_displayrange_Click);
            // 
            // scanChart
            // 
            this.scanChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.scanChart.ChartAreas.Add(chartArea1);
            this.scanChart.Location = new System.Drawing.Point(21, 205);
            this.scanChart.Name = "scanChart";
            this.scanChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.scanChart.Series.Add(series1);
            this.scanChart.Size = new System.Drawing.Size(1069, 391);
            this.scanChart.TabIndex = 17;
            this.scanChart.Text = "scanChart";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(18, 626);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(93, 24);
            this.statusText.TabIndex = 18;
            this.statusText.Text = "Status Bar";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.Image = global::CCS_DesktopApp.Properties.Resources.nus_logo1;
            this.logo.Location = new System.Drawing.Point(970, 31);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(120, 72);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // axisText
            // 
            this.axisText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.axisText.AutoSize = true;
            this.axisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisText.Location = new System.Drawing.Point(940, 205);
            this.axisText.Name = "axisText";
            this.axisText.Size = new System.Drawing.Size(0, 29);
            this.axisText.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 653);
            this.Controls.Add(this.axisText);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.scanChart);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Spectrometer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerialupdown_integrationTime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_serialNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numerialupdown_integrationTime;
        private System.Windows.Forms.Button button_setintegration;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button button_scanonce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_displayrange;
        private System.Windows.Forms.DataVisualization.Charting.Chart scanChart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_wavelenght;
        private System.Windows.Forms.Button button_raman;
        private System.Windows.Forms.ComboBox devicemodel_combobox;
        private System.Windows.Forms.Label axisText;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.Button analysis_button;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

