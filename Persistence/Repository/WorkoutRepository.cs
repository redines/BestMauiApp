using Application.Contracts.Persistance;
using Domain.Entities.ExcerciseEntities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class WorkoutRepository : BaseRepository<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(WorkoutDbcontext dbcontext) : base(dbcontext)
        {

        }

        public async Task<List<Workout>> GetWorkoutswithExcercises()
        {
            var allWorkouts = await _dbContext.Workout  //.Include(x => x.Excercises)
                                              .ToListAsync();
            return allWorkouts;
        }
    }
}
