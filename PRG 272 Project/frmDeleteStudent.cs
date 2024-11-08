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
        //creating list and filehandler object
        List<Student> students = new List<Student>();
        FileHandler fileHandler = new FileHandler();
        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {
            //populating datagridview with file data
            students = fileHandler.read();

            dgvDeleteStudent.DataSource = students;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            //getting selected row as a student object
            var selected = dgvDeleteStudent.SelectedRows[0].DataBoundItem as Student;
            
            //remove from list and overwrite file
            students.Remove(selected);
                        
            fileHandler.write(students);

            //reloading datagridview with updated list
            dgvDeleteStudent.DataSource = null;
            dgvDeleteStudent.DataSource = students;

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
