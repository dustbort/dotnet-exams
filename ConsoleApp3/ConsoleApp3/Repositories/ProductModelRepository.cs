using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConsoleApp3.Repositories
{
    public class ProductModelRepository : RepositoryBase<ProductModel>
    {
        public ProductModelRepository(IDbConnection connection) : base(connection)
        {
        }

        public async override Task<ProductModel> Create(ProductModel input)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public async override Task Delete(long id)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public async override Task<ProductModel> FindOne(long id)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public async override Task<ProductModel> Update(long id, ProductModel input)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}
