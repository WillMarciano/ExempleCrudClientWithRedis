using ExempleCrudClientWithRedis.Model;

namespace ExempleCrudClientWithRedis.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente?>> GetClientes();
        Task<Cliente?> GetCliente(int id);
        Task<bool> AddCliente(Cliente cliente);
        Task<bool> DeleteCliente(int id);
    }
}
