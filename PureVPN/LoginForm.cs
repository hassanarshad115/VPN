using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PureVPN.Controls;
using Hassan;
using PureVPN.Models;

namespace PureVPN
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            //timer1.Start();
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void payPayPayment()
        {
            getPaymentDetails pay = paymentMethod();
            int totalDayleft = 0;
            if (pay.pDate != null)
            {
                if (pay.pDate == new DateTime(2018, 4, 5))
                {
                    totalDayleft = findDate(DateTime.Now.Date.AddDays(7), DateTime.Now.Date);
                }
                else
                {
                    totalDayleft = findDate(pay.pDate, DateTime.Now.Date);
                }
                showtrial(totalDayleft);

            }
        }
        public int days { get; set; }
        private void showtrial(int totalDayleft)
        {
            days = totalDayleft;
        }

        private int findDate(DateTime dateTime, DateTime now)
        {
            getPaymentDetails py = new getPaymentDetails();
            return Convert.ToInt32((dateTime - now).TotalDays);
        }

        private getPaymentDetails paymentMethod()
        {
            getPaymentDetails payment = new getPaymentDetails();

            string str = ConfigurationManager.ConnectionStrings["VPN"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {

                using (SqlCommand cmd = new SqlCommand("select  pDate from payment INNER JOIN Users on payment.iId = Users.iId where uEmail ='" + txtUsers.Text + "' ", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    payment.pDate = Convert.ToDateTime(dr["pDate"]);
                }
            }
            return payment;
        }

        private void txtUsers_Enter(object sender, EventArgs e)
        {

            if (txtUsers.Text == "Username")
            {
                txtUsers.Text = "";
            }
        }

        private void txtUsers_Leave(object sender, EventArgs e)
        {
            if (txtUsers.Text == "")
            {
                txtUsers.Text = "Username";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
            }
        }
        public int da { get; set; }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VPN"].ConnectionString);
            con.Open();
            if (isEmpty())
            {

                SqlCommand cmd = new SqlCommand("pure_VPN_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtUsers.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    payPayPayment();
                    if (days > 0)
                    {
                        con.Close();
                        Information.InformationMessage("Your trial is " + days + " days left");
                        PreferenceForm pr = new PreferenceForm();
                        pr.emailp = txtUsers.Text;
                        pr.passwordP = txtPass.Text;
                        if (pr == null)
                        {
                            pr.Parent = this;
                        }
                        pr.Show();
                        this.Hide();
                    }
                    else
                    {
                        Information.ErrorMessage("Your trial is expire.Pay on paypal account");
                    }

                }
               
            }
            

        }

        private bool isEmpty()
        {
            if (txtUsers.Text == "Username")
            {
                Information.ErrorMessage("Please Enter the User Name");
                txtUsers.Clear();
                txtUsers.Focus();
                return false;
            }
            if (txtPass.Text == "Password")
            {
                Information.ErrorMessage("Please Enter the Password");
                txtPass.Clear();
                txtPass.Focus();
                return false;
            }
            return true;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            PayPalForm pr = new PayPalForm();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
