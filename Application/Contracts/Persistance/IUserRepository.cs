using Domain.Entities.ExcerciseEntities;

namespace Application.Contracts.Persistance
{
    public interface IUserRepository : IAsyncRepository<User>
    {
    }
}
