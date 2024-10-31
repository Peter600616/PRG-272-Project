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
    }
}
