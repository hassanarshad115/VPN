using PureVPN.Interface;
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
    public partial class InternetFreedomForm : MaterialSkin.Controls.MaterialForm, IParent
    {
        public new Form ParentForm { get; set; }

        public InternetFreedomForm()
        {
            InitializeComponent();
        }

        private void InternetFreedomForm_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
