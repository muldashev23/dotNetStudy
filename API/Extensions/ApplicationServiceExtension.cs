using API.Data;
using API.Intefaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services, IConfiguration config)
        {   
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(options=>
            {
                options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
            });
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
    }   

}
