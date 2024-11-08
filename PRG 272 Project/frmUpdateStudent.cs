using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_272_Project
{
    public partial class frmUpdateStudent : Form
    {
        public frmUpdateStudent()
        {
            InitializeComponent();
        }

        //creating student list, object for student to be updated and filehandler object
        List<Student> students = new List<Student>();
        Student updateStudent = new Student();
        FileHandler fh = new FileHandler();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get entered student ID and check if its in the file
            int studentID = Convert.ToInt32(nudStudentID.Value);   
            bool found = false;
          
            students = fh.read();

            foreach (Student student in students)
            {
                if(student.StudentID == studentID)
                {
                    //creating a shallow copy of the object to be updated
                    updateStudent = student;                  
                    found = true;
                }
            }
            //display the details of found student
            if (!found) 
            {
                MessageBox.Show("Student not found, try again.");
            }
            else
            {
                txtFullName.Text = updateStudent.StudentName;
                nudAge.Value = updateStudent.Age;
                txtCourse.Text = updateStudent.Course;
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string studentName = txtFullName.Text;
            int studentAge = Convert.ToInt32(nudAge.Value);
            string studentCourse = txtCourse.Text;

            //error handling for input data validation
            if (studentCourse == "BIT" || studentCourse == "BComp" || studentCourse == "DIT")
            {
                //lol
            }
            else
            {
                MessageBox.Show("Invalid course entered.\nAvailable courses: BIT, BComp, DIT");
                return;
            }

            if (studentAge < 16)
            {
                MessageBox.Show("Student cannot be younger than 16.");
                return;
            }

            //updating the object with new values via shallow copy
            updateStudent.StudentName = studentName;
            updateStudent.Age = studentAge;
            updateStudent.Course = studentCourse;

            //overwrite file
            fh.write(students); 

            MessageBox.Show("Student information updated");
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
