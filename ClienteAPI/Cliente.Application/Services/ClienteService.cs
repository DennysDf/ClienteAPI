using AutoMapper;
using ClienteAPI.Application.DTOs;
using ClienteAPI.Application.Services.Interfaces;
using ClienteAPI.Domain.Models;
using ClienteAPI.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Application.Services
{
    public class ClienteService : IClienteService
    {

        private IClienteRepository _clienteRepository;

        private readonly IMapper _mapper;
        public ClienteService(IMapper mapper, IClienteRepository productRepository)
        {
            _clienteRepository = productRepository ??
                 throw new ArgumentNullException(nameof(productRepository));

            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteDTO>> GetClientes()
        {
            var productsEntity = await _clienteRepository.GetClientesAsync();
            return _mapper.Map<IEnumerable<ClienteDTO>>(productsEntity);
        }

        public async Task<ClienteDTO> GetById(int? id)
        {
            var productEntity = await _clienteRepository.GetByIdAsync(id);
            return _mapper.Map<ClienteDTO>(productEntity);
        }

        public async Task Add(ClienteDTO productDto)
        {
            var productEntity = _mapper.Map<Cliente>(productDto);
            await _clienteRepository.CreateAsync(productEntity);
        }

        public async Task Update(ClienteDTO productDto)
        {

            var productEntity = _mapper.Map<Cliente>(productDto);
            await _clienteRepository.UpdateAsync(productEntity);
        }

        public async Task Delete(int? id)
        {
            var productEntity = _clienteRepository.GetByIdAsync(id).Result;
            await _clienteRepository.RemoveAsync(productEntity);
        }      
    }
}
