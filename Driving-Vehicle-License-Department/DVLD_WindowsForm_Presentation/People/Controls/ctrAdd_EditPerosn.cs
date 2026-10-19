using System;
using System.Windows.Forms;
using DVLD_Business;
using System.Data;

namespace DVLD_WindowsForm_Presentation
{
    public partial class ctrAdd_EditPerosn : UserControl
    {

        private enum enMode {AddNewPerson = 0 , UpdatePerson = 1 }
        private enMode _Mode = enMode.AddNewPerson;
        private int _PersonID;
        private clsPerson _Person;

        public ctrAdd_EditPerosn()
        {
            InitializeComponent(); 
        }

        private void _FillAllCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            cb_Countries.DataSource = dtCountries;
            cb_Countries.DisplayMember = "CountryName";
            cb_Countries.ValueMember = "CountryID";

        }

        public void ctrAdd_EditPerosn_Load(int PersonID)
        {
            _PersonID = PersonID;

            _FillAllCountriesInComboBox();
            dtp_DateOfBirth.MaxDate = DateTime.Now - new TimeSpan(365 * 18, 0, 0, 0);

            if (PersonID == -1)
            {
                _Mode = enMode.AddNewPerson;
            }
            else
            {
                _Mode = enMode.UpdatePerson;
            }

            _Load();

        }

        private void _Load()
        {

            cb_Countries.SelectedIndex = 0;

            if (_Mode == enMode.AddNewPerson) 
            { 
                _Person = new clsPerson();
                return;

            }


            _Person = clsPerson.Find(_PersonID);

            if(_Person == null)
            {
                MessageBox.Show("Person ID (" + _PersonID + ") not found");
                return;
            }

            lbl_PersonID.Text = _PersonID.ToString();
            txb_FirstName.Text = _Person._FirstName;
            txb_SecondName.Text = _Person._SecondName;
            txb_ThirdName.Text = _Person._ThirdName;
            txb_LastName.Text = _Person._LastName;
            txb_NO.Text = _Person._NationalNO;
            txb_PhoneNumber.Text = _Person._PhoneNumber;
            txb_Email.Text = _Person._Email;
            cb_Countries.SelectedValue = _Person._NationalityCountryID;
            dtp_DateOfBirth.Value = _Person._DateOfBirth;
            if (_Person._Gender == 0)
            {
                rdb_Male.Checked = true;
            }
            else
            {
                rdb_Female.Checked = true;
            }
            txb_Address.Text = _Person._Address;

        }


    }
}
