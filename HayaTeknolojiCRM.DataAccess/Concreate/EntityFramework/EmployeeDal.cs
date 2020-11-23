using HayaTeknolojiCRM.DataAccess.Abstract;
using HayaTeknolojiCRM.DataAccess.Concreate.Context;
using HayaTeknolojiCRM.Entities.Concreate;
using System;
using HayaTeknolojiCRM.DataAccess.Concreate.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayaTeknolojiCRM.DataAccess.ViewModels;

namespace HayaTeknolojiCRM.DataAccess.Concreate.EntityFramework
{
    public class EmployeeDal : EntityRepository<Employee, DatabaseContext>, IEmployeeDal
    {
        
        public List<Department> GetDepartment()
        {
            using (var context= new DatabaseContext())
            {
                return context.Set<Department>().ToList();
            }
        }

        //public List<Employee> GetEmployeePhone()
        //{
        //    using (var context = new DatabaseContext())
        //    {

        //        var empViewModel = (from emp in context.Employees
        //                            join e in context.EmployeePhoneEmployees
        //                            on emp.EmpId equals e.EmpID
        //                            join empphone in context.EmployeePhones
        //                            on e.PhoneID equals empphone.PhoneId
        //                            select new Employee { Name = emp.Name, Surname = emp.Surname, Email = emp.Email, EmployeePhoneEmployees = empphone.EmployeePhoneEmployees }).ToList();

        //        return empViewModel;
        //    }
        //}
    }
}