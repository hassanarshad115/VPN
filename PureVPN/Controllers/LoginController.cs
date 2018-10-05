using Atom.SDK.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureVPN.Controllers
{
    internal class LoginController
    {
        public static bool AuthenticateLogin(string userName, string password)
        {

            return true;
            
        }

        private void payPayPayment()
        {
            //getPaymentDetails pay = paymentMethod();
            int totalDayleft = 0;
            //if (pay.pDate != null)
            //{
            //    if (pay.pDate == new DateTime(2018, 4, 5))
            //    {
            //        totalDayleft = findDate(DateTime.Now.Date.AddDays(7), DateTime.Now.Date);
            //    }
            //    else
            //    {
            //        totalDayleft = findDate(pay.pDate, DateTime.Now.Date);
            //    }
            //    showtrial(totalDayleft);

            //}
        }


        //private int findDate(DateTime dateTime, DateTime now)
        //{
        //    getPaymentDetails py = new getPaymentDetails();
        //    return Convert.ToInt32((dateTime - now).TotalDays);
        //}

        //private getPaymentDetails paymentMethod()
        //{
        //    getPaymentDetails payment = new getPaymentDetails();

        //    string str = ConfigurationManager.ConnectionStrings["VPN"].ConnectionString;
        //    using (SqlConnection conn = new SqlConnection(str))
        //    {

        //        using (SqlCommand cmd = new SqlCommand("select  pDate from payment INNER JOIN Users on payment.iId = Users.iId where uEmail ='" + txtUsers.Text + "' ", conn))
        //        {
        //            conn.Open();
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            dr.Read();
        //            payment.pDate = Convert.ToDateTime(dr["pDate"]);
        //        }
        //    }
        //    return payment;
        //}


    }
}
