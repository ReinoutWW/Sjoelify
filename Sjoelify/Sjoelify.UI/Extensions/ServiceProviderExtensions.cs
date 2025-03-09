using Microsoft.Extensions.DependencyInjection;
using Radzen;

namespace Sjoelify.UI.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static IServiceCollection AddUIComponents(this IServiceCollection services)
        {
            return services.AddRadzenComponents();
        }
    }
}
