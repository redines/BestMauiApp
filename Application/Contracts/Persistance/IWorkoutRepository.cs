using Domain.Entities.ExcerciseEntities;

namespace Application.Contracts.Persistance
{
    public interface IWorkoutRepository : IAsyncRepository<Workout>
    {
    }
}
