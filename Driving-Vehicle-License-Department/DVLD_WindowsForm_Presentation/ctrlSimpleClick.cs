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
    public partial class ctrlSimpleClick : UserControl
    {

        public event Action<int> OnCalcComplet;

        protected virtual void CalcComplet(int Number) 
        {

            Action<int> handler = OnCalcComplet;
            if (handler != null) {
                handler(Number);
            }

        }

        public ctrlSimpleClick()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Number = 0;
            label1.Text = Number.ToString();
            if (OnCalcComplet != null) {
                CalcComplet(Number);
            }
        }
    }
}
