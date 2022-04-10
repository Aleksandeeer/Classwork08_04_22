using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork08_04_22
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }
        public string Name
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            OKButton.DialogResult = DialogResult.OK;
        }
    }
}
