using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using System.Threading.Tasks;

namespace Mecânica.Validators
{
    class MecanicoValidator: AbstractValidator<ModeloMecanico>
    {
        public MecanicoValidator()
        {
            RuleFor(m => m._cpfMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("O CPF deve ser informado")
                .NotNull().WithMessage("O CPF deve ser informado")
                .MinimumLength(11).WithMessage("O CPF deve possuir 11 digitos")
                .MaximumLength(11).WithMessage("O CPF deve possuir 11 digitos");

            RuleFor(m => m._nomeMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("O Nome deve ser informado")
                .NotNull().WithMessage("O Nome deve ser informado")
                .MinimumLength(2).WithMessage("O Nome deve possuir no minimo 2 caracteres")
                .MaximumLength(60).WithMessage("O Nome deve possuir no máximo 60 caracteres")
                .Must(serNomeValido).WithMessage("Nome inválido");

            RuleFor(m => m._foneMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("O Telefone deve ser informado")
                .NotNull().WithMessage("O Telefone deve ser informado")
                .MaximumLength(11).WithMessage("O Telefone deve possuir no máximo 11 digitos");

            RuleFor(m => m._cepMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(8).WithMessage("O CEP deve possuir no máximo 8 digitos");

            RuleFor(m => m._enderecoMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(100).WithMessage("O Endereço deve possuir no máximo 100 caracteres");

            RuleFor(m => m._bairroMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(40).WithMessage("O Bairro deve possuir no máximo 40 caracteres");

            RuleFor(m => m._cidadeMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(40).WithMessage("A Cidade deve possuir no máximo 40 caracteres");

            RuleFor(m => m._salarioMecanico)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("O Salário deve ser informado");
        }

        protected bool serNomeValido(string nomeMecanico)
        {
            nomeMecanico = nomeMecanico.Replace(" ", "");
            return nomeMecanico.All(Char.IsLetter);
        }
    }
}
