using MediatorPatternLib.Models;
using MediatR;

namespace MediatorPatternLib.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
}
