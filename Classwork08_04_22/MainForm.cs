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
    public partial class MainForm : Form
    {
        GameForm GF;

        public MainForm()
        {
            InitializeComponent();
            GF = new GameForm();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GF.Show();
        }

        private void RankedButton_Click(object sender, EventArgs e)
        {
            GF.RForm.Show();
        }
    }
}
