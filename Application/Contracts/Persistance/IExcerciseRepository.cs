using Domain.Entities;

namespace Application.Contracts.Persistance
{
    internal interface IExcerciseRepository : IAsyncRepository<ExampleEntity>
    {
    }
}
