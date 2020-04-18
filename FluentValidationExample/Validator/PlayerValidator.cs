using FluentValidation;
using FluentValidationExample.Models;

namespace FluentValidationExample.Validator
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            //RuleSet("test", () =>
            //{
            //    RuleFor(x => x.Name).NotNull().Length(1, 10).WithMessage("name could not be null");
            //    RuleFor(x => x.IsOutOfStaff).NotEqual(true).WithMessage("This player out of staff");
            //});            
            RuleFor(x => x.Name).NotNull().Length(1, 10).WithMessage("name could not be null");
            RuleFor(x => x.TeamName).MinimumLength(3).MaximumLength(50).WithMessage("Team name character length is invalid");
            RuleFor(x => x.IsOutOfStaff).NotEqual(true).WithMessage("This player out of staff");
        }
    }
}
