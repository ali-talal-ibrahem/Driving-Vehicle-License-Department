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

namespace DVLD_WindowsForm_Presentation
{
    public partial class frmAdd_EditPreson : Form
    {
        private int _PersonID;

        public frmAdd_EditPreson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

        }

        private void frmAdd_EditPreson_Load(object sender, EventArgs e)
        {
            if(_PersonID == -1)
            {
                this.Text = "DVLD - Add New Person";
                lbl_TitlePage.Text = "Add New Person";
            }
            else
            {
                this.Text = "DVLD - Edit Person";
                lbl_TitlePage.Text = "Edit Person ( " + _PersonID.ToString() + " )";
            }

            ctrAdd_EditPerosn1.ctrAdd_EditPerosn_Load(_PersonID);
        }
    }


}
