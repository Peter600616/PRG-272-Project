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
    public partial class frmAddStudent : Form
    {
        //list of student objects
        static List<Student> studentList = new List<Student>();
        
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            
            
        }

        private void WelcomeMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //getting information from text boxes
            int studentID = Convert.ToInt32(nudStudentID.Value);
            string studentName = txtStudentName.Text;
            int studentAge = Convert.ToInt32(nudAge.Value);
            string studentCourse = txtStudentCourse.Text;

            //create a filehandler object and read contents of text file into list
            FileHandler fh = new FileHandler();
            studentList = fh.read();

            //validation for inputs
            foreach(Student st in studentList)
            {
                if(st.StudentID == studentID)
                {
                    MessageBox.Show("Student with this ID already exists");
                    return;
                }
            }

            if(studentCourse == "BIT" || studentCourse == "BComp" || studentCourse == "DIT")
            {
                //continue with valid options
            }
            else
            {
                MessageBox.Show("Invalid course entered.\nAvailable courses: BIT, BComp, DIT");
                return;
            }

            if(studentAge < 16)
            {
                MessageBox.Show("Student cannot be younger than 16.");
                return;
            }

            //create new student object and add to list
            Student student = new Student(studentID, studentName, studentAge, studentCourse);
            studentList.Add(student);

            //overwrite file
            fh.write(studentList);

            
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
            //clear values
            nudStudentID.Value = 0;
            txtStudentCourse.Text = string.Empty;
            nudAge.Value = 0;
            txtStudentName.Text = string.Empty;
        }

        private void txtStudentAge_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentAge_Click(object sender, EventArgs e)
        {

        }
    }
}
