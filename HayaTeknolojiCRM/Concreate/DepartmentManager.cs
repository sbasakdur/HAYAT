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
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Create(Department entity)
        {
            _departmentDal.Create(entity);
        }

        public void Delete(Department entity)
        {
            _departmentDal.Delete(entity);
        }

        public List<Department> GetAllList()
        {
            return _departmentDal.GetAllList();
        }

        public Department GetById(int? id)
        {
            return _departmentDal.GetById(id);
        }

        public IQueryable<Department> ListQueryable()
        {
            return _departmentDal.ListQueryable();
        }

        public void Update(Department entity)
        {
            _departmentDal.Update(entity);
        }
    }
}
