using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeExperience
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperienceId { get; set; }
        [StringLength(100)]
        public string CorporationName { get; set; }
        [StringLength(100)]
        public string JobRole { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Başlama Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Bitiş Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Ayrılma Nedeni")]
        [StringLength(100)]
        public string Reason { get; set; }
        public int EmpID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
