using Microsoft.EntityFrameworkCore;

namespace TaskTrackerApiV1.Models
{
    public class TaskTrackerApiContext : DbContext
    {
        public TaskTrackerApiContext(DbContextOptions<TaskTrackerApiContext> options)
        : base(options)
        {
        }

        public DbSet<TaskTrackerApi> TaskTrackerApiItems { get; set; } = null!;
    }
}
