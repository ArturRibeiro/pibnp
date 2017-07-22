using Pib.NP.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Pib.NP.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity<TEntity>
    {
        void Add(TEntity entity);

        TEntity GetId(Guid guid);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(Guid guid);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        int Save();
    }
}
