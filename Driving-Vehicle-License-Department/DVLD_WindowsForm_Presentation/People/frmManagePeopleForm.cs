using System;
using System.Data;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD_WindowsForm_Presentation.People
{
    public partial class frmManagePeopleForm : Form
    {
        public frmManagePeopleForm()
        {
            InitializeComponent();
        }

        private void _RefreshPeopleList()
        {
            dgv_PeopleInformation.DataSource = clsPeople.GetAllPeople();
            int CountAllPeople = dgv_PeopleInformation.RowCount;
            lbl_ResulrPeopleCount.Text = "Result : " + CountAllPeople.ToString();
        }

        private void frmManagePeopleForm_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
        }

        private void btn_AddNewPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Person Soon...");
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
