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
    public partial class selectMode : MaterialSkin.Controls.MaterialForm
    {
        public selectMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preference pr = new preference();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            changeMode pr = new changeMode();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            preference pr = new preference();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void picSecurity_Click(object sender, EventArgs e)
        {
            security pa = new security();
            if (pa == null)
            {
                pa.Parent = this;
            }
            pa.Show();
            this.Hide();
        }
    }
}
