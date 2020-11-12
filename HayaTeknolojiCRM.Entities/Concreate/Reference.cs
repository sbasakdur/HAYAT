using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class Reference
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReferenceId { get; set; }
        [StringLength(100)]
        public string ReferenceFullName { get; set; }
        [StringLength(100)]
        public string JobRole { get; set; }
        [StringLength(100)]
        public string Contact { get; set; }
        public int EmpID { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
