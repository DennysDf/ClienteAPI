using ClienteAPI.Application.DTOs;
using FluentValidation;
using System.Globalization;

namespace Cliente.API.Validators;
public class CreateCustomerValidator : AbstractValidator<ClienteDTO>
{
    public CreateCustomerValidator()
    {
        RuleFor(c => c.Nome)
            .NotEmpty().WithMessage("Campo nome é obrigatório.");

        RuleFor(c => c.NomeMae)
            .NotEmpty().WithMessage("Campo nome da mãe é obrigatório.");

        RuleFor(c => c.Idade)
            .NotEmpty().WithMessage("Campo idade é obrigatório.");        

        RuleFor(c => c.Endereco)
            .NotEmpty().WithMessage("Campo endereço é obrigatório.");

        RuleFor(c => c.Sexo)
            .Length(1).WithMessage("M para masculino e F para Feminino.");
    }
}