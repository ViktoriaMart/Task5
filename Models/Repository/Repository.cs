using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;
using Models.Interfaces;

namespace Models
{
    //class OrderRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    //{
    //    DbContext Context;
    //    DbSet<TEntity> DbSet;

    //    public OrderRepository(DbContext context)
    //    {
    //        Context = context;
    //        DbSet = context.Set<TEntity>();
    //    }

    //    public IEnumerable<TEntity> Get()
    //    {
    //        return DbSet.AsNoTracking().ToList();
    //    }

    //    public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
    //    {
    //        return DbSet.AsNoTracking().Where(predicate).ToList();
    //    }
    //    public TEntity FindById(int id)
    //    {
    //        return DbSet.Find(id);
    //    }

    //    public void Create(TEntity item)
    //    {
    //        DbSet.Add(item);
    //        Context.SaveChanges();
    //    }
    //    public void Update(TEntity item)
    //    {
    //        Context.Entry(item).State = EntityState.Modified;
    //        Context.SaveChanges();
    //    }
    //    public void Remove(TEntity item)
    //    {
    //        DbSet.Remove(item);
    //        Context.SaveChanges();
    //    }
    //    public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
    //    {
    //        return Include(includeProperties).ToList();
    //    }

    //    public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    //    {
    //        var query = Include(includeProperties);
    //        return query.Where(predicate).ToList();
    //    }

    //    private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
    //    {
    //        IQueryable<TEntity> query = DbSet.AsNoTracking();
    //        return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
    //    }
    //}
}
