using Domain.Entities;
using SQLite;

namespace BestMauiApp.Repository
{
    public class ExcerciseRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        private SQLiteAsyncConnection conn;

        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<Excercise>();
        }

        public ExcerciseRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task<int> AddNewExcerciseWeek(Excercise excercise)
        {
            int result;
            try
            {
                Init();

               result = await conn.InsertAsync(excercise);

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, excercise);

                return 0;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", excercise, ex.Message);
            }

            return 0;
        }
      
        /*public async Task<ExcerciseEntity> GetByExcerciseWeek(int week)
        {
            var user = from u in conn.Table<ExcerciseEntity>()
                       where u.week == week
                       select u;
            return await user.FirstOrDefaultAsync();
        }*/

        public async Task<int> UpdateExcercise(Excercise excercise)
        {
            int result = 0;
            try
            {
                Init();
                result = await conn.UpdateAsync(excercise);
                
                return result;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to update data. {0}", ex.Message);
            }

            return result;
        }

        public async Task<List<Excercise>> GetAllExcerciseWeeks()
        {
            try
            {
                Init();
                return await conn.Table<Excercise>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Excercise>();
        }
    }
}