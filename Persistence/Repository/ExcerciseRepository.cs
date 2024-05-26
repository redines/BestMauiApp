using Application.Contracts.Persistance;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class ExcerciseRepository : BaseRepository<ExcerciseEntity>, IExcerciseRepository
    {
        public ExcerciseRepository(MauDbcontext dbcontext) : base(dbcontext)
        {

        }
    }
}
