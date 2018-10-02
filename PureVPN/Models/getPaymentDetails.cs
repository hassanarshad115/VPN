using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureVPN.Models
{
    class getPaymentDetails
    {
        public string pAmount { get; set; }
        public int uid { get; set; }
        public string pType { get; set; }
        public DateTime pDate { get; set; }
        public string pCardNumber { get; set; }
        public int pSecurityCode { get; set; }
    }
}
