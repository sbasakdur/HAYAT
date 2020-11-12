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
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public void Create(Employee entity)
        {
            _employeeDal.Create(entity);
        }

        public void Delete(Employee entity)
        {
            _employeeDal.Delete(entity);
        }

        public List<Employee> GetAllList()
        {
            return _employeeDal.GetAllList();
        }

        public IQueryable<Employee> ListQueryable()
        {
            return _employeeDal.ListQueryable();
        }

        public void Update(Employee entity)
        {
            _employeeDal.Update(entity);
        }
    }
}
