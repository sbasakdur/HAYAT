using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeCertificate
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificateId { get; set; }
        public string CertificateName { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TakenDate { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [StringLength(100)]
        public string Institution { get; set; }
        public int MyProperty { get; set; }
        public virtual ICollection<EmployeeCertificateEmployee> EmployeeCertificateEmployees { get; set; }
    }
}
