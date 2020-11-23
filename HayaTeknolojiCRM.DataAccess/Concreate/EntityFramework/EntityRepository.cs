﻿using HayaTeknolojiCRM.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {

                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Attach(entity);
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
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
    }
}
