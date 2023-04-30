using System.Diagnostics.CodeAnalysis;
using Core.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

[SuppressMessage("Naming", "CA1716:Identifiers should not match keywords",
    Justification = "Best name for this class.")]
public static class Module
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient(typeof(ICommandWithResultHandler<,>), typeof(Module).Assembly);
        services.AddTransient(typeof(ICommandHandler<>), typeof(Module).Assembly);
        services.AddTransient(typeof(IQueryHandler<,>), typeof(Module).Assembly);

        return services;
    }
}