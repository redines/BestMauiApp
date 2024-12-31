using SQLite;

namespace ExcerciseTracker.Entities
{
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Day { get; set; }
    }
}
