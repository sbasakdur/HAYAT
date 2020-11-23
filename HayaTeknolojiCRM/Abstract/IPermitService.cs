using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Abstract
{
    public interface IPermitService
    {
        void Create(EmployeePermit entity);

        void Delete(EmployeePermit entity);

        List<EmployeePermit> GetList(Expression<Func<EmployeePermit, bool>> filter);

        EmployeePermit GetById(int? id);

        IQueryable<EmployeePermit> ListQueryable();

        void Update(EmployeePermit entity);

        List<Employee> GetEmployees();

        List<EmployeePermit> EmployeePermit(Expression<Func<EmployeePermit, bool>> filter);
        EmployeePermit GetPermitById(int? id);
    }
}
