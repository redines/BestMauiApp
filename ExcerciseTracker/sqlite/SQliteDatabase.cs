using Domain.Entities.ExcerciseEntities;
using SQLite;

namespace ExcerciseTracker.sqlite
{
    public class SQliteDatabase
    {
        SQLiteAsyncConnection Database;

        public SQliteDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await Database.CreateTableAsync<Excercise>();
            await Database.CreateTableAsync<Workout>();
        }
    }
}
