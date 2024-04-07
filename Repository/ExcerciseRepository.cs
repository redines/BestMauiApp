using BestMauiApp.Models;
using SQLite;

namespace BestMauiApp.Repository
{
    internal class ExcerciseRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        private SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<ExcerciseModel>();
        }

        public ExcerciseRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void AddNewExcerciseWeek(ExcerciseModel excercise)
        {
            int result = 0;
            try
            {
                Init();

                // basic validation to ensure a name was entered
                //if (string.IsNullOrEmpty(excercise.))
                //    throw new Exception("Valid name required");

                result = conn.Insert(new ExcerciseModel { 
                    CurrentWeek = excercise.CurrentWeek,
                    Excercised = excercise.Excercised
                });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, excercise);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", excercise, ex.Message);
            }

        }

        public ExcerciseModel GetByExcerciseWeek(int week)
        {
            var user = from u in conn.Table<ExcerciseModel>()
                       where u.week == week
                       select u;
            return user.FirstOrDefault();
        }

        public int UpdateExcercise(ExcerciseModel excercise)
        {
            int result = 0;
            try
            {
                Init();
                result = conn.Update(excercise);
                
                return result;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to update data. {0}", ex.Message);
            }

            return result;
        }

        public List<ExcerciseModel> GetAllExcerciseWeeks()
        {
            try
            {
                Init();
                return conn.Table<ExcerciseModel>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<ExcerciseModel>();
        }
    }
}