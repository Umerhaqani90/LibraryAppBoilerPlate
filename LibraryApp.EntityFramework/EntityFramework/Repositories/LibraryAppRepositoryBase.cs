using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace LibraryApp.EntityFramework.Repositories
{
    public abstract class LibraryAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LibraryAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected LibraryAppRepositoryBase(IDbContextProvider<LibraryAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class LibraryAppRepositoryBase<TEntity> : LibraryAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected LibraryAppRepositoryBase(IDbContextProvider<LibraryAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
