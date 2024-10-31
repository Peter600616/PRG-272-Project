namespace PRG_272_Project
{
    partial class frmMainMenu
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
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(303, 310);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(213, 94);
            this.btnViewStudents.TabIndex = 1;
            this.btnViewStudents.Text = "View All Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(458, 437);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(213, 94);
            this.btnUpdateInfo.TabIndex = 2;
            this.btnUpdateInfo.Text = "Update Student Information";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(639, 170);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(213, 94);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Delete a Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(639, 310);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(212, 94);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Generate Summary Report";
            this.btnSummary.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(303, 170);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(213, 94);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 708);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnViewStudents);
            this.Name = "frmMainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnAddStudent;
    }
}

