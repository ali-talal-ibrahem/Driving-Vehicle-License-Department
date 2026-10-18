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

        // Applications Menu Strip

        private void Applications_DrivingLicensesServices_NewDrivingLicense_LocalLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Local Driving License Soon ...", "Information" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DrivingLicensesServices_NewDrivingLicense_GlobalLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Global Driving License Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DrivingLicensesServices_RenewDrivingLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Renew Driving License Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DrivingLicensesServices_ReplacementLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Replacement Driving License Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DrivingLicensesServices_ReleaseDetainedDrivingLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Release Detained Driving License Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DrivingLicensesServices_RetakeTest_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RetakeTest Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_ManageApplications_Local_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Local Applications Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_ManageApplications_Global_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Global Applications Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DetainLicense_ManageDetainLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Detain License Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DetainLicense_DetainLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detain License Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_DetainLicense_ReleaseDetainLicense_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Release Detain License Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_ManageTestType_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Test Type Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Applications_ManageApplicationType_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Application Type Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // People Menu Strip
        private void People_TSM_Click(object sender, EventArgs e)
        {
            frmManagePeopleForm GoForm = new frmManagePeopleForm();
            GoForm.ShowDialog();
        }

        // Drivers Menu Strip
        private void Drivers_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drivers Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Users Menu Strip
        private void Users_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Users Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Account Settings Menu Strip
        private void AccountSettings_CurrentUserInfo_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current User Info Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AccountSettings_ChangePassword_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Password Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AccountSettings_SignOut_TSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign Out Soon ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
