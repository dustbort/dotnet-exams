using Microsoft.Data.Sqlite;
using Dapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/**
 * Write to the console the hierarchical list of all product categories. Child product categories should be displayed in alphabetical order
 * by name below their parent product categories, with one more level of indentation than the parent.
 * 
 * Note: Due to compatibility issues with SQLite, you should cast the SQLite INTEGER values to INT type in your query. Null integer values will be 
 * converted to zero.
 */

namespace ConsoleApp2
{
    class Program
    {
        const int INDENT_SPACES = 3;

        static void Main(string[] args)
        {
            string DB_PATH = Path.GetFullPath("../../../../../Data/AdventureWorksLT.db");
            Console.WriteLine(DB_PATH);

            // TODO: implement
        }
    }
}
