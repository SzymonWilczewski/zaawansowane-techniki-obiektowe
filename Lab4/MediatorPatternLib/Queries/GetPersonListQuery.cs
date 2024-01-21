using System.Collections.Generic;
using MediatorPatternLib.Models;
using MediatR;

namespace MediatorPatternLib.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}
