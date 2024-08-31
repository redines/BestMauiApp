using Domain.Entities.ExcerciseEntities;

namespace Application.Features.Excerices.Queries.GetExcercises
{
    public class ExcerciseDetailVM
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Comment { get; set; }
        public int? Weight { get; set; }
        public int? Sets { get; set; }
        public int? Reps { get; set; }
        public string Day { get; set; }
    }
}
