using Domain.Common;

namespace Domain.Entities.ExcerciseEntities
{
    [Serializable]
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TimesExcercised { get; set; }
    }
}
