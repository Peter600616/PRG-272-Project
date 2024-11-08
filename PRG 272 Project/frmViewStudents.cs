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
    public partial class frmViewStudents : Form
    {
        public frmViewStudents()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();
        private void frmViewStudents_Load(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            students = fileHandler.read();

            //populate datagridview with text file data
            dgvViewStudents.DataSource = students;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
