using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureVPN
{
    public partial class PureVPNForm : MaterialSkin.Controls.MaterialForm
    {
        public PureVPNForm()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Hide();
            pictureBox7.Show();
            panel5.BackColor = Color.LightGray;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Hide();
            pictureBox8.Show();
            panel5.BackColor = Color.LightGreen;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            SecurityForm se = new SecurityForm();
            if (se == null)
            {
                se.Parent = this;
            }
            se.Show();
            this.Hide();
        }

        private void pureVPN_Load(object sender, EventArgs e)
        {
            pictureBox8.Hide();
            pictureBox7.Show();
            panel5.BackColor = Color.LightGray;
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeModeForm ch = new ChangeModeForm();
            if (ch == null)
            {
                ch.Parent = this;
            }
            this.Hide();
            ch.Show();
        }
    }
}
