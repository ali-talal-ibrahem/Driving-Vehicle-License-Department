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
        public enum enMode { AddNewPerson = 0, UpdatePerson = 1 }
        public enum enGendor { Male = 0, Female = 1 }
        private enMode _Mode;
        private int _PersonID = -1;
        private clsPerson _Person;

        public frmAdd_EditPreson()
        {
            InitializeComponent();
            _Mode = enMode.AddNewPerson;
        }

        public frmAdd_EditPreson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.UpdatePerson;

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
            else
            {
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

            llRemoveImage.Visible = (pb_PersonImage.ImageLocation != null);

            dtp_DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtp_DateOfBirth.Value = dtp_DateOfBirth.MaxDate;

            dtp_DateOfBirth.MinDate = DateTime.Now.AddYears(-100);

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

            lbl_PersonID.Text = _Person.PersonID.ToString();
            txb_FirstName.Text = _Person.FirstName;
            txb_SecondName.Text = _Person.SecondName;
            txb_ThirdName.Text = _Person.ThirdName;
            txb_LastName.Text = _Person.LastName;
            txb_NO.Text = _Person.NationalNO;
            txb_PhoneNumber.Text = _Person.Phone;
            dtp_DateOfBirth.Value = _Person.DateOfBirth;
            txb_Address.Text = _Person.Address;
            txb_Email.Text = _Person.Email;

            if (_Person.Gendor == 0)
            {
                rdb_Male.Checked = true;
            }
            else
            {
                rdb_Female.Checked = true;
            }

            cb_Countries.SelectedIndex = cb_Countries.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "")
            {
                pb_PersonImage.ImageLocation = _Person.ImagePath;
                pb_PersonImage.BackgroundImage = null;
                llRemoveImage.Visible = (_Person.ImagePath != "");
            }
            else
            {
                pb_PersonImage.ImageLocation = null;

                if (_Person.Gendor == 0)
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
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandelPersonImage()) {
                return;
            }

            int NationalityCountryID = clsCountry.Find(cb_Countries.Text).CountryID;

            _Person.FirstName = txb_FirstName.Text.Trim();
            _Person.SecondName = txb_SecondName.Text.Trim();
            _Person.ThirdName = txb_ThirdName.Text.Trim();
            _Person.LastName = txb_LastName.Text.Trim();
            _Person.Address = txb_Address.Text.Trim();
            _Person.Email = txb_Email.Text.Trim();
            _Person.DateOfBirth = dtp_DateOfBirth.Value;
            _Person.Phone = txb_PhoneNumber.Text.Trim();
            _Person.NationalNO = txb_NO.Text.Trim();
            _Person.NationalityCountryID = NationalityCountryID;

            if (rdb_Male.Checked)
                _Person.Gendor = (short)enGendor.Male;
            else
                _Person.Gendor = (short)enGendor.Female;


            if (pb_PersonImage.ImageLocation != null)
                _Person.ImagePath = pb_PersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                _PersonID = _Person.PersonID;
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
            llRemoveImage.Visible = false;

            if (rdb_Male.Checked)
            {
                pb_PersonImage.Image = Properties.Resources.Male;
            }
            else
            {
                pb_PersonImage.Image = Properties.Resources.Femail;
            }


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
            if (txb_NO.Text.Trim() != _Person.NationalNO && clsPerson.IsPersonExist(txb_NO.Text.Trim()))
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
