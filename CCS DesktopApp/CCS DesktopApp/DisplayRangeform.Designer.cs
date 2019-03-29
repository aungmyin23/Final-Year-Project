namespace CCS_DesktopApp
{
    partial class DisplayRangeform
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
            this.waveFromnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.waveTonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.display_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.waveFromnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveTonumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // waveFromnumericUpDown
            // 
            this.waveFromnumericUpDown.DecimalPlaces = 2;
            this.waveFromnumericUpDown.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.waveFromnumericUpDown.Location = new System.Drawing.Point(108, 23);
            this.waveFromnumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.waveFromnumericUpDown.Minimum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.waveFromnumericUpDown.Name = "waveFromnumericUpDown";
            this.waveFromnumericUpDown.Size = new System.Drawing.Size(150, 22);
            this.waveFromnumericUpDown.TabIndex = 0;
            this.waveFromnumericUpDown.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // waveTonumericUpDown
            // 
            this.waveTonumericUpDown.AutoSize = true;
            this.waveTonumericUpDown.DecimalPlaces = 2;
            this.waveTonumericUpDown.Location = new System.Drawing.Point(108, 68);
            this.waveTonumericUpDown.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.waveTonumericUpDown.Minimum = new decimal(new int[] {
            351,
            0,
            0,
            0});
            this.waveTonumericUpDown.Name = "waveTonumericUpDown";
            this.waveTonumericUpDown.Size = new System.Drawing.Size(150, 22);
            this.waveTonumericUpDown.TabIndex = 1;
            this.waveTonumericUpDown.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(20, 65);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(36, 25);
            this.s.TabIndex = 3;
            this.s.Text = "To";
            // 
            // display_Button
            // 
            this.display_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.display_Button.Location = new System.Drawing.Point(23, 107);
            this.display_Button.Name = "display_Button";
            this.display_Button.Size = new System.Drawing.Size(103, 40);
            this.display_Button.TabIndex = 4;
            this.display_Button.Text = "Display";
            this.display_Button.UseVisualStyleBackColor = true;
            this.display_Button.Click += new System.EventHandler(this.display_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Button.Location = new System.Drawing.Point(154, 107);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(104, 40);
            this.cancel_Button.TabIndex = 5;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            // 
            // DisplayRangeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 170);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.display_Button);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waveTonumericUpDown);
            this.Controls.Add(this.waveFromnumericUpDown);
            this.Name = "DisplayRangeform";
            this.Text = "Range";
            ((System.ComponentModel.ISupportInitialize)(this.waveFromnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveTonumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown waveFromnumericUpDown;
        private System.Windows.Forms.NumericUpDown waveTonumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button display_Button;
        private System.Windows.Forms.Button cancel_Button;
    }
}