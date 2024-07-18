using Domain.Common;

namespace Domain.Entities.BudgetEntities
{
    public class SpendingType : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Descripion { get; set; }
    }
}
