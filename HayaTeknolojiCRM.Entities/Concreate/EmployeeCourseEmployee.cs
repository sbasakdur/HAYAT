using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Entities.Concreate
{
    public class EmployeeCourseEmployee
    {
        public int EmpID { get; set; }
        public int CourseID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual EmployeeCourse EmployeeCourse { get; set; }

    }
}
