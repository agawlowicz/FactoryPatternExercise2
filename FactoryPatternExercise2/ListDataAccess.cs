using System;
using System.Collections.Generic;
namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
        }

        public static List<Product> products = new List<Product>()
        {
            new Product()
            { Name = "gum", Price = 1.00 },

            new Product()
            { Name = "pepsi", Price = 2.50 }

        };

        //LoadData(): then return a new list of Product.

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a list.");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading from list.");
            return products;
        }
    }
}
