using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayaTeknolojiCRM.Web.ViewModels
{
    public class DepartmentDetailVM
    {
        public IEnumerable<Employee> Employee { get; set; }
        public IEnumerable<Department> Department { get; set; }
    }
}