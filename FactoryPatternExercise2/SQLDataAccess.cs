using System;
using System.Collections.Generic;
namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }

        public static List<Product> products = new List<Product>()
        {
            new Product()
            { Name = "chips", Price = 2.00 },

            new Product()
            { Name = "chapstick", Price = 2.75 }

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL database.");
        }

    }
}
