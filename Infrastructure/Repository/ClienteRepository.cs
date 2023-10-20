using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>, ICliente
    {
        private readonly MarianaropaContext _context;
        public ClienteRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}