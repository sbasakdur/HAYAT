using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeePermit
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermitID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Başlangıç Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Başlangıç Saati")]
        [DisplayFormat(DataFormatString = "{0:HH}", ApplyFormatInEditMode = true)]
        public DateTime StartHour { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Bitiş Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Bitiş Saati")]
        [DisplayFormat(DataFormatString = "{0:HH}", ApplyFormatInEditMode = true)]
        public DateTime EndHour { get; set; }

        [Display(Name = "İzin Türü")]
        [StringLength(20)]
        public string PermitType { get; set; }

        [Display(Name = "Durum")]
        [StringLength(20)]
        public string Status { get; set; }

        [Display(Name = "Gün Sayısı")]
        public int Day { get; set; }

        public int EmpID { get; set; }

        public bool Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
