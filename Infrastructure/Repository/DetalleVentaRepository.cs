using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DetalleVentaRepository : GenericRepository<DetalleVenta>, IDetalleVenta
    {
        private readonly MarianaropaContext _context;
        public DetalleVentaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}