using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.Entity
{
    public class RequestInfo
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string RequestTypeID { get; set; }
        public string BloodID { get; set; }
        public int Quantity { get; set; }
    }
}
