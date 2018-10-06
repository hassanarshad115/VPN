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
            MainForm.OpenForm(new StreamModeForm());
        }

        private void pbxInternetFreedom_Click(object sender, EventArgs e)
        {
            MainForm.OpenForm(new InternetFreedomForm());
        }

        private void pbxSecurity_Click(object sender, EventArgs e)
        {
            MainForm.OpenForm(new SecurityPrivacyForm());
        }

        private void pbxFileShare_Click(object sender, EventArgs e)
        {
            MainForm.OpenForm(new FileShareForm());
        }

        private void pbxDedicatedIp_Click(object sender, EventArgs e)
        {
            MainForm.OpenForm(new DedicatedIPForm());
        }
    }
}
