using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class VentaRepository : GenericRepository<Venta>, IVenta
    {
        private readonly MarianaropaContext _context;
        public VentaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}