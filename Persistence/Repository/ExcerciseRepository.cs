using Application.Contracts.Persistance;
using Domain.Entities.ExcerciseEntities;

namespace Persistence.Repository
{
    public class WorkoutRepository : BaseRepository<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(WorkoutDbcontext dbcontext) : base(dbcontext)
        {

        }
    }
}
