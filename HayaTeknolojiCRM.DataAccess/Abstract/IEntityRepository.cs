using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllList();
        IQueryable<T> ListQueryable();
        T GetById(int? id);
    }
}
