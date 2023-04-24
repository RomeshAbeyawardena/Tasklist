using Microsoft.EntityFrameworkCore;

namespace TaskList.Persistence.SqlServer;

public class TaskListDbContext : DbContext
{
    public TaskListDbContext(DbContextOptions<TaskListDbContext> options)
        : base(options)
    {
        
    }
}
