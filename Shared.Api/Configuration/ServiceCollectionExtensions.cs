using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shared.Api.Helpers;

namespace Shared.Api.Configuration
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