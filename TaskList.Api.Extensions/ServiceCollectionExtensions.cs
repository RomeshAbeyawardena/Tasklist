using Microsoft.Extensions.DependencyInjection;
using RST.DependencyInjection.Extensions;
using System.Reflection;

namespace TaskList.Api.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTaskListCoreServices(
        this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        var assesmbliesArray = assemblies.ToArray();
        return services.AddCoreServices()
            .AddServicesWithRegisterAttribute(c => { }, assesmbliesArray)
            .AddMediatR(c => c.RegisterServicesFromAssemblies(assesmbliesArray))
            .AddAutoMapper(assesmbliesArray);
    }
}
