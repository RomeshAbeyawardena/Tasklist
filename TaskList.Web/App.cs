using RST.AspNetCore.Extensions;
using System.Reflection;
using TaskList.Persistence.Extensions;
using TaskList.Api.Extensions;
using System.Text.Json.Serialization;

namespace TaskList.Web;

public class App : AppBootstrapBase
{
    public App(string appConfigurationFileName, IEnumerable<string> args, string? defaultAppConfigurationPath = null) : base(appConfigurationFileName, args, defaultAppConfigurationPath)
    {
    }

    public override void Configure(WebApplication app, IEnumerable<Assembly> assemblies)
    {
        throw new NotImplementedException();
    }

    public override void Configure(IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        if (!string.IsNullOrWhiteSpace(Configuration.ConnectionStringName))
        {
            services.AddDbServices(Configuration.ConnectionStringName);
        }
        services.AddTaskListCoreServices(assemblies);

        services
        .AddControllers()
        .AddJsonOptions(o => o.JsonSerializerOptions.Converters.Add(
            new JsonStringEnumConverter()))
        .AddApplicationParts(assemblies);
        
        services.AddSwaggerGen();
    }

    protected override void Dispose()
    {
        throw new NotImplementedException();
    }
}
