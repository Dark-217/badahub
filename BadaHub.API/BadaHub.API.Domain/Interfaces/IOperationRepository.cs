using BadaHub.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BadaHub.API.Domain.Interfaces
{
    public interface IOperationRepository : IRepository<Operation>
    {
        Operation GetById(Guid id);
        IQueryable<Operation> GetAll(); 
    }
}
