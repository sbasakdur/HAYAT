using HayaTeknolojiCRM.Abstract;
using HayaTeknolojiCRM.DataAccess.Abstract;
using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace HayaTeknolojiCRM.Concreate
{
    public class PermitManager : IPermitService
    {
        private readonly IPermitDal _permitDal;
        public PermitManager(IPermitDal permitDal)
        {
            _permitDal = permitDal;
        }
        public void Create(EmployeePermit entity)
        {
            _permitDal.Create(entity);
        }

        public void Delete(EmployeePermit entity)
        {
            _permitDal.Delete(entity);
        }

        public List<EmployeePermit> GetList(Expression<Func<EmployeePermit, bool>> filter)
        {
            return _permitDal.GetList(filter);
        }

        public EmployeePermit GetById(int? id)
        {
            return _permitDal.GetById(id);
        }

        public IQueryable<EmployeePermit> ListQueryable()
        {
            return _permitDal.ListQueryable();
        }

        public void Update(EmployeePermit entity)
        {
            _permitDal.Update(entity);
        }

        public List<Employee> GetEmployees()
        {
            return _permitDal.GetEmployees();
        }
        public List<EmployeePermit> EmployeePermit(Expression<Func<EmployeePermit, bool>> filter)
        {
            return _permitDal.EmployeePermit();
        }

        public EmployeePermit GetPermitById(int? id)
        {
            return _permitDal.GetPermitById(id);
        }
    }
}
