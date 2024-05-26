using Application.Contracts.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        readonly static string dbPath = Path.Combine(FileSystem.AppDataDirectory, "blogs.db3");
        public static IServiceCollection AddPersistenceServices(this
        IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MauDbcontext>(options =>
            options.UseSqlite($"Filename={dbPath}"));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IExcerciseRepository, ExcerciseRepository>();
            return services;
        }
    }
}
