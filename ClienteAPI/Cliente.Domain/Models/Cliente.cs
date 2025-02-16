using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Domain.Models;

public class Cliente : ModelBase
{
    public string? Nome { get; set; }
    public string? NomeMae { get; set; }
    public DateOnly DataNascimento { get; set; }
    public string? Endereco { get; set; }
    public string? Sexo { get; set; }
    public string? EstadoCivil { get; set; }
}
