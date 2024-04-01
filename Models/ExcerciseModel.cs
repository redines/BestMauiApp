namespace BestMauiApp.Models
{
    internal class ExcerciseModel
    {
        public string CurrentWeek { get; set; }
        public bool Excercised { get; set; }


        public ExcerciseModel() {
            CurrentWeek = Utils.Utils.GetCurrentWeek();
        }


        
        //TODO: Replace in the future with local database calls instead of files
        //public void Save() =>
        //    File.WriteAllText(Path.Combine(FileSystem.AppDataDirectory, Filename), Text);
        //public void Delete() =>
        //    File.Delete(Path.Combine(FileSystem.AppDataDirectory, Filename));

    }
}
