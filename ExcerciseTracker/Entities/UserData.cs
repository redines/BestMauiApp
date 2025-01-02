using SQLite;

namespace ExcerciseTracker.Entities
{
    class UserData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DaysExercised { get; set; }
        public string? PhotoFilePath { get; set; }
    }
}
