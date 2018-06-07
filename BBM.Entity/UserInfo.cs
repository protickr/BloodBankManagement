using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.Entity
{
    public class UserInfo
    {
        public int UId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public int AddressId { get; set; }
        public int BloodId { get; set; }
        public int UserRole { get; set; }
        public string Password { get; set; }
        public System.DateTime Date { get; set; }
        public string BloodGroup { get; set; } //specially for edit details
    }
}
