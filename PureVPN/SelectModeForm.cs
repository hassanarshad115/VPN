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
    public partial class SelectModeForm : MaterialSkin.Controls.MaterialForm
    {
        public SelectModeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreferenceForm pr = new PreferenceForm();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeModeForm pr = new ChangeModeForm();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            PreferenceForm pr = new PreferenceForm();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void picSecurity_Click(object sender, EventArgs e)
        {
            SecurityForm pa = new SecurityForm();
            if (pa == null)
            {
                pa.Parent = this;
            }
            pa.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InternetFreedomForm iff = new InternetFreedomForm();
            if (iff == null)
            {
                iff.Parent = this;
            }
            iff.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FileShareForm fsf = new FileShareForm();
            if (fsf == null)
            {
                fsf.Parent = this;
            }
            fsf.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            DedicatedIPForm dip = new DedicatedIPForm();
            if (dip == null)
            {
                dip.Parent = this;
            }
            dip.Show();
            this.Hide();
        }
    }
}
