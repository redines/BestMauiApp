using Domain.Common;

namespace Domain.Entities
{
    public class ExcerciseEntity : AuditableEntity
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string ExampleDescription { get; set; }
        public bool Monday { get; set; }
        public bool thuesday { get; set; }
        public bool Wednesday { get;set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set;}
    }
    }
}
