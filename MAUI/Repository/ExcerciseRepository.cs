using BestMauiApp.Models;
//using SQLite;

namespace BestMauiApp.Repository
{
    public class ExcerciseRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        //private SQLiteAsyncConnection conn;

        private async Task Init()
        {
            //if (conn != null)
              //  return;

            //conn = new SQLiteAsyncConnection(_dbPath);
            //await conn.CreateTableAsync<ExcerciseModel>();
        }

        public ExcerciseRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task<int> AddNewExcerciseWeek(ExcerciseModel excercise)
        {
            int result;
            try
            {
                Init();

                // basic validation to ensure a name was entered
                //if (string.IsNullOrEmpty(excercise.))
                //    throw new Exception("Valid name required");

               /* result = await conn.InsertAsync(new ExcerciseModel { 
                    week = excercise.week,
                    Monday = excercise.Monday,
                    Tuesday = excercise.Tuesday,
                    Wednesday = excercise.Wednesday,
                    Thursday = excercise.Thursday,
                    Friday = excercise.Friday
                });*/

                /*StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, excercise);*/

                return 0;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", excercise, ex.Message);
            }

            return 0;
        }
        /*
        public async Task<ExcerciseModel> GetByExcerciseWeek(int week)
        {
            /*var user = from u in conn.Table<ExcerciseModel>()
                       where u.week == week
                       select u;
            return await user.FirstOrDefaultAsync();
        }
    */

        public async Task<int> UpdateExcercise(ExcerciseModel excercise)
        {
            int result = 0;
            try
            {
                Init();
                //result = await conn.UpdateAsync(excercise);
                
                return result;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to update data. {0}", ex.Message);
            }

            return result;
        }

        public async Task<List<ExcerciseModel>> GetAllExcerciseWeeks()
        {
            try
            {
                Init();
                return null;//await conn.Table<ExcerciseModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<ExcerciseModel>();
        }
    }
}