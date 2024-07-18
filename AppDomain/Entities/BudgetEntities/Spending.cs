using Domain.Common;

namespace Domain.Entities.BudgetEntities
{
    public class Spending : AuditableEntity
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public SpendingType SpendingType { get; set; }
    }
}
