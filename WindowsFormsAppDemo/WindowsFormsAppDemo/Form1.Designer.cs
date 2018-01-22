namespace WindowsFormsAppDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAmphoe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายการจังหวัด";
            this.label1.UseWaitCursor = true;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(92, 46);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(266, 21);
            this.cbRegion.TabIndex = 1;
            this.cbRegion.UseWaitCursor = true;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "รายการอำเภอ";
            this.label2.UseWaitCursor = true;
            // 
            // comboAmphoe
            // 
            this.comboAmphoe.FormattingEnabled = true;
            this.comboAmphoe.Location = new System.Drawing.Point(90, 97);
            this.comboAmphoe.Name = "comboAmphoe";
            this.comboAmphoe.Size = new System.Drawing.Size(266, 21);
            this.comboAmphoe.TabIndex = 3;
            this.comboAmphoe.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 261);
            this.Controls.Add(this.comboAmphoe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ข้อมูลจังหวัด";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAmphoe;
    }
}

