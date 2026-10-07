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
            cb_Filter.SelectedIndex = 0;
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


        //Context Menu Strip Events
        private void cms_ShowDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show Details Soon...");
        }

        private void cms_AddNewPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Person Soon...");
        }

        private void cms_EditPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Person Soon...");
        }

        private void cms_DeletePerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Person Soon...");
        }

        private void cms_SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email Soon...");
        }

        private void cms_CallPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call Phone Soon...");
        }
        //END Context Menu Strip Events


        private void txb_Filter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
