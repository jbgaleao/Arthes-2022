using Arthes_2022.Models.ViewModels;

using FluentValidation;

namespace Arthes_2022.Models.Validators
{
    public class CadastraRevistaValidator : AbstractValidator<CadastraRevistaViewModel>
    {
        public CadastraRevistaValidator()
        {
            //  TEMA
            RuleFor(x => x.Tema).NotNull().WithMessage("Campo não deve ser nulo");
            RuleFor(x => x.Tema).NotEmpty().WithMessage("Campo não deve ser vazio");
            RuleFor(x => x.Tema).MaximumLength(30).WithMessage("Minimo devem ser 3 caracteres");
            RuleFor(x => x.Tema).MinimumLength(3).WithMessage("Máximo devem ser 30 caracteres");

            //  NUMERO DA EDIÇÃO
            RuleFor(x => x.NumeroEdicao).NotNull().WithMessage("Campo não deve ser nulo");
            RuleFor(x => x.NumeroEdicao).NotEmpty().WithMessage("Campo não deve ser vazio");
            RuleFor(x => x.NumeroEdicao).GreaterThan(0).WithMessage("Valor deve ser maior que zero");
            RuleFor(x => x.NumeroEdicao).LessThanOrEqualTo(500).WithMessage("Valor deve ser igual ou abaixo de 500");

            //  MES EDIÇÃO
            RuleFor(x => x.MesEdicao).NotNull().WithMessage("Campo não deve ser nulo");
            RuleFor(x => x.MesEdicao).NotEmpty().WithMessage("Campo não deve ser vazio");

            //  ANO DA EDIÇÃO
            RuleFor(x => x.AnoEdicao).NotNull().WithMessage("Campo não deve ser nulo");
            RuleFor(x => x.AnoEdicao).NotEmpty().WithMessage("Campo não deve ser vazio");
            RuleFor(x => x.AnoEdicao).ExclusiveBetween(1990, 2030).WithMessage("Valor deve ser maior que 1990");

            //  FOTO
            RuleFor(x => x.Foto).NotNull().WithMessage("Campo não deve ser nulo");
            RuleFor(x => x.Foto).NotEmpty().WithMessage("Campo não deve ser vazio");

        }
    }
}
