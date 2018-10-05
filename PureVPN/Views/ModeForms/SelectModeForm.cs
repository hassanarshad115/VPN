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

        private void SelectModeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxStream_Click(object sender, EventArgs e)
        {
            StreamModeForm smf = new StreamModeForm();
            //(smf as IParent).ParentForm = ParentForm;                     ye set krna ha
            smf.Show();
            Hide();
        }

        private void pbxInternetFreedom_Click(object sender, EventArgs e)
        {
            InternetFreedomForm frm = new InternetFreedomForm();
            (frm as IParent).ParentForm = ParentForm;
            frm.Show();
            Hide();
        }

        private void pbxSecurity_Click(object sender, EventArgs e)
        {
            InternetFreedomForm frm = new InternetFreedomForm();
            (frm as IParent).ParentForm = ParentForm;
            frm.Show();
            Hide();
        }
    }
}
