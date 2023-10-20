using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InventarioRepository : GenericRepository<Inventario>, IInventario
    {
        private readonly MarianaropaContext _context;
        public InventarioRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}