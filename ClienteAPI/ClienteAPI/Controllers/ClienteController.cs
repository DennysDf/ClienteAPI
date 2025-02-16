using ClienteAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClienteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
