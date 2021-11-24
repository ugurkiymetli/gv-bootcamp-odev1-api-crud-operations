using FluentValidation;
namespace ContactsAppWebAPI.ContactsOperations.UpdateContact
{
    public class UpdateContactCommandValidator : AbstractValidator<UpdateContactCommand>
    {
        public UpdateContactCommandValidator()
        {
            RuleFor(command => command.id).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(3);
            RuleFor(command => command.Model.Surname).NotEmpty().MinimumLength(3);
            //using regex for phone number validation
            RuleFor(command => command.Model.PhoneNumber).NotEmpty().Matches(@"^([0-9]{10})$");
            //using regex for profile picture url validation - WIP
            //RuleFor(command => command.Model.PhoneNumber).NotEmpty().Matches();

        }
    }
}
