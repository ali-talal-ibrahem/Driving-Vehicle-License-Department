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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.DataBack += Form2_DataBack;
            frm2.ShowDialog();
        }

        private void Form2_DataBack(object sender , int PersonID,string PersonName) 
        {
            textBox1.Text = PersonID.ToString();
            textBox2.Text = PersonName;
        
        }

    }
}
