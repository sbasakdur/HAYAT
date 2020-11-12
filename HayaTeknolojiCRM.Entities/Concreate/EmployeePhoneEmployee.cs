using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeePhoneEmployee
    {
        public int EmpID { get; set; }
        public int PhoneID { get; set; }
        public virtual EmployeePhone EmployeePhone { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
