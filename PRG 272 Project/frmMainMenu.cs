using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace PRG_272_Project
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //All buttons open the relevant forms
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent addStudent = new frmAddStudent();
            addStudent.ShowDialog();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            frmViewStudents viewStudents = new frmViewStudents();
            viewStudents.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            frmDeleteStudent delStudent = new frmDeleteStudent();
            delStudent.ShowDialog();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            frmSummaryReport summaryReport = new frmSummaryReport();
            summaryReport.ShowDialog();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            frmUpdateStudent updateStudent = new frmUpdateStudent();
            updateStudent.ShowDialog();
        }
    }
}
