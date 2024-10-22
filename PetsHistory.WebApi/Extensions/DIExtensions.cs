using PetsHistory.Application.Services;
using PetsHistory.Application.Services.Interfaces;

namespace PetsHistory.WebApi.Extensions
{
    public static class DIExtensions
    {
        public static IServiceCollection SetServices(this IServiceCollection collection)
        {
            collection = collection.AddScoped<IConfigurationService, ConfigurationService>();
            return collection;
        }
    }
}
