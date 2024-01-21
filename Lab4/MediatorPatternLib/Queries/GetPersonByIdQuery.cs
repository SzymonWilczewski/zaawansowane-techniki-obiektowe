using MediatorPatternLib.Models;
using MediatR;

namespace MediatorPatternLib.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
}
