using Domain.Common;

namespace Domain.Entities.ExcerciseEntities
{
    [Serializable]
    public class User : AuditableEntity
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public int TimesExcercised { get; set; }
    }
}
