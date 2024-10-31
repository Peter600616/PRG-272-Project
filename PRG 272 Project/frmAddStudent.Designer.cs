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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.lblStudentCourse = new System.Windows.Forms.Label();
            this.txtStudentCourse = new System.Windows.Forms.TextBox();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.WMBackground = new System.Windows.Forms.PictureBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.btnClearInPut = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(234, -3);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.lblWelcome.Size = new System.Drawing.Size(306, 123);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Belgium Campus ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.UseMnemonic = false;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.BackColor = System.Drawing.Color.White;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(113, 169);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(136, 22);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.BackColor = System.Drawing.Color.White;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(113, 216);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(135, 22);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.Color.Black;
            this.txtStudentID.Location = new System.Drawing.Point(290, 172);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(202, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(290, 216);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(202, 20);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.TextChanged += new System.EventHandler(this.TxtStudentName_TextChanged);
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.BackColor = System.Drawing.Color.White;
            this.lblStudentAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAge.Location = new System.Drawing.Point(113, 252);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(136, 22);
            this.lblStudentAge.TabIndex = 5;
            this.lblStudentAge.Text = "Student Age";
            this.lblStudentAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentCourse
            // 
            this.lblStudentCourse.BackColor = System.Drawing.Color.White;
            this.lblStudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCourse.Location = new System.Drawing.Point(113, 289);
            this.lblStudentCourse.Name = "lblStudentCourse";
            this.lblStudentCourse.Size = new System.Drawing.Size(135, 24);
            this.lblStudentCourse.TabIndex = 6;
            this.lblStudentCourse.Text = "Student Course";
            this.lblStudentCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStudentCourse
            // 
            this.txtStudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentCourse.Location = new System.Drawing.Point(290, 293);
            this.txtStudentCourse.Name = "txtStudentCourse";
            this.txtStudentCourse.Size = new System.Drawing.Size(202, 20);
            this.txtStudentCourse.TabIndex = 7;
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAge.Location = new System.Drawing.Point(290, 255);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(202, 20);
            this.txtStudentAge.TabIndex = 8;
            this.txtStudentAge.TextChanged += new System.EventHandler(this.txtStudentAge_TextChanged);
            // 
            // WMBackground
            // 
            this.WMBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WMBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WMBackground.BackgroundImage")));
            this.WMBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WMBackground.Location = new System.Drawing.Point(0, -3);
            this.WMBackground.Name = "WMBackground";
            this.WMBackground.Size = new System.Drawing.Size(746, 502);
            this.WMBackground.TabIndex = 9;
            this.WMBackground.TabStop = false;
            this.WMBackground.Click += new System.EventHandler(this.WMBackground_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.Location = new System.Drawing.Point(224, 361);
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
            this.lblCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredentials.Location = new System.Drawing.Point(296, 132);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(190, 16);
            this.lblCredentials.TabIndex = 11;
            this.lblCredentials.Text = "Enter your Student Details:";
            this.lblCredentials.Click += new System.EventHandler(this.lblCredentials_Click);
            // 
            // btnClearInPut
            // 
            this.btnClearInPut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearInPut.Location = new System.Drawing.Point(421, 361);
            this.btnClearInPut.Name = "btnClearInPut";
            this.btnClearInPut.Size = new System.Drawing.Size(152, 46);
            this.btnClearInPut.TabIndex = 12;
            this.btnClearInPut.Text = "Clear";
            this.btnClearInPut.UseVisualStyleBackColor = true;
            this.btnClearInPut.Click += new System.EventHandler(this.btnClearInPut_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(357, 431);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 13;
            this.BtnMenu.Text = "Go To Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 498);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.btnClearInPut);
            this.Controls.Add(this.lblCredentials);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStudentAge);
            this.Controls.Add(this.txtStudentCourse);
            this.Controls.Add(this.lblStudentCourse);
            this.Controls.Add(this.lblStudentAge);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.WMBackground);
            this.Name = "frmAddStudent";
            this.Text = "Add a Student";
            this.Load += new System.EventHandler(this.WelcomeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.Label lblStudentCourse;
        private System.Windows.Forms.TextBox txtStudentCourse;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.PictureBox WMBackground;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblCredentials;
        private System.Windows.Forms.Button btnClearInPut;
        private System.Windows.Forms.Button BtnMenu;
    }
}