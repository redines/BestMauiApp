using Domain.Common;

namespace Domain.Entities
{
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}
