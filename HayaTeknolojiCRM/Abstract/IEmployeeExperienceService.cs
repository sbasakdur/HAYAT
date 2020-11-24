using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Abstract
{
    public interface IEmployeeExperienceService
    {
        void Create(EmployeeExperience entity);
        void Update(EmployeeExperience entity);
        void Delete(EmployeeExperience entity);
        IQueryable<EmployeeExperience> ListQueryable();
        EmployeeExperience GetExperienceById(int? id);
    }
}
