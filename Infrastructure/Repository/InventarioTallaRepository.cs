using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InventarioTallaRepository : GenericRepository<InventarioTalla>, IInventarioTalla
    {
        private readonly MarianaropaContext _context;
        public InventarioTallaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}