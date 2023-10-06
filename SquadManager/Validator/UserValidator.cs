using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
	public class UserValidator : AbstractValidator<UserViewModel>
	{
		public UserValidator() 
		{
			RuleFor(user => user.Email).NotNull();
			RuleFor(user => user.Email).EmailAddress().WithMessage("Invalid Email");
			RuleFor(user => user.Password).NotNull();

		}
	}
}
