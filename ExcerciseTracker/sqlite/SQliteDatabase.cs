
using SQLite;
using ExcerciseTracker.Entities;

namespace ExcerciseTracker.sqlite
{
    public class SQliteDatabase
    {
        private SQLiteAsyncConnection Database;

        public SQliteDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
            {
                return;
            }

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await Database.CreateTableAsync<Workout>();
            await Database.CreateTableAsync<Exercise>();
            await Database.CreateTableAsync<WorkoutExercise>();
        }

        public async Task<List<Exercise>> GetExcercisesAsync()
        {
            await Init();
            return await Database.Table<Exercise>().ToListAsync();
        }

        public async Task<List<Workout>> GetWorkoutsAsync()
        {
            await Init();
            return await Database.Table<Workout>().ToListAsync();
        }

        public async Task<Exercise> GetExcerciseAsync(int id)
        {
            await Init();
            return await Database.Table<Exercise>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Exercise>> GetExercisesByWorkoutIdAsync(int workoutId) { 
            await Init();

            var x =  await Database.QueryAsync<Exercise>(
            "SELECT e.* FROM Exercise e INNER JOIN WorkoutExercise we ON e.Id = we.ExerciseId INNER JOIN Workout w ON w.Id = we.WorkoutId WHERE we.WorkoutId = ?",
            workoutId);

            return x.ToList();
        }

        public async Task<Workout> GetWorkoutAsync(int id)
        {
            await Init();
            return await Database.Table<Workout>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveExcerciseAsync(Exercise Excercise)
        {
            await Init();
            if (Excercise.Id != 0)
            {
                return await Database.UpdateAsync(Excercise);
            }
            else
            {
                return await Database.InsertAsync(Excercise);
            }
        }

        public async Task<int> SaveExerciseToWorkout(WorkoutExercise we)
        {
            await Init();
            if (we.Id != 0)
            {
                return await Database.UpdateAsync(we);
            }
            else
            {
                return await Database.InsertAsync(we);
            }
        }

        public async Task<int> SaveWorkoutAsync(Workout Workout)
        {
            await Init();
            if (Workout.Id != 0)
            {
                return await Database.UpdateAsync(Workout);
            }
            else
            {
                return await Database.InsertAsync(Workout);
            }
        }

        public async Task<int> DeleteExcerciseAsync(Exercise Excercise)
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
