using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeDependent
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DependentId { get; set; }

        [Display(Name = "Bakmakla Yükümlü Olduğu Kişinin Kimlik Numarası")]
        [StringLength(11)]
        public string DependentSSN { get; set; }

        [Display(Name = "Bakmakla Yükümlü Olduğu Kişinin Adı")]
        [StringLength(100)]
        public string DependentName { get; set; }

        [Display(Name = "Yakınlığı")]
        [StringLength(50)]
        public string Proximity { get; set; }
        public int EmpID { get; set; }


        public virtual Employee Employee { get; set; }
    }
}
