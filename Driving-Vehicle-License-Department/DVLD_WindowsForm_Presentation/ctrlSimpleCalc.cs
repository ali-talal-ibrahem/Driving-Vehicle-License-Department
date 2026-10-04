using System;
using System.Windows.Forms;

namespace DVLD_WindowsForm_Presentation
{
    public partial class ctrlSimpleCalc : UserControl
    {
        public ctrlSimpleCalc()
        {
            InitializeComponent();
        }

        public float Result
        {
            get { return (float)Convert.ToDouble(label1.Text); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
            label1.Visible = true;
        }
    }
}
