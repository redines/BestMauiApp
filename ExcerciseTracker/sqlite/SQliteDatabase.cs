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

        public async Task<List<Excercise>> GetExcercisesAsync()
        {
            await Init();
            return await Database.Table<Excercise>().ToListAsync();
        }

        public async Task<Excercise> GetExcerciseAsync(Guid id)
        {
            await Init();
            return await Database.Table<Excercise>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(Excercise Excercise)
        {
            await Init();
            //if (Excercise.Id != 0)
            //    return await Database.UpdateAsync(Excercise);
            //else
            return await Database.InsertAsync(Excercise);
        }

        public async Task<int> DeleteItemAsync(Excercise Excercise)
        {
            await Init();
            return await Database.DeleteAsync(Excercise);
        }
    }
}
