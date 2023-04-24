using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RST.EntityFrameworkCore.Extensions;
using TaskList.Persistence.SqlServer;

namespace TaskList.Persistence.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDbServices(this IServiceCollection services,
        string connectionStringName)
    {
        return services
            .AddDbContextAndRepositories<TaskListDbContext>(typeof(TaskListRepository<>),
            (s,cfg) => { 
                var applicationSettings = s.GetRequiredService<ApplicationSettings>();
                if(applicationSettings.ConnectionStrings.TryGetValue(connectionStringName, out var connectionString)) cfg.UseSqlServer(connectionString); 
            });
    }
}
