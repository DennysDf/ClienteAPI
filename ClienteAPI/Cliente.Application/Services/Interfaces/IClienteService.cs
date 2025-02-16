using ClienteAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Application.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDTO>> GetClientes();
        Task<ClienteDTO> GetById(int? id);
        Task Add(ClienteDTO clienteDto);
        Task Update(ClienteDTO clienteDto);
        Task Delete(int? id);
    }
}
