using Domain.Common;

namespace Domain.Entities
{
    //To be used as a template class for an entity
    public class ExampleEntities : AuditableEntity
    {
        public Guid ExampleId { get; set; }
        public string ExampleName { get; set; }
        public ICollection<ExampleEntity> exampleList { get; set; }
    }
}
