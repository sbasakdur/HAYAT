using HayaTeknolojiCRM.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.Abstract
{
    public interface IDepartmentService
    {
        void Create(Department entity);
        void Update(Department entity);
        void Delete(Department entity);
        List<Department> GetList(Expression<Func<Department, bool>> filter=null);
        IQueryable<Department> ListQueryable();
        Department GetById(int? id);
    }
}
