using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGraphsProgram
{
    public partial class GiveNames : Form
    {
        public GiveNames()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return NamesTB.Text; }
            set { NamesTB.Text = value; }
        }

        private void GiveNames_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancelBtn.PerformClick();
            }
        }

        private void GiveNames_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NamesTB.Text == null && DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Incorrect value!");
                e.Cancel = true;
            }
        }
    }
}
