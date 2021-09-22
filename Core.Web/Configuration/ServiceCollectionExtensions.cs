using Core.Web.Helpers;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Web.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureCancellationToken(this IServiceCollection collection)
        {
            return collection
                .AddSingleton<IHttpContextAccessor, HttpContextAccessor>()
                .AddScoped<BaseCancellationToken, RequestCancellationToken>();
        }
    }
}