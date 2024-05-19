//using SQLite;

namespace BestMauiApp.Models
{
    //[Table("ExcerciseWeek")]
    public class ExcerciseModel
    {
        //[PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public int week { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set;}
        public bool Wednesday { get;set;}
        public bool Thursday { get; set;}   
        public bool Friday { get; set;}
    }
}
