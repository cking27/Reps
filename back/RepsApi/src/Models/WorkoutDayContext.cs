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
    }
}