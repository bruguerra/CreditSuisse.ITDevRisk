using Application.AppServices;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Interfaces;

namespace Application.Configuration
{
    public static class ServicesConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ITradeService, TradeService>()
                    .AddScoped<ITradeAppService, TradeAppService>();

            services.AddAutoMapper(typeof(AutoMapperConfig));
        }
    }
}
