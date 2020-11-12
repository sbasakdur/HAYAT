using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeAddress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string District { get; set; }
        [StringLength(50)]
        public string Neighborhood { get; set; }
        [StringLength(50)]
        public string Street { get; set; }
        [StringLength(10)]
        public string Number { get; set; }
        [StringLength(20)]
        public string PostCode { get; set; }
        public virtual ICollection<EmployeeAddressEmployee> EmployeeAddressEmployees { get; set; }
    }
}
