﻿using System;
using Hassan;
using PureVPN.Interface;
using System.Windows.Forms;

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

            Application.Run(new SelectModeForm());
        }
    }
}
