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
    public partial class ctrlSimpleCalc : UserControl
    {
        public ctrlSimpleCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
            label1.Visible = true;
        }
    }
}
