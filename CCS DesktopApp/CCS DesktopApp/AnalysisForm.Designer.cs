namespace CCS_DesktopApp
{
    partial class AnalysisForm
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
            this.itemBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemBox5 = new System.Windows.Forms.ComboBox();
            this.itemBox4 = new System.Windows.Forms.ComboBox();
            this.itemBox3 = new System.Windows.Forms.ComboBox();
            this.itemBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.analysis_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemBox1
            // 
            this.itemBox1.FormattingEnabled = true;
            this.itemBox1.Location = new System.Drawing.Point(6, 56);
            this.itemBox1.Name = "itemBox1";
            this.itemBox1.Size = new System.Drawing.Size(248, 28);
            this.itemBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemBox5);
            this.groupBox1.Controls.Add(this.itemBox4);
            this.groupBox1.Controls.Add(this.itemBox3);
            this.groupBox1.Controls.Add(this.itemBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.itemBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 408);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item selection";
            // 
            // itemBox5
            // 
            this.itemBox5.FormattingEnabled = true;
            this.itemBox5.Location = new System.Drawing.Point(6, 357);
            this.itemBox5.Name = "itemBox5";
            this.itemBox5.Size = new System.Drawing.Size(248, 28);
            this.itemBox5.TabIndex = 9;
            // 
            // itemBox4
            // 
            this.itemBox4.FormattingEnabled = true;
            this.itemBox4.Location = new System.Drawing.Point(6, 275);
            this.itemBox4.Name = "itemBox4";
            this.itemBox4.Size = new System.Drawing.Size(248, 28);
            this.itemBox4.TabIndex = 8;
            // 
            // itemBox3
            // 
            this.itemBox3.FormattingEnabled = true;
            this.itemBox3.Location = new System.Drawing.Point(6, 202);
            this.itemBox3.Name = "itemBox3";
            this.itemBox3.Size = new System.Drawing.Size(248, 28);
            this.itemBox3.TabIndex = 7;
            // 
            // itemBox2
            // 
            this.itemBox2.FormattingEnabled = true;
            this.itemBox2.Location = new System.Drawing.Point(6, 126);
            this.itemBox2.Name = "itemBox2";
            this.itemBox2.Size = new System.Drawing.Size(248, 28);
            this.itemBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Item 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item 2";
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(47, 426);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(98, 46);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "CANCEL";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // analysis_button
            // 
            this.analysis_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.analysis_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysis_button.Location = new System.Drawing.Point(151, 426);
            this.analysis_button.Name = "analysis_button";
            this.analysis_button.Size = new System.Drawing.Size(121, 46);
            this.analysis_button.TabIndex = 4;
            this.analysis_button.Text = "ANALYSIS";
            this.analysis_button.UseVisualStyleBackColor = true;
            this.analysis_button.Click += new System.EventHandler(this.analysis_button_Click);
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 491);
            this.Controls.Add(this.analysis_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnalysisForm";
            this.Text = "Analysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox itemBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox itemBox5;
        private System.Windows.Forms.ComboBox itemBox4;
        private System.Windows.Forms.ComboBox itemBox3;
        private System.Windows.Forms.ComboBox itemBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button analysis_button;
    }
}