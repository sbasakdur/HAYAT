using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeEmergencyContact
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
      
        [Display(Name = "Adı Soyadı")]
        [StringLength(100)]
        public string ContactName { get; set; }

        [Display(Name = "Yakınlık Derecesi")]
        [StringLength(50)]
        public string Proximity { get; set; }

        [Display(Name = "Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public int EmpID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
