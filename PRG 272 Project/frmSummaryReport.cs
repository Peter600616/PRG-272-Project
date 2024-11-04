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
            List<Student> students = new List<Student>();
            FileHandler fileHandler = new FileHandler();

            students = fileHandler.read();

            int studentCount = 0, ageCount = 0 ;
            double avgAge = 0.0;

            foreach (Student student in students)
            {
                studentCount++;
                ageCount += student.Age;
            }

            avgAge = Convert.ToDouble(ageCount)/studentCount;

            lblNumStudents.Text = $"Total number of students: {studentCount}";
            lblAvgAge.Text = $"Average Age of students: {avgAge}";

            FileStream fs = new FileStream("summary.txt", FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string text;
                text = $"Summary Report:\nTotal number of students: {studentCount}\nAverage age of students: {avgAge}";
                sw.Write(text);
            }

            fs.Close();
        }
    }
}
