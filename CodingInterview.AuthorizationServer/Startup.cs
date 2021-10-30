using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CodingInterview.AuthorizationServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
                    options => { options.LoginPath = "/account/login"; });

            services.AddDbContext<DbContext>(options =>
            {
                options.UseInMemoryDatabase(nameof(DbContext));
                options.UseOpenIddict();
            });

            services.AddOpenIddict()
                .AddCore(options =>
                {
                    options.UseEntityFrameworkCore()
                        .UseDbContext<DbContext>();
                })
                .AddServer(options =>
                {
                    options
                        .AllowAuthorizationCodeFlow()
                        .RequireProofKeyForCodeExchange()
                        .AllowClientCredentialsFlow()
                        .AllowRefreshTokenFlow();

                    options
                        .SetTokenEndpointUris("/connect/token")
                        .SetAuthorizationEndpointUris("/connect/authorize")
                        .SetTokenEndpointUris("/connect/token")
                        .SetUserinfoEndpointUris("/connect/userinfo");

                    // Encryption and signing of tokens
                    // TODO Use X509 in prod
                    options
                        .AddEphemeralEncryptionKey()
                        .AddEphemeralSigningKey()
                        .DisableAccessTokenEncryption();

                    // Register scopes (permissions)
                    options.RegisterScopes("api");

                    // Register the ASP.NET Core host and configure the ASP.NET Core-specific options.
                    options
                        .UseAspNetCore()
                        .EnableTokenEndpointPassthrough()
                        .EnableAuthorizationEndpointPassthrough()
                        .EnableUserinfoEndpointPassthrough(); 
                });
            
            services.AddHostedService<TestData>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseStaticFiles()
                .UseRouting()
                .UseAuthentication()
                .UseAuthorization()
                .UseEndpoints(endpoints => { endpoints.MapDefaultControllerRoute(); });
        }
    }
}