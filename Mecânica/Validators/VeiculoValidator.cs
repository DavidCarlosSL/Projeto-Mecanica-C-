using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Mecânica.Validators
{
    public class VeiculoValidator : AbstractValidator<ModeloVeiculo>
    {
        public VeiculoValidator()
        {
            RuleFor(v => v._placaVeiculo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("A Placa deve ser informada")
                .NotNull().WithMessage("A Placa deve ser informada")
                .MaximumLength(7).WithMessage("A Placa deve possuir 7 caracteres")
                .MinimumLength(7).WithMessage("A Placa deve possuir 7 caracteres");

            RuleFor(v => v._idMarca)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("O Marca deve ser fornecida")
                .NotEmpty().WithMessage("O Marca deve ser fornecida");

            RuleFor(v => v._modeloVeiculo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("O Modelo deve ser fornecido")
                .NotEmpty().WithMessage("O Modelo deve ser fornecido")
                .MaximumLength(35).WithMessage("O Modelo deve possuir no máximo 35 caracteres");

            RuleFor(v => v._motorVeiculo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(15).WithMessage("O Motor deve possuir no máximo 15 caracteres");

            RuleFor(v => v._corVeiculo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(15).WithMessage("A Cor deve possuir no máximo 15 caracteres");

            RuleFor(v => v._observacaoVeiculo)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(255).WithMessage("A Observação deve possuir no máximo 15 caracteres");
        }
    }
}
