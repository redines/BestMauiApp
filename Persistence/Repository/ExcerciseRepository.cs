using Application.Contracts.Persistance;
using Domain.Entities;

namespace Persistence.Repository
{
    public class ExcerciseRepository : BaseRepository<Excercise>, IExcerciseRepository
    {
        public ExcerciseRepository(MauDbcontext dbcontext) : base(dbcontext)
        {

        }
    }
}
