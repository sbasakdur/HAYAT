using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Abstract
{
    public interface IEmployeeService
    {
        void Create(Employee entity);
        void Update(Employee entity);
        void Delete(Employee entity);
        List<Employee> GetList(Expression<Func<Employee, bool>> filter=null);
        Employee GetById(int? id);
        List<Department> GetDepartment();
        //List<Employee> GetEmployeePhone();
        IQueryable<Employee> ListQueryable();
    }
}