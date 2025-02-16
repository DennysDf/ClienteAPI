using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPI.Application.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? NomeMae { get; set; }

        [Required]        
        public int Idade { get; set; }

        [Required]
        public string? Endereco { get; set; }
        public string? Sexo { get; set; }
        public string? EstadoCivil { get; set; }
    }
}
