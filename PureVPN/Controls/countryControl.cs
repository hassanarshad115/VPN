using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureVPN.Controls
{
    public partial class countryControl : UserControl
    {
        public countryControl()
        {
            InitializeComponent();
        }

        private void txtlocation_Enter(object sender, EventArgs e)
        {
            if (txtlocation.Text == "Your favorite location will be appaer here")
            {
                txtlocation.Text = "";
           }

        }

        private void txtlocation_Leave(object sender, EventArgs e)
        {
            if (txtlocation.Text == "")
            {
                txtlocation.Text = "Your favorite location will be appaer here";
           }
        }

        //private void comboBox1_Enter(object sender, EventArgs e)
        //{
        //    if(comboBox1.Text== "Your favorite location will be appaer here")
        //    {
        //        comboBox1.Text = "";
        //    }
        //}

        //private void comboBox1_Leave(object sender, EventArgs e)
        //{
        //    if (comboBox1.Text == "")
        //    {
        //        comboBox1.Text = "Your favorite location will be appaer here";
        //    }
        //}
    }
}
