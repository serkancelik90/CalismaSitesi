using CalismaSitesi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CalismaSitesi.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private TContext _context;
        private DbSet<TEntity> _dbSet;
        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            //using (TContext context = new TContext())
            //{
            //    var deletedEntity = context.Entry(entity);
            //    deletedEntity.State = EntityState.Deleted;
            //    context.SaveChanges();
            //}
            _dbSet.Remove(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            //using (TContext context = new TContext())
            //{
            //    return context.Set<TEntity>().SingleOrDefault(filter);
            //}
            return _dbSet.FirstOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            //using (TContext context = new TContext())
            //{
            //    return filter != null ? context.Set<TEntity>().Where(filter).ToList() : context.Set<TEntity>().ToList();
            //}
            return _dbSet.Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
