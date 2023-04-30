using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTransient(this IServiceCollection services, Type openGenericType, Assembly assembly)
        {
            foreach (var type in assembly.GetTypes())
            {
                foreach (var implementedInterface in type.GetInterfaces())
                {
                    if (implementedInterface.IsGenericType 
                        && implementedInterface.GetGenericTypeDefinition() == openGenericType
                        && !type.ContainsGenericParameters)
                    {
                        services.AddTransient(implementedInterface, type);
                    }
                }
            }

            return services;
        }
    }
}
