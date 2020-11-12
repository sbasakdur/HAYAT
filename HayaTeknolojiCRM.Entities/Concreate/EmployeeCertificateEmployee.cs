using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeCertificateEmployee
    {
        public int EmpID { get; set; }
        public int CertificateID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual EmployeeCertificate EmployeeCertificate { get; set; }
    }
}
