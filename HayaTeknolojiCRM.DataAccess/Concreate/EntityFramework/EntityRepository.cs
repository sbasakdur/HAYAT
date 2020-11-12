using HayaTeknolojiCRM.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayaTeknolojiCRM.DataAccess.Concreate.EntityFramework
{
    public class EntityRepository<TEntity,TContext> : IEntityRepository<TEntity>
       where TEntity : class
       where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAllList()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int? id)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public IQueryable<TEntity> ListQueryable()
        {
            using (var context = new TContext())
            {
                var result = context.Set<TEntity>().AsQueryable<TEntity>();
                return result;
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {

                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
