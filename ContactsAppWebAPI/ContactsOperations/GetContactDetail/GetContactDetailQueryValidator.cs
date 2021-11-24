using FluentValidation;
namespace ContactsAppWebAPI.ContactsOperations.GetContactDetail
{
    public class GetContactDetailQueryValidator : AbstractValidator<GetContactDetailQuery>
    {
        public GetContactDetailQueryValidator()
        {
            RuleFor(command => command.id).GreaterThan(0);
        }
    }
}
