using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WindowsForm_Presentation
{
    public partial class ctrAdd_EditPerosn : UserControl
    {
        public ctrAdd_EditPerosn()
        {
            InitializeComponent();
            dtp_DateOfBirth.MaxDate = DateTime.Now - new TimeSpan(365 * 18, 0, 0, 0);
        }


    }
}
