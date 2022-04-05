using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which one of the following databases would you like to use: list, SQL, Mango");
            var databaseUserInput = Console.ReadLine();

            IDataAccess database = DataAccessFactory.GetDataAccessType(databaseUserInput);

            List<Product> products = database.LoadData();
            foreach(var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}.\nProduct Price: {product.Price}.\n");
            }

            database.SaveData();
        }
    }
}
