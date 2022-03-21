using Handbook.Contracts;
using Handbook.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Handbook.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        protected HandbookContext HandbookContext { get; set; }

        public RepositoryBase(HandbookContext handbookContext)
        {
            HandbookContext = handbookContext;
        }

        public void Create(T entity) => HandbookContext.Set<T>().Add(entity);

        public void Delete(T entity) => HandbookContext.Set<T>().Remove(entity);

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            HandbookContext.Set<T>()
            .AsNoTracking() :
            HandbookContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            HandbookContext.Set<T>()
            .Where(expression)
            .AsNoTracking() :
            HandbookContext.Set<T>()
            .Where(expression);
    }
}
