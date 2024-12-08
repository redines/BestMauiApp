
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
            await Database.CreateTableAsync<Workout>();
            await Database.CreateTableAsync<Excercise>();
            
        }

        public async Task<List<Excercise>> GetExcercisesAsync()
        {
            await Init();
            return await Database.Table<Excercise>().ToListAsync();
        }

        public async Task<List<Workout>> GetWorkoutsAsync()
        {
            await Init();
            return await Database.Table<Workout>().ToListAsync();
        }

        public async Task<Excercise> GetExcerciseAsync(Guid id)
        {
            await Init();
            return await Database.Table<Excercise>().Where(i => i.ExcerciseId == id).FirstOrDefaultAsync();
        }

        public async Task<Workout> GetWorkoutAsync(Guid id)
        {
            await Init();
            return await Database.Table<Workout>().Where(i => i.WorkoutId == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveExcerciseAsync(Excercise Excercise)
        {
            await Init();
            //if (Excercise.Id != 0)
            //    return await Database.UpdateAsync(Excercise);
            //else
            return await Database.InsertAsync(Excercise);
        }

        public async Task<int> SaveWorkoutAsync(Workout Workout)
        {
            await Init();
            //if (Excercise.Id != 0)
            //    return await Database.UpdateAsync(Excercise);
            //else
            return await Database.InsertAsync(Workout);
        }

        public async Task<int> DeleteExcerciseAsync(Excercise Excercise)
        {
            await Init();
            return await Database.DeleteAsync(Excercise);
        }

        public async Task<int> DeleteWorkoutAsync(Workout Workout)
        {
            await Init();
            return await Database.DeleteAsync(Workout);
        }
    }
}
