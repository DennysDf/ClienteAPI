using ClienteAPI.Application.DTOs;
using ClienteAPI.Application.Services.Interfaces;
using ClienteAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClienteAPI.Controllers;

[ApiController]
[Route("[controller]")]    
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [Authorize]
    [HttpGet("Obter")]
    public async Task<ActionResult<IEnumerable<ClienteDTO>>> GetCliente()
    {
        var clientes = await _clienteService.GetClientes();
        return Ok(clientes);
    }

    [Authorize]
    [HttpGet( "Obter/{id}")]
    public async Task<ActionResult<ClienteDTO>> Get(int id)
    {
        var cliente = await _clienteService.GetById(id);

        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }

    [Authorize]
    [HttpPost("Cadastrar")]
    public async Task<ActionResult> Post([FromBody] ClienteDTO clienteDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _clienteService.Add(clienteDTO);

        return Ok(clienteDTO);
    }

    [Authorize]
    [HttpPut("Atualizar/{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] ClienteDTO clienteDTO)
    {
        if (id != clienteDTO.Id)
        {
            return BadRequest();
        }

        await _clienteService.Update(clienteDTO);

        return Ok(clienteDTO);
    }

    [Authorize]
    [HttpDelete("Deletar/{id}")]
    public async Task<ActionResult<ClienteDTO>> Delete(int id)
    {
        var produtoDto = await _clienteService.GetById(id);
        if (produtoDto == null)
        {
            return NotFound();
        }
        await _clienteService.Delete(id);
        return Ok(produtoDto);
    }
}