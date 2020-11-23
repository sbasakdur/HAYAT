using HayaTeknolojiCRM.DataAccess.Abstract;
using HayaTeknolojiCRM.DataAccess.Concreate.Context;
using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.Concreate.EntityFramework
{
    public class PermitDal:EntityRepository<EmployeePermit, DatabaseContext>, IPermitDal
    {
        public List<Employee> GetEmployees()
        {
            using (var context=new DatabaseContext())
            {
                return context.Set<Employee>().ToList();
            }
        }
        public EmployeePermit GetPermitById(int? id)
        {
            using (var context = new DatabaseContext())
            {
                return context.Set<EmployeePermit>().Include("Employee").Where(x => x.PermitID == id).FirstOrDefault();
            }
        }

        public List<EmployeePermit> EmployeePermit(Expression<Func<EmployeePermit, bool>> filter = null)
        {
            using(var context=new DatabaseContext())
            {
                return filter == null
                   ? context.Set<EmployeePermit>().Include("Employee").ToList()
                   : context.Set<EmployeePermit>().Include("Employee").Where(filter).ToList();
            }
        }
    }
}
