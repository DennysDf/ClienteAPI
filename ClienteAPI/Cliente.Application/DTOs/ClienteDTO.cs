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

        [Required(ErrorMessage = "Informe o nome.")]
        [MinLength(10)]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe o nome da mãe.")]
        [MinLength(10)]
        [MaxLength(100)]
        public string? NomeMae { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento.")]
        [MinLength(10)]
        [MaxLength(10)]
        public DateOnly DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o endereço.")]
        [MinLength(5)]
        [MaxLength(100)]
        public string? Endereco { get; set; }
        public string? Sexo { get; set; }
        public string? EstadoCivil { get; set; }
    }
}
