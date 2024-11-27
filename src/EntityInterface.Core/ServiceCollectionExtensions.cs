using Microsoft.Extensions.DependencyInjection;

namespace EntityInterface.Core;

public static class ServiceCollectionExtensions
{
    public static void AddEntityInterfaceCore(this IServiceCollection serviceCollection, 
        Action<EntityInterfaceOptions> optionsCallback)
    {
        EntityInterfaceOptions options = new();

        optionsCallback(options);
        
        serviceCollection.AddSingleton(options);
    }
}