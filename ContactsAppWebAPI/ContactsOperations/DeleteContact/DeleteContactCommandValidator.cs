using FluentValidation;
namespace ContactsAppWebAPI.ContactsOperations.DeleteContact
{
    public class DeleteContactCommandValidator : AbstractValidator<DeleteContactCommand>
    {
        public DeleteContactCommandValidator()
        {
            RuleFor(command => command.id).GreaterThan(0);

        }
    }
}
