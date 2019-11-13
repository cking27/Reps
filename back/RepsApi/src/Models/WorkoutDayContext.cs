using Microsoft.EntityFrameworkCore;

namespace RepsApi.Models
{
    public class WorkoutDayContext : DbContext
    {
        public WorkoutDayContext(DbContextOptions<WorkoutDayContext> options)
            : base(options)
        {
        }

        public DbSet<WorkoutDay> WorkoutDays { get; set; }

        public DbSet<Set> Sets { get; set; }


        public DbSet<Station> Stations { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        public DbSet<StationSet> StationSets { get; set; }
    }
}