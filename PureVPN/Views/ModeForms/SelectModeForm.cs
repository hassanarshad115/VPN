using PureVPN.Interface;
using PureVPN.Views.ModeForms;
using System;
using System.Windows.Forms;

namespace PureVPN
{
    public partial class SelectModeForm : MaterialSkin.Controls.MaterialForm, IParent
    {
        public new Form ParentForm { get; set; }

        public SelectModeForm()
        {
            InitializeComponent();
        }

        private void SelectModeForm_Load(object sender, EventArgs e)
        {

        }

        private void pbxStream_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void pbxInternetFreedom_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void pbxSecurity_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void pbxFileShare_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void pbxDedicatedIp_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
