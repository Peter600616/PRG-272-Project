namespace PRG_272_Project
{
    partial class frmAddStudent
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.lblStudentCourse = new System.Windows.Forms.Label();
            this.txtStudentCourse = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.btnClearInPut = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.nudStudentID = new System.Windows.Forms.NumericUpDown();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(139, 115);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(125, 31);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID:";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentID.Click += new System.EventHandler(this.lblStudentID_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(98, 166);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(166, 22);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Full Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(288, 166);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(202, 20);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.TextChanged += new System.EventHandler(this.TxtStudentName_TextChanged);
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentAge.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAge.Location = new System.Drawing.Point(128, 202);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(136, 22);
            this.lblStudentAge.TabIndex = 5;
            this.lblStudentAge.Text = "Student Age:";
            this.lblStudentAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentAge.Click += new System.EventHandler(this.lblStudentAge_Click);
            // 
            // lblStudentCourse
            // 
            this.lblStudentCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentCourse.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCourse.Location = new System.Drawing.Point(165, 239);
            this.lblStudentCourse.Name = "lblStudentCourse";
            this.lblStudentCourse.Size = new System.Drawing.Size(117, 24);
            this.lblStudentCourse.TabIndex = 6;
            this.lblStudentCourse.Text = "Course:";
            this.lblStudentCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStudentCourse
            // 
            this.txtStudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentCourse.Location = new System.Drawing.Point(288, 243);
            this.txtStudentCourse.Name = "txtStudentCourse";
            this.txtStudentCourse.Size = new System.Drawing.Size(202, 20);
            this.txtStudentCourse.TabIndex = 4;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.Location = new System.Drawing.Point(222, 311);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(152, 46);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredentials.Location = new System.Drawing.Point(260, 50);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(256, 24);
            this.lblCredentials.TabIndex = 11;
            this.lblCredentials.Text = "Enter your Student Details:";
            this.lblCredentials.Click += new System.EventHandler(this.lblCredentials_Click);
            // 
            // btnClearInPut
            // 
            this.btnClearInPut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearInPut.Location = new System.Drawing.Point(419, 311);
            this.btnClearInPut.Name = "btnClearInPut";
            this.btnClearInPut.Size = new System.Drawing.Size(152, 46);
            this.btnClearInPut.TabIndex = 12;
            this.btnClearInPut.Text = "Clear";
            this.btnClearInPut.UseVisualStyleBackColor = true;
            this.btnClearInPut.Click += new System.EventHandler(this.btnClearInPut_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(355, 381);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 13;
            this.BtnMenu.Text = "Go To Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // nudStudentID
            // 
            this.nudStudentID.Location = new System.Drawing.Point(288, 123);
            this.nudStudentID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStudentID.Name = "nudStudentID";
            this.nudStudentID.Size = new System.Drawing.Size(202, 20);
            this.nudStudentID.TabIndex = 1;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(288, 206);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(202, 20);
            this.nudAge.TabIndex = 3;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 498);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.nudStudentID);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.btnClearInPut);
            this.Controls.Add(this.lblCredentials);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStudentCourse);
            this.Controls.Add(this.lblStudentCourse);
            this.Controls.Add(this.lblStudentAge);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Student";
            this.Load += new System.EventHandler(this.WelcomeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.Label lblStudentCourse;
        private System.Windows.Forms.TextBox txtStudentCourse;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblCredentials;
        private System.Windows.Forms.Button btnClearInPut;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.NumericUpDown nudStudentID;
        private System.Windows.Forms.NumericUpDown nudAge;
    }
}