using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayaTeknolojiCRM.Web.ViewModels
{
    public class DepartmentDetailVM
    {
        public IEnumerable<Employee> Emp { get; set; }
        public IEnumerable<Department> Dept { get; set; }
    }
}