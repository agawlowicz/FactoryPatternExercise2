using System;
namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "sql":
                    return new SQLDataAccess();

                case "mongo":
                    return new MongoDataAccess();

                default: //should this be something other than list?
                    return new ListDataAccess();
            };
        }
    }
}
