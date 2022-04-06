using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
            Console.WriteLine("Accessing the Mongo database...\n");
        }

        public static List<Product> products = new List<Product>()
        {
            new Product() { Name = "ice cream", Price = 4.00 },

            new Product() { Name = "soap", Price = 1.50 }

        };

        public void SaveData()
        {
            Console.WriteLine("I am saving data from Mongo database.");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo database.\n");
            return products;
        }
    }
}
