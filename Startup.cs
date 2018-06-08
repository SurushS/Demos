using System.Reflection;
using Autofac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SaaS.Api
{
    public class Startup : SecureStartupBase
    {
        public const string ApiDescription = "";
       
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
            : base(configuration,  ApiDescription ,Assembly.GetExecutingAssembly().GetName(), environment)
        {
            
        }

        protected override void AddAppConfigurations(IApplicationBuilder app, IHostingEnvironment env)
        {
            
        }

        protected override void AddAuthorizationPolicies(AuthorizationOptions options)
        {
        }

        protected override void ConfigureAdditionalServices(IServiceCollection services)
        {
            
        }

        protected override void ConfigureAdditionalServices(ContainerBuilder containerBuilder)
        {
           
        }
    }
}
