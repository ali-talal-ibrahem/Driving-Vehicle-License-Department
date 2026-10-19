using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_WindowsForm_Presentation.Global_Classes;

namespace DVLD_WindowsForm_Presentation
{
    public partial class frmAdd_EditPreson : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        private enum enMode { AddNewPerson = 0, UpdatePerson = 1 }
        private enMode _Mode;
        private enum enGendor { Male = 0, Female = 1 }
        private int _PersonID = -1;
        private clsPerson _Person;

        public frmAdd_EditPreson()
        {
            InitializeComponent();
            _Mode = enMode.AddNewPerson;
            this.Text = "DVLD - Add New Person";
            lbl_TitleForm.Text = "Add New Person";
        }

        public frmAdd_EditPreson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.UpdatePerson;
            this.Text = "DVLD - Update Person : " + _PersonID;
            lbl_TitleForm.Text = "Update Person (" + _PersonID + ")";
        }

        private void _FillAllCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows) {
                cb_Countries.Items.Add(Row["CountryName"]);
            }

        }

        private void _ResetDefultValue()
        {

            _FillAllCountriesInComboBox();

            if (_Mode == enMode.AddNewPerson)
            {
                lbl_TitleForm.Text = "Add New Person";
                this.Text = "DVLD - Add New Person";
                _Person = new clsPerson();
                
            }
            else {
                lbl_TitleForm.Text = "Update Person (" + _PersonID + ")";
                this.Text = "DVLD - Update Person : " + _PersonID;
            }

            if (rdb_Male.Checked)
            {
                pb_PersonImage.Image = Properties.Resources.Male;
            }
            else
            {
                pb_PersonImage.Image = Properties.Resources.Femail;
            }

            llRemoveImage.Visible = false;

            dtp_DateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtp_DateOfBirth.Value = dtp_DateOfBirth.MaxDate;

            dtp_DateOfBirth.MinDate = DateTime.Today.AddYears(-100);

            cb_Countries.SelectedIndex = cb_Countries.FindString("Syria");

            txb_FirstName.Text = "";
            txb_SecondName.Text = "";
            txb_ThirdName.Text = "";
            txb_LastName.Text = "";
            txb_Email.Text = "";
            txb_Address.Text = "";
            txb_NO.Text = "";
            txb_PhoneNumber.Text = "";
            rdb_Male.Checked = true;
            

        }

        private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Person ID (" + _PersonID + ") not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            lbl_PersonID.Text = _Person._PersonID.ToString();
            txb_FirstName.Text = _Person._FirstName;
            txb_SecondName.Text = _Person._SecondName;
            txb_ThirdName.Text = _Person._ThirdName;
            txb_LastName.Text = _Person._LastName;
            txb_NO.Text = _Person._NationalNO;
            txb_PhoneNumber.Text = _Person._PhoneNumber;
            dtp_DateOfBirth.Value = _Person._DateOfBirth;
            txb_Address.Text = _Person._Address;
            txb_Email.Text = _Person._Email;

            if (_Person._Gendor == 0)
            {
                rdb_Male.Checked = true;
            }
            else
            {
                rdb_Female.Checked = true;
            }

            cb_Countries.SelectedIndex = cb_Countries.FindString(_Person.CountryInfo._CountryName);

            if (!string.IsNullOrEmpty(_Person._ImagePath))
            {
                pb_PersonImage.ImageLocation = _Person._ImagePath;
                pb_PersonImage.BackgroundImage = null;
                llRemoveImage.Visible = (_Person._ImagePath != "");
            }
            else
            {
                pb_PersonImage.ImageLocation = null;

                if (_Person._Gendor == 0)
                {
                    pb_PersonImage.BackgroundImage = Properties.Resources.Male;
                }
                else
                {
                    pb_PersonImage.BackgroundImage = Properties.Resources.Femail;
                }

                llRemoveImage.Visible = false;


            }
        }

        private void frmAdd_EditPreson_Load(object sender, EventArgs e)
        {
            _ResetDefultValue();

            if(_Mode == enMode.UpdatePerson)
            _LoadData();
        }

        private void btn_Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _HandelPersonImage()
        {

            return true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren()) {
                MessageBox.Show("Error");
                return;
            }

            if (!_HandelPersonImage()) {
                return;
            }

            int NationalityCountryID = clsCountry.Find(cb_Countries.Text)._CountryID;

            _Person._FirstName = txb_FirstName.Text.Trim();
            _Person._SecondName = txb_SecondName.Text.Trim();
            _Person._ThirdName = txb_ThirdName.Text.Trim();
            _Person._LastName = txb_LastName.Text.Trim();
            _Person._Address = txb_Address.Text.Trim();
            _Person._Email = txb_Email.Text.Trim();
            _Person._DateOfBirth = dtp_DateOfBirth.Value;
            _Person._PhoneNumber = txb_PhoneNumber.Text.Trim();
            _Person._NationalNO = txb_NO.Text.Trim();
            _Person._NationalityCountryID = NationalityCountryID;

            if (rdb_Male.Checked)
                _Person._Gendor = (short)enGendor.Male;
            else
                _Person._Gendor = (short)enGendor.Female;


            if (pb_PersonImage.ImageLocation != null)
                _Person._ImagePath = pb_PersonImage.ImageLocation;
            else
                _Person._ImagePath = "";

            if (_Person.Save())
            {
                _PersonID = _Person._PersonID;
                _Mode = enMode.UpdatePerson;
                this.Text = "DVLD - Update Person : " + _PersonID;
                lbl_TitleForm.Text = "Update Person (" + _PersonID + ")";

                MessageBox.Show("Data Save Successfuly !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _PersonID);
            }
            else {
                MessageBox.Show("Error : Data Is Not Saved Successfuly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rdb_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_PersonImage.ImageLocation == null) {
                pb_PersonImage.Image = Properties.Resources.Male;
            }
        }

        private void rdb_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_PersonImage.ImageLocation == null)
            {
                pb_PersonImage.Image = Properties.Resources.Femail;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb_PersonImage.ImageLocation = null;

            if (rdb_Male.Checked)
            {
                pb_PersonImage.Image = Properties.Resources.Male;
            }
            else
            {
                pb_PersonImage.Image = Properties.Resources.Femail;
            }

            llRemoveImage.Visible = false;

        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectFileName = openFileDialog1.FileName;
                pb_PersonImage.Load(SelectFileName);
                llRemoveImage.Visible = true;
            }

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txb_Email.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(txb_Email.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txb_Email, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txb_Email, null);
            }
            ;

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txb_NO.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txb_NO, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txb_NO, null);
            }

            //Make sure the national number is not used by another person
            if (txb_NO.Text.Trim() != _Person._NationalNO && clsPerson.IsPersonExists(txb_NO.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txb_NO, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txb_NO, null);
            }
        }
    }
}
