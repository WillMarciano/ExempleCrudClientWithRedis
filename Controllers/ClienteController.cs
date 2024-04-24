using ExempleCrudClientWithRedis.Model;
using ExempleCrudClientWithRedis.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ExempleCrudClientWithRedis.Controllers
{
    /// <summary>
    /// Controller de cliente
    /// </summary>
    /// <param name="clienteRepository"></param>
    [ApiController]
    [Route("[controller]/v1/")]
    public class ClienteController(IClienteRepository clienteRepository) : ControllerBase
    {
        /// <summary>
        /// Retorna todos os clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetClientes")]
        public async Task<IEnumerable<Cliente?>> Get() 
            => await clienteRepository.GetClientes();

        /// <summary>
        /// Retorna um cliente pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetCliente/{id}")]
        public async Task<Cliente?> Get(int id) 
            => await clienteRepository.GetCliente(id);

        /// <summary>
        /// Adiciona um cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPost("AddCliente")]
        public async Task<IActionResult> Post(Cliente cliente) 
            => await clienteRepository.AddCliente(cliente) ? Ok() : BadRequest();

        /// <summary>
        /// Delete um cliente pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("DeleteCliente/{id}")]
        public async Task<IActionResult> Delete(int id) 
            => await clienteRepository.DeleteCliente(id) ? Ok() : BadRequest();
    }
}
