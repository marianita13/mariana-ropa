using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
    {
        private readonly MarianaropaContext _context;
        public ProveedorRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}