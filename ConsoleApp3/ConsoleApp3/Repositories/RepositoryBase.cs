using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Repositories
{
    public abstract class RepositoryBase<T> 
        where T : class, IEntity, new()
    {
        protected readonly IDbConnection connection;

        public RepositoryBase(IDbConnection connection)
        {
            this.connection = connection;
        }

        public abstract Task<T> FindOne(long id);

        public abstract Task<T> Create(T input);

        public abstract Task<T> Update(long id, T input);

        public abstract Task Delete(long id);
    }
}
