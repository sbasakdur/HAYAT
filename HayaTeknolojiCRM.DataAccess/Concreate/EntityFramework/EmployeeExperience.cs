using HayaTeknolojiCRM.DataAccess.Abstract;
using HayaTeknolojiCRM.DataAccess.Concreate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.Concreate.EntityFramework
{
    public class EmployeeExperience : EntityRepository<EmployeeExperience, DatabaseContext>, IEmployeeExperienceDal
    {
    }
}
