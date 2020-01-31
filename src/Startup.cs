using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Radzen;

namespace blazor.wasm.template
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<DialogService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
