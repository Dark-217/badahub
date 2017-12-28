using BadaHub.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BadaHub.API.Domain.Interfaces
{
    public interface IOperationRepository : IRepository<Operation>
    {
        Operation GetById(Guid id);
        //should this be iqueryable?
        IEnumerable<Operation> GetAll(); 
    }
}
