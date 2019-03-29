namespace CCS_DesktopApp
{
    partial class SaveFileform
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
            this.save_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_researchername = new System.Windows.Forms.TextBox();
            this.textbox_Testitem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_testnumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_testnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // save_Button
            // 
            this.save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_Button.Location = new System.Drawing.Point(156, 169);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(107, 33);
            this.save_Button.TabIndex = 0;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Button.Location = new System.Drawing.Point(269, 169);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(107, 33);
            this.cancel_Button.TabIndex = 1;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_testnumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textbox_Testitem);
            this.groupBox1.Controls.Add(this.textbox_researchername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Researcher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test item";
            // 
            // textbox_researchername
            // 
            this.textbox_researchername.Location = new System.Drawing.Point(150, 27);
            this.textbox_researchername.Name = "textbox_researchername";
            this.textbox_researchername.Size = new System.Drawing.Size(212, 22);
            this.textbox_researchername.TabIndex = 3;
            // 
            // textbox_Testitem
            // 
            this.textbox_Testitem.Location = new System.Drawing.Point(150, 66);
            this.textbox_Testitem.Name = "textbox_Testitem";
            this.textbox_Testitem.Size = new System.Drawing.Size(212, 22);
            this.textbox_Testitem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Test number";
            // 
            // numericUpDown_testnumber
            // 
            this.numericUpDown_testnumber.Location = new System.Drawing.Point(150, 98);
            this.numericUpDown_testnumber.Name = "numericUpDown_testnumber";
            this.numericUpDown_testnumber.Size = new System.Drawing.Size(143, 22);
            this.numericUpDown_testnumber.TabIndex = 7;
            this.numericUpDown_testnumber.Minimum = 1;
            // 
            // SaveFileform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 214);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.save_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SaveFileform";
            this.Text = "Save File Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_testnumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_researchername;
        private System.Windows.Forms.TextBox textbox_Testitem;
        private System.Windows.Forms.NumericUpDown numericUpDown_testnumber;
        private System.Windows.Forms.Label label2;
    }
}