using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrden
    {
        private readonly MarianaropaContext _context;
        public DetalleOrdenRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}