using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_WindowsForm_Presentation.People;

namespace DVLD_WindowsForm_Presentation
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeopleForm GoForm = new frmManagePeopleForm();
            GoForm.ShowDialog();
        }
    }
}
