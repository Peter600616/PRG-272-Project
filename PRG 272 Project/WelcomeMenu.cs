using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace PRG_272_Project
{
    public partial class WelcomeMenu : Form
    {
        static List<string> studentList = new List<string>();

        string studentsInfo = "students.txt";
        Student student = new Student();
        public WelcomeMenu()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            
            
        }

        private void WelcomeMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Parent = WMBackground;
            lblCredentials.Parent = WMBackground;
            lblWelcome.BackColor = Color.Transparent;
            lblCredentials.BackColor = Color.Transparent;   
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            int studentAge = int.Parse(txtStudentAge.Text);
            string studentCourse = txtStudentCourse.Text;

            using (StreamWriter write = new StreamWriter(studentsInfo,true))
            {
                Student student = new Student(studentID, studentName, studentAge, studentCourse);

                write.WriteLine($"StudentID: {studentID} | Name: {studentName} | Age: {studentAge} | Course: {studentCourse} ");
               
                studentList.Add(student.ToString());

            }

            MessageBox.Show("Data has been saved to the text file");
        }

        private void WMBackground_Click(object sender, EventArgs e)
        {

        }

        private void TxtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void lblCredentials_Click(object sender, EventArgs e)
        {

        }

        private void btnClearInPut_Click(object sender, EventArgs e)
        {
            txtStudentAge.Text = string.Empty;
            txtStudentCourse.Text = string.Empty;
            txtStudentID.Text = string.Empty;
            txtStudentName.Text = string.Empty;
        }

        private void txtStudentAge_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form1 moreMenu = new Form1();
            moreMenu.ShowDialog();  
        }
    }
}
