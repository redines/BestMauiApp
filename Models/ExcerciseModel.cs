using SQLite;

namespace BestMauiApp.Models
{
    [Table("ExcerciseWeek")]
    public class ExcerciseModel
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public int CurrentWeek { get; set; }
        public int week { get; set; }
        public bool Excercised { get; set; }
    }
}
