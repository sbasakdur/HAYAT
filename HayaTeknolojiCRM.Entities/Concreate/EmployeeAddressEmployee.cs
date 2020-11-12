using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeAddressEmployee
    {
        public int EmpID { get; set; }
        public int AddressID { get; set; }
        public virtual EmployeeAddress EmployeeAddress { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
