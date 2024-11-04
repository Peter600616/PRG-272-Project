using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_272_Project
{
    public partial class frmDeleteStudent : Form
    {
        public frmDeleteStudent()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();
        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            students = fileHandler.read();

            dgvDeleteStudent.DataSource = students;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            var selected = dgvDeleteStudent.SelectedRows[0].DataBoundItem as Student;

            students.Remove(selected);
            

            FileHandler fileHandler = new FileHandler();
            fileHandler.write(students);

            dgvDeleteStudent.DataSource = null;
            dgvDeleteStudent.DataSource = students;


        }
    }
}
