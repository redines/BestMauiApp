using Domain.Common;

namespace Domain.Entities.ExcerciseEntities
{
    [Serializable]
    public class Excercise : AuditableEntity
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Excercisetype ExcerciseType { get; set; }
        public bool Monday { get; set; }
        public bool Thuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
    }
}
