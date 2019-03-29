namespace CCS_DesktopApp
{
    partial class RangeSettingform
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
            this.startXnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endXnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startYnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endYnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.xaxisCheckbox = new System.Windows.Forms.CheckBox();
            this.yaxisCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.startXnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endXnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startXnumericUpDown
            // 
            this.startXnumericUpDown.DecimalPlaces = 2;
            this.startXnumericUpDown.Location = new System.Drawing.Point(125, 28);
            this.startXnumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startXnumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.startXnumericUpDown.Name = "startXnumericUpDown";
            this.startXnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.startXnumericUpDown.TabIndex = 2;
            this.startXnumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // endXnumericUpDown
            // 
            this.endXnumericUpDown.DecimalPlaces = 2;
            this.endXnumericUpDown.Location = new System.Drawing.Point(344, 33);
            this.endXnumericUpDown.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.endXnumericUpDown.Minimum = new decimal(new int[] {
            351,
            0,
            0,
            0});
            this.endXnumericUpDown.Name = "endXnumericUpDown";
            this.endXnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.endXnumericUpDown.TabIndex = 3;
            this.endXnumericUpDown.Value = new decimal(new int[] {
            351,
            0,
            0,
            0});
            // 
            // startYnumericUpDown
            // 
            this.startYnumericUpDown.DecimalPlaces = 2;
            this.startYnumericUpDown.Location = new System.Drawing.Point(125, 91);
            this.startYnumericUpDown.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            this.startYnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.startYnumericUpDown.Name = "startYnumericUpDown";
            this.startYnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.startYnumericUpDown.TabIndex = 4;
            // 
            // endYnumericUpDown
            // 
            this.endYnumericUpDown.DecimalPlaces = 2;
            this.endYnumericUpDown.Location = new System.Drawing.Point(344, 96);
            this.endYnumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endYnumericUpDown.Minimum = new decimal(new int[] {
            95,
            0,
            0,
            -2147352576});
            this.endYnumericUpDown.Name = "endYnumericUpDown";
            this.endYnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.endYnumericUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "to";
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(237, 142);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(109, 34);
            this.ok_button.TabIndex = 8;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(355, 142);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(109, 34);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // xaxisCheckbox
            // 
            this.xaxisCheckbox.AutoSize = true;
            this.xaxisCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xaxisCheckbox.Location = new System.Drawing.Point(12, 26);
            this.xaxisCheckbox.Name = "xaxisCheckbox";
            this.xaxisCheckbox.Size = new System.Drawing.Size(90, 29);
            this.xaxisCheckbox.TabIndex = 10;
            this.xaxisCheckbox.Text = "X-axis";
            this.xaxisCheckbox.UseVisualStyleBackColor = true;
            // 
            // yaxisCheckbox
            // 
            this.yaxisCheckbox.AutoSize = true;
            this.yaxisCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yaxisCheckbox.Location = new System.Drawing.Point(12, 89);
            this.yaxisCheckbox.Name = "yaxisCheckbox";
            this.yaxisCheckbox.Size = new System.Drawing.Size(89, 29);
            this.yaxisCheckbox.TabIndex = 11;
            this.yaxisCheckbox.Text = "Y-axis";
            this.yaxisCheckbox.UseVisualStyleBackColor = true;
            // 
            // RangeSettingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 192);
            this.Controls.Add(this.yaxisCheckbox);
            this.Controls.Add(this.xaxisCheckbox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endYnumericUpDown);
            this.Controls.Add(this.startYnumericUpDown);
            this.Controls.Add(this.endXnumericUpDown);
            this.Controls.Add(this.startXnumericUpDown);
            this.Name = "RangeSettingform";
            this.Text = "Select Range";
            ((System.ComponentModel.ISupportInitialize)(this.startXnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endXnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown startXnumericUpDown;
        private System.Windows.Forms.NumericUpDown endXnumericUpDown;
        private System.Windows.Forms.NumericUpDown startYnumericUpDown;
        private System.Windows.Forms.NumericUpDown endYnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.CheckBox xaxisCheckbox;
        private System.Windows.Forms.CheckBox yaxisCheckbox;
    }
}