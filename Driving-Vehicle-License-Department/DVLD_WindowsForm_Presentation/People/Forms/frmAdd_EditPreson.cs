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
        private enum _enMode { AddPerson = 0, UpdatePerson = 1 };
        private _enMode _Mode = _enMode.AddPerson;

        private int _PersonID;
        private clsPeople _Person;


        public frmAdd_EditPreson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                _Mode = _enMode.AddPerson;
                this.Text += "Add New Person";
                lbl_TitlePage.Text = "Add New Person";
            }
            else { 
                _Mode = _enMode.UpdatePerson;
                this.Text += $"Edit Person ( {_PersonID} )";
                lbl_TitlePage.Text = $"Edit Person ( {_PersonID} )";
            }

        }
   
    
    
    
    
    
    
    }


}
