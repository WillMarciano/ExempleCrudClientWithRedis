using ExempleCrudClientWithRedis.Model;
using ExempleCrudClientWithRedis.Repository;
using StackExchange.Redis;

namespace ExempleCrudClientWithRedis.Configuration
{
    public static class DependecyInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            var c = configuration.GetSection("RedisConfiguration").Get<RedisConfiguration>();
            services.AddSingleton<IConnectionMultiplexer>(sp =>
            {                
                return ConnectionMultiplexer.Connect(c.ConnectionString);
            });

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddControllers();
        }
    }
}
