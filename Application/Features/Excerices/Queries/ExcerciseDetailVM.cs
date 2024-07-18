using Domain.Entities.ExcerciseEntities;

namespace Application.Features.Excerices.Queries
{
    public class ExcerciseDetailVM
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
        public bool sunday { get; set; }
    }
}
