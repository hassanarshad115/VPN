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
    public partial class LogOutBox : MaterialSkin.Controls.MaterialForm
    {
        public LogOutBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lng = new Login();
            if (lng == null)
            {
                lng.Parent = this;
            }
            lng.Show();
            this.Close();
        }
    }
}
