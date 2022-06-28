using Microsoft.Data.Sqlite;
using Dapper;
using System;
using System.Collections.Generic;
using BetterConsoleTables;
using System.IO;

/**
 * Query the customers whose total sales are in the top 10 percentile of all customers' total sales, excluding tax and shipping costs.
 * Ignore customers that had no sales.
 * Order by decreasing total sales.
 */

namespace ConsoleApp1
{

    class QueryResult
    {
        // TODO: implement the class
    }

    class Program
    { 
        static void Main(string[] args)
        {
            string DB_PATH = Path.GetFullPath("../../../../../Data/AdventureWorksLT.db");
            Console.WriteLine(DB_PATH);

            using (var connection = new SqliteConnection("Data Source=" + DB_PATH))
            {
                // TODO: implement the query
                var query = @"";

                var results = connection.Query<QueryResult>(query).AsList();

                PrintQueryResult(results);
            }
        }

        static void PrintQueryResult(List<QueryResult> results)
        {
            Table table = new Table("First Name", "Last Name", "Total Sales");

            // TODO: add the results as table rows

            Console.Write(table.ToString());
            Console.ReadKey();
        }
    }
}
