using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Abstract
{
    public interface IEmployeeService
    {
        void Create(Employee entity);
        void Update(Employee entity);
        void Delete(Employee entity);
        List<Employee> GetAllList();
        IQueryable<Employee> ListQueryable();
    }
}
