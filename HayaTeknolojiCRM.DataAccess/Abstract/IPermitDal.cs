using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.Abstract
{
    public interface IPermitDal : IEntityRepository<EmployeePermit>
    {
        List<Employee> GetEmployees();
        List<EmployeePermit> EmployeePermit(Expression<Func<EmployeePermit, bool>> filter = null);
        EmployeePermit GetPermitById(int? id);
    }
}
