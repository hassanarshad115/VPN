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
    public partial class ChangeModeForm : MaterialSkin.Controls.MaterialForm
    {
        public ChangeModeForm()
        {
            InitializeComponent();
        }

        private void changeMode_Load(object sender, EventArgs e)
        {
            //locationControl1.BackColor = Color.Transparent;
            panel8.Visible = false;
            panel5.Visible = true;
            panel4.Visible = true;
            panel7.Visible = false;
            panel6.Visible = false;
            countryControl1.Visible = false;
            lblpurpose.Visible = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            countryControl1.Visible = true;
            button5.CanFocus.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel5.Visible = false;
            panel4.Visible = false;
            locationControl1.Visible = false;
            countryControl1.Visible = false;
            if(panel8.Visible == true)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            locationControl1.Visible = true;
            lblpurpose.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
            countryControl1.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            label1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            SelectModeForm pr = new SelectModeForm();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
