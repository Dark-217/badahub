using BadaHub.API.Domain.Core.Commands;
using BadaHub.API.Domain.Interfaces;

namespace BadaHub.API.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context.Context _context;

        public UnitOfWork(Context.Context context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}