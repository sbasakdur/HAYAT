using HayaTeknolojiCRM.Abstract;
using HayaTeknolojiCRM.DataAccess.Abstract;
using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Concreate
{
    public class EmployeeExperienceManager : IEmployeeExperienceService
    {
        private readonly IEmployeeExperienceDal _employeeExpDal;
        public EmployeeExperienceManager(IEmployeeExperienceDal employeeExpDal)
        {
            _employeeExpDal = employeeExpDal;
        }
        public void Create(EmployeeExperience entity)
        {
            _employeeExpDal.Create(entity);
        }
        public void Update(EmployeeExperience entity)
        {
            _employeeExpDal.Update(entity);
        }
        public void Delete(EmployeeExperience entity)
        {
            _employeeExpDal.Delete(entity);
        }
        public IQueryable<EmployeeExperience> ListQueryable()
        {
            return _employeeExpDal.ListQueryable();
        }
        public EmployeeExperience GetExperienceById(int? id)
        {
            return _employeeExpDal.GetExperienceById(id);
        }
    }
}
