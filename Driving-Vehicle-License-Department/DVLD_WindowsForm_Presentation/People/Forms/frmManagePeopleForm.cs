using System;
using System.Data;
using DVLD_Business;
using System.Windows.Forms;
using System.Diagnostics;

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
            dgv_PeopleInformation.DataSource = clsPerson.GetAllPeople();
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
            frmAdd_EditPreson GoAddForm = new frmAdd_EditPreson(-1);
            GoAddForm.ShowDialog();
            _RefreshPeopleList();
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
            frmAdd_EditPreson GoAddForm = new frmAdd_EditPreson(-1);
            GoAddForm.ShowDialog();
            _RefreshPeopleList();
        }

        private void cms_EditPerson_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgv_PeopleInformation.CurrentRow.Cells[0].Value;
            frmAdd_EditPreson GoEditForm = new frmAdd_EditPreson(PersonID);
            GoEditForm.ShowDialog();
            _RefreshPeopleList();
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
            if (cb_Filter.SelectedIndex.ToString() == "PersonID" || cb_Filter.SelectedIndex.ToString() == "NO." || cb_Filter.SelectedIndex.ToString() == "Phone") { 
                
            }


            if(string.IsNullOrEmpty(txb_Filter.Text.Trim()))
            {
                _RefreshPeopleList();
                return;
            }

            string FilterColumnName = cb_Filter.SelectedItem.ToString();

            dgv_PeopleInformation.DataSource = clsPerson.GetAllPeopleByFilter(FilterColumnName, txb_Filter.Text.Trim());
        }

        private void txb_Filter_KeyPress(object sender, KeyPressEventArgs e)
        {

            string selectedFilter = cb_Filter.SelectedItem?.ToString();

            if (selectedFilter == "PersonID" || selectedFilter == "Phone")
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;


                    errorProvider1.SetError(txb_Filter, "هذا الخيار يقبل الأرقام فقط!");
                }
                else
                {

                    errorProvider1.SetError(txb_Filter, "");
                }
            }
            else
            {

                errorProvider1.SetError(txb_Filter, "");
            }
        }
    
    
    
    
    }
}
