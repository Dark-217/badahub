using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BadaHub.API.Domain.Interfaces;
using BadaHub.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BadaHub.API.Data.Repository
{
    public class OperationRepository : Repository<Operation>, IOperationRepository
    {
        public OperationRepository(Context.Context context)
            : base(context)
        {

        }

        public Operation GetById(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public IQueryable<Operation> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}