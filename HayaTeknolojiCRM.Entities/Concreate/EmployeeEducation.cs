using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeEducation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationId { get; set; }

        [Display(Name = "Okul Adı")]
        [StringLength(35)]
        public string SchoolName { get; set; }

        [Display(Name = "Bölümü")]
        [StringLength(50)]
        public string SchoolDepartment { get; set; }

        [Display(Name = "Derece")]
        [StringLength(25)]
        public string Grade { get; set; }

        [Display(Name = "Eğitim Durumu")]
        [StringLength(25)]
        public string Status { get; set; }
        public int EmpID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
