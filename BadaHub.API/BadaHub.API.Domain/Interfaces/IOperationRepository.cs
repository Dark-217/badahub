using BadaHub.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BadaHub.API.Domain.Interfaces
{
    public interface IOperationRepository
    {
        Operation GetById(Guid id);
        Task<List<Operation>> GetStates(DateTime time); 
    }
}
