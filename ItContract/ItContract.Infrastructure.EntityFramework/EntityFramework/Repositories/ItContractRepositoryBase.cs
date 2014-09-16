using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace ItContract.EntityFramework.Repositories
{
    public abstract class ItContractRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ItContractDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class ItContractRepositoryBase<TEntity> : ItContractRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
