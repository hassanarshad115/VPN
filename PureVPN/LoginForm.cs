using System;
using Hassan;

namespace PureVPN
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckErrors()
        {
            if (txtUserName.Text == "Username")
            {
                Information.ErrorMessage("Please Enter the User Name");
                txtUserName.Focus();

                return false;
            }

            if (txtPassword.Text == "Password")
            {
                Information.ErrorMessage("Please Enter the Password");
                txtPassword.Focus();

                return false;
            }

            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            using (PayPalForm frm = new PayPalForm())
            {
                Hide();
                frm.ShowDialog();
                Show();
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Username")
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            MainSettings.OpenForm(this, new SelectModeForm());

            //MainSettings.ConfitureSystem(txtUserName.Text, txtPassword.Text);

            //if (CheckErrors() && LoginController.AuthenticateLogin(txtUserName.Text, txtPassword.Text))
            //{

            {
                //frm.emailp = txtUsers.Text;
                //frm.passwordP = txtPass.Text;

                //if (frm == null)
                //{
                //    frm.Parent = this;
                //}



            }
            //}
        }
    }
}
