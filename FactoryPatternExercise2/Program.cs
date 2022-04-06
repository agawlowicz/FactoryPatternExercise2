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

            //database = new object determined from user input
            IDataAccess database = DataAccessFactory.GetDataAccessType(databaseUserInput);

            //assigned returned list of products type Products from LoadData method
            List<Product> products = database.LoadData();

            foreach(var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}\nProduct Price: {product.Price}\n");
            }

            database.SaveData();
        }
    }
}
