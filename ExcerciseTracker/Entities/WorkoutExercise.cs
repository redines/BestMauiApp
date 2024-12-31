using SQLite;

namespace ExcerciseTracker.Entities
{
    public class WorkoutExercise
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public int ExerciseId { get; set; }
    }
}
