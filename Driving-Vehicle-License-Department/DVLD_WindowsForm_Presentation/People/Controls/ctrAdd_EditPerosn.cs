using System;
using System.Windows.Forms;
using DVLD_Business;
using System.Data;

namespace DVLD_WindowsForm_Presentation
{
    public partial class ctrAdd_EditPerosn : UserControl
    {
        public ctrAdd_EditPerosn()
        {
            InitializeComponent(); 
        }

        private void _FillAllCountriesInComboBox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            foreach(DataRow dr in dtCountries.Rows)
            {
                cb_Countries.Items.Add(dr["CountryName"]);
            }

        }

        private void ctrAdd_EditPerosn_Load(object sender, EventArgs e)
        {
            dtp_DateOfBirth.MaxDate = DateTime.Now - new TimeSpan(365 * 18, 0, 0, 0);
            _FillAllCountriesInComboBox();
        }
    }
}
