using Core.Entities;
using FluentValidation;

namespace Services.Validators
{
    public class UserValidators : AbstractValidator<User>
    {
        //base -> ubicacion
        public UserValidators()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .MaximumLength(255)
                .WithMessage("El nombre es obligatorio y no debe exceder los 255 caracteres");

            RuleFor(x => x.Password)
                .NotEmpty()
                .MaximumLength(255)
                .WithMessage("La contraseña es obligatoria y no debe exceder los 255 caracteres");
        }
    }
}