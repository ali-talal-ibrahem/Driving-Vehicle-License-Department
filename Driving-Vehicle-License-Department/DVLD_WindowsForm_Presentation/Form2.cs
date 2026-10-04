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

        private int _PersonId;

        public Form2(int PersonId)
        {
            InitializeComponent();
            _PersonId = PersonId;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = $"Person ID: {_PersonId}";
        }
    }
}
