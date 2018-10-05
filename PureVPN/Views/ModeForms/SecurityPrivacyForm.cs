using PureVPN.Interface;
using System;
using System.Windows.Forms;

namespace PureVPN
{
    public partial class SecurityPrivacyForm : MaterialSkin.Controls.MaterialForm, IParent
    {
        public new Form ParentForm { get; set; }

        public SecurityPrivacyForm()
        {
            InitializeComponent();
        }

        private void SecurityPrivacyForm_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
