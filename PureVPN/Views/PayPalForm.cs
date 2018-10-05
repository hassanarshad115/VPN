using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Hassan;
using System.Text.RegularExpressions;

namespace PureVPN
{
    public partial class PayPalForm : MaterialSkin.Controls.MaterialForm
    {
        public PayPalForm()
        {
            InitializeComponent();
        }

        private void payName_Enter(object sender, EventArgs e)
        {
            if(payName.Text=="Enter Your Name")
            {
                payName.Text = "";
            }
        }

        private void payName_Leave(object sender, EventArgs e)
        {

            if (payName.Text == "")
            {
                payName.Text = "Enter Your Name";
            }
            Regex mRegxExpression;
            if (payName.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$");

                if (!mRegxExpression.IsMatch(payName.Text.Trim()))

                {

                    MessageBox.Show("Your name is not correct formate ", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    payName.Focus();
                  
                }
            }
        }

        private void payEmail_Enter(object sender, EventArgs e)
        {
            if(payEmail.Text=="Email Address")
            {
                payEmail.Text = "";
            }
        }

        private void payEmail_Leave(object sender, EventArgs e)
        {
            if (payEmail.Text == "")
            {
                payEmail.Text = "Email Address";
            }
            Regex mRegxExpression;
            if (payEmail.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(payEmail.Text.Trim()))

                {

                    Information.ErrorMessage("examlpe@gmail.com");

                    payEmail.Focus();
                   
                }
            }
        }
        private void payPhone_Enter(object sender, EventArgs e)
        {
            if(payPhone.Text== "001 233 243455")
            {
                payPhone.Text = "";
            }
        }

        private void payPhone_Leave(object sender, EventArgs e)
        {
            if (payPhone.Text == "")
            {
                payPhone.Text = "001 233 243455";
            }
            Regex mRegxExpression;
            if (payPhone.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex("^[0-9]+$");

                if (!mRegxExpression.IsMatch(payPhone.Text.Trim()))

                {

                    MessageBox.Show("Please enter only numbers.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    payPhone.Focus();

                }
            }
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            LoginForm pr = new LoginForm();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }
        public string name { get; set; }
        public string pass { get; set; }
        private void payPal_Load(object sender, EventArgs e)
        {
            pnlpaypal.Visible = false;
            payName.Text = name;
            payEmail.Text = pass;
        }
        private int randomNumber (int min,int max)
        {
            Random rn = new Random();
            return rn.Next(min, max);
        }
        private string randomString(int len)
        {
            StringBuilder sb = new StringBuilder();
            Random rm = new Random();
            Char value;
            for(int i = 0; i < len; i++)
            {
                value = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rm.NextDouble() + 65)));
                sb.Append(value);
            }
            return sb.ToString();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(randomNumber(10, 199));
            sb.Append(randomString(7));
            try
            {
                string str = ConfigurationManager.ConnectionStrings["VPN"].ConnectionString;
                SqlConnection connn = new SqlConnection(str);
                SqlCommand cmdd = new SqlCommand("select * from Users where uEmail='" + payEmail.Text + "'", connn);
                SqlDataAdapter da = new SqlDataAdapter();
                connn.Open();
                da.SelectCommand = cmdd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0) { 
                    Information.ErrorMessage("Your Email is already Register");
                }
                else
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("mytest383838@gmail.com");
                    mail.To.Add(payEmail.Text);
                    mail.Subject = "welcome";
                    mail.Body = "Your password is : " + sb.ToString() + "";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential("mytest383838@gmail.com", "azhar321");
                    smtp.Timeout = 20000;
                    smtp.Send(mail);
                    Information.InformationMessage("Your password is send on your email address");
                    
                    SqlConnection con = new SqlConnection(str);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SignUP_sendPass", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", payName.Text);
                    cmd.Parameters.AddWithValue("@email", payEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", payPhone.Text);
                    cmd.Parameters.AddWithValue("@pass", sb.ToString());
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date.AddDays(7));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    payName.Text = "";
                    payEmail.Text = "";
                    payPhone.Text = "";
                }
            }
            catch (Exception)
            {
                Information.ErrorMessage("Email sending is fail");
            }

        }
     
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if (pnlpaypal.Visible == false)
            {
                pnlpaypal.Visible = true;
            }
            else if(pnlpaypal.Visible==true)
            {
                pnlpaypal.Visible =false ;
            }
        }
    }
}
