using DataAccess;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataServiceCollection(this IServiceCollection services, string connectionString)
    {
        services.AddTransient<ITourRepository, TourRepository>();

        services.AddDbContext<AdventourContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }
}