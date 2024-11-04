namespace PRG_272_Project
{
    partial class frmSummaryReport
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
            this.lblNumStudents = new System.Windows.Forms.Label();
            this.lblAvgAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumStudents
            // 
            this.lblNumStudents.AutoSize = true;
            this.lblNumStudents.Location = new System.Drawing.Point(229, 68);
            this.lblNumStudents.Name = "lblNumStudents";
            this.lblNumStudents.Size = new System.Drawing.Size(35, 13);
            this.lblNumStudents.TabIndex = 0;
            this.lblNumStudents.Text = "label1";
            // 
            // lblAvgAge
            // 
            this.lblAvgAge.AutoSize = true;
            this.lblAvgAge.Location = new System.Drawing.Point(229, 142);
            this.lblAvgAge.Name = "lblAvgAge";
            this.lblAvgAge.Size = new System.Drawing.Size(35, 13);
            this.lblAvgAge.TabIndex = 1;
            this.lblAvgAge.Text = "label1";
            // 
            // frmSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 262);
            this.Controls.Add(this.lblAvgAge);
            this.Controls.Add(this.lblNumStudents);
            this.Name = "frmSummaryReport";
            this.Text = "Summary Report";
            this.Load += new System.EventHandler(this.frmSummaryReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumStudents;
        private System.Windows.Forms.Label lblAvgAge;
    }
}