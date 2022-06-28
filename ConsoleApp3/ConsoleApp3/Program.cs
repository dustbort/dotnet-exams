using Microsoft.Data.Sqlite;
using Dapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

/**
 * Implement the methods of the ProductModel repository.
 */

namespace ConsoleApp3
{
    class Program
    {
        public static void Main()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            string DB_PATH = Path.GetFullPath("../../../../../Data/AdventureWorksLT.db");
            Console.WriteLine(DB_PATH);

            using (var connection = new SqliteConnection("Data Source=" + DB_PATH))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                var repository = new Repositories.ProductModelRepository(connection);

                var name1 = "RockCreek1";
                var item = new Models.ProductModel() { 
                    Name = name1,
                };
                item = await repository.Create(item);

                Debug.Assert(item != null, "should not be null");
                Debug.Assert(item.Name == name1, "name should be " + name1);

                var name2 = "RockCreek2";
                item.Name = name2;

                item = await repository.Update(item.ID, item);

                Debug.Assert(item != null, "should not be null");
                Debug.Assert(item.Name == name2, "name should be " + name2);

                item = await repository.FindOne(item.ID);

                Debug.Assert(item != null, "should not be null");

                await repository.Delete(item.ID);

                item = await repository.FindOne(item.ID);

                Debug.Assert(item == null, "should be null");

                transaction.Rollback();
            }
        }
    }
}
