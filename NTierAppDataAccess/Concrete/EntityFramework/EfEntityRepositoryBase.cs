﻿using Microsoft.EntityFrameworkCore;
using NTierApp.DataAccess.Abstract;
using NTierApp.Entities.Abstract;

namespace NTierApp.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public List<TEntity> GetAll()
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().ToList();
        }

        public TEntity? Get(int id)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().SingleOrDefault();
        }

        public void Add(TEntity entity)
        {
            using TContext context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using TContext context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
