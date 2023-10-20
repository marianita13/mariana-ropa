using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InsumoProveedorRepository : GenericRepository<InsumoProveedor>, IInsumoProveedor
    {
        private readonly MarianaropaContext _context;
        public InsumoProveedorRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}
