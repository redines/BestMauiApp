using Domain.Entities;

namespace Application.Contracts.Persistance
{
    public interface IExcerciseRepository : IAsyncRepository<ExcerciseEntity>
    {
    }
}
