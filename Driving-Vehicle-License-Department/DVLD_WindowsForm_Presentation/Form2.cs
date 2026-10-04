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
    public partial class Form2 : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID,string PresonName);
        public event DataBackEventHandler DataBack;


        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(textBox1.Text);
            string PersonName = textBox2.Text;

            DataBack?.Invoke(this, PersonID,PersonName);

            this.Close();
        }
    }
}
