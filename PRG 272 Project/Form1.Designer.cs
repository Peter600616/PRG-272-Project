namespace PRG_272_Project
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btn_InfoStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(74, 55);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(213, 94);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btn_InfoStudent
            // 
            this.btn_InfoStudent.Location = new System.Drawing.Point(62, 168);
            this.btn_InfoStudent.Name = "btn_InfoStudent";
            this.btn_InfoStudent.Size = new System.Drawing.Size(270, 53);
            this.btn_InfoStudent.TabIndex = 1;
            this.btn_InfoStudent.Text = "View info of student";
            this.btn_InfoStudent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 587);
            this.Controls.Add(this.btn_InfoStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btn_InfoStudent;
    }
}

