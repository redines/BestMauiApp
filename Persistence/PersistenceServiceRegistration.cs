﻿using Application.Contracts.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository;

namespace Persistence
{ 
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this
        IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WorkoutDbcontext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("sqlservercon")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IExcerciseRepository, ExcerciseRepository>();
            services.AddScoped<IWorkoutRepository, WorkoutRepository>();
            return services;
        }
    }
}
