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

namespace PRG_272_Project
{
    public partial class frmSummaryReport : Form
    {
        public frmSummaryReport()
        {
            InitializeComponent();
        }

        private void frmSummaryReport_Load(object sender, EventArgs e)
        {
            //create and populate list and create filehandler object
            List<Student> students = new List<Student>();
            FileHandler fileHandler = new FileHandler();

            students = fileHandler.read();

            int studentCount = 0, ageCount = 0 ;
            double avgAge = 0.0;

            //counting students and sum ages
            foreach (Student student in students)
            {
                studentCount++;
                ageCount += student.Age;
            }

            //find average age
            avgAge = Convert.ToDouble(ageCount)/studentCount;

            //display details
            lblNumStudents.Text = $"Total number of students: {studentCount}";
            lblAvgAge.Text = $"Average Age of students: {avgAge}";

            //create new text file with details
            FileStream fs = new FileStream("summary.txt", FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string text;
                text = $"Summary Report:\nTotal number of students: {studentCount}\nAverage age of students: {avgAge}";
                sw.Write(text);
            }

            fs.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNumStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
