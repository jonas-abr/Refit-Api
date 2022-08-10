using Refit;
using SimpleApi.DataAccess.Interfaces;

namespace SimpleApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string ConfigExternalOnionArchitectureApi = "External:OnionArchitectureApi";

        public static IServiceCollection AddExternalApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            var baseUrlOnionArchitectureApi = configuration[ConfigExternalOnionArchitectureApi];
            services.AddRefitClient<ICustomerData>()
                .ConfigureHttpClient(config => config.BaseAddress = new Uri(baseUrlOnionArchitectureApi));
            return services;
        }
    }
}
