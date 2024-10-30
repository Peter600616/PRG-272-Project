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
    public partial class WelcomeMenu : Form
    {
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
            
        }

        private void WMBackground_Click(object sender, EventArgs e)
        {

        }

        private void TxtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void lblCredentials_Click(object sender, EventArgs e)
        {

        }
    }
}
