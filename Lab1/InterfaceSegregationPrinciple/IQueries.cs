using System;
using System.Collections.Generic;

namespace InterfaceSegregationPrinciple
{
    public interface IQueries
    {
        IEnumerable<Entity> GetAll();
        Entity GetByID(Guid identity);
        IEnumerable<Entity> FindByCriteria(string criteria);
    }
}
