using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecânica.Validators
{
    public class ClienteValidator : AbstractValidator<ModeloCliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c._cpfCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("O CPF deve ser informado")
                .NotNull().WithMessage("O CPF deve ser informado")
                .MinimumLength(11).WithMessage("O CPF deve possuir 11 digitos")
                .MaximumLength(11).WithMessage("O CPF deve possuir 11 digitos");

            RuleFor(c => c._nomeCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("O Nome deve ser informado")
                .NotNull().WithMessage("O Nome deve ser informado")
                .MinimumLength(2).WithMessage("O Nome deve possuir no minimo 2 caracteres")
                .MaximumLength(60).WithMessage("O Nome deve possuir no máximo 60 caracteres")
                .Must(serNomeValido).WithMessage("Nome inválido");

            RuleFor(c => c._fone1Cliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(11).WithMessage("O Telefone1 deve possuir no máximo 11 digitos");

            RuleFor(c => c._fone2Cliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(11).WithMessage("O Telefone2 deve possuir no máximo 11 digitos");

            RuleFor(c => c._emailCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(60).WithMessage("O Email deve possuir no máximo 60 caracteres");

            RuleFor(c => c._cepCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(8).WithMessage("O CEP deve possuir no máximo 8 digitos");

            RuleFor(c => c._enderecoCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(100).WithMessage("O Endereço deve possuir no máximo 100 caracteres");

            RuleFor(c => c._bairroCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(40).WithMessage("O Bairro deve possuir no máximo 40 caracteres");

            RuleFor(c => c._cidadeCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(40).WithMessage("A Cidade deve possuir no máximo 40 caracteres");

            RuleFor(c => c._estadoCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(25).WithMessage("O Estado deve possuir no máximo 25 caracteres");

            RuleFor(c => c._observacaoCliente)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(255).WithMessage("A Observação deve possuir no máximo 255 caracteres");
        }

        protected bool serNomeValido(string nomeCliente)
        {
            nomeCliente = nomeCliente.Replace(" ", "");
            return nomeCliente.All(Char.IsLetter);
        }
    }
}
