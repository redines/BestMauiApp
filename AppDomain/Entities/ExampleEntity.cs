using Domain.Common;

namespace Domain.Entities
{
    //To be used as a template class for an entity
    public class ExampleEntity : AuditableEntity
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string ExampleDescription { get; set; }
    }
}
