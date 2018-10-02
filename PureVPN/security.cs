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
    public partial class security : MaterialSkin.Controls.MaterialForm
    {
        public security()
        {
            InitializeComponent();
        }

        private void security_Load(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            button4.ForeColor = Color.White;
            pictureBox4.Hide();
            panel5.BackColor = Color.LightGray;
            pictureBox7.Hide();
            panel6.BackColor = Color.LightGray;
            pictureBox9.Hide();
            panel7.BackColor = Color.LightGray;
            pictureBox11.Hide();
            panel8.BackColor = Color.LightGray;
            pictureBox13.Hide();
            panel9.BackColor = Color.LightGray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            pictureBox5.Show();
            panel5.BackColor = Color.LightGray;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Hide();
            pictureBox4.Show();
            panel5.BackColor = Color.LightGreen;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
               pictureBox7.Hide();
               pictureBox6.Show();
               panel6.BackColor = Color.LightGray;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
              pictureBox6.Hide();
              pictureBox7.Show();
              panel6.BackColor = Color.LightGreen;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Hide();
            pictureBox8.Show();
            panel7.BackColor = Color.LightGray;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Hide();
            pictureBox9.Show();
            panel7.BackColor = Color.LightGreen;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Hide();
            pictureBox10.Show();
            panel8.BackColor = Color.LightGray;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Hide();
            pictureBox11.Show();
            panel8.BackColor = Color.LightGreen;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Hide();
            pictureBox12.Show();
            panel9.BackColor = Color.LightGray;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Hide();
            pictureBox13.Show();
            panel9.BackColor = Color.LightGreen;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
           
            selectMode pr = new selectMode();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            button4.ForeColor = Color.White;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
           

        //}

        private void pnlPure_Paint(object sender, PaintEventArgs e)
        {
            //pureVPN pu = new pureVPN();
            //if (pu == null)
            //{
            //    pu.Parent = this;
            //}
            //this.Hide();
            //pu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pureVPN pu = new pureVPN();
            if (pu == null)
            {
                pu.Parent = this;
            }
            this.Hide();
            pu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeMode ch = new changeMode();
            if (ch == null)
            {
                ch.Parent = this;
            }
            this.Hide();
            ch.Show();
        }
    }
}
