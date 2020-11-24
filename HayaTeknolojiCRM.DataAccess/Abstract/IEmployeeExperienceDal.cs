using HayaTeknolojiCRM.DataAccess.Concreate.EntityFramework;
using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.Abstract
{
    public interface IEmployeeExperienceDal : IEntityRepository<EmployeeExperience>
    {
        EmployeeExperience GetExperienceById(int? id);
    }
}
