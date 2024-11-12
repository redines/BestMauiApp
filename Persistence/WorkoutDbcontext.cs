using Domain.Common;
using Domain.Entities.ExcerciseEntities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class WorkoutDbcontext : DbContext
    {
        public WorkoutDbcontext(DbContextOptions<WorkoutDbcontext>
        options) : base(options)
        {
        }

        public DbSet<Excercise> Excercises { get; set; }
        public DbSet<Workout> Workout { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(MauDbcontext).Assembly);
        //}

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
