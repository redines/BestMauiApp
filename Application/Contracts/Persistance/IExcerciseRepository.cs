﻿using Domain.Entities.ExcerciseEntities;

namespace Application.Contracts.Persistance
{
    public interface IExcerciseRepository : IAsyncRepository<Excercise>
    {
    }
}
