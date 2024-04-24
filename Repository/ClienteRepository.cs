using ExempleCrudClientWithRedis.Model;
using StackExchange.Redis;
using System.Text.Json;

namespace ExempleCrudClientWithRedis.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _database;

        public ClienteRepository(IConfiguration configuration)
        {
            var redisConfiguration = configuration.GetSection("RedisConfiguration").Get<RedisConfiguration>();
            _redis = ConnectionMultiplexer.Connect(redisConfiguration.ConnectionString);
            _database = _redis.GetDatabase();
        }
        public Task<bool> AddCliente(Cliente cliente)
        {
            var json = JsonSerializer.Serialize(cliente);
            return _database.StringSetAsync(cliente.Id.ToString(), json);
        }

        public Task<bool> DeleteCliente(int id)
        {
            var cliente = _database.StringGet(id.ToString());
            if (cliente.HasValue)            
                return _database.KeyDeleteAsync(id.ToString());
            return Task.FromResult(false);          
        }

        public Task<Cliente?> GetCliente(int id)
        {
            var cliente = _database.StringGet(id.ToString());
            return Task.FromResult(cliente.HasValue ? JsonSerializer.Deserialize<Cliente>(cliente!) : null);
        }

        public Task<IEnumerable<Cliente?>> GetClientes()
        {
            var clientes = _database.Multiplexer.GetServer(_redis.GetEndPoints().First()).Keys();
            return Task.FromResult(clientes.Select(key => JsonSerializer.Deserialize<Cliente>(_database.StringGet(key)!)));
        }
    }
}
