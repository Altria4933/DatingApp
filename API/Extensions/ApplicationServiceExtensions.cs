using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    //static means we don't need to create a new instance of the class to use it 
    {
        public static IServiceCollection AddApplicationServices (this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>(); 
            //implement for interfaces allows easier testing and it's best practices
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}