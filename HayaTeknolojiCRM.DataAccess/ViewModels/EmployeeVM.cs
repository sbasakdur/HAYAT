using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.ViewModels
{
    public class EmployeeVM
    {
        //public Employee employees { get; set; }
        //public EmployeePhone empPhones { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string empPhoneNumber { get; set; }
    }
}