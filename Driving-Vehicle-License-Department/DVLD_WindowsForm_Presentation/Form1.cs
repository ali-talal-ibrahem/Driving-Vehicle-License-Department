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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlSimpleClick1_OnCalcComplet(int obj)
        {
            int Result = obj;
            if (Result < 1) {
                this.BackColor = Color.Green;
            }
            else{
                this.BackColor = Color.Red;
            }

        }
    }
}
