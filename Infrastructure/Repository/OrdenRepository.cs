using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class OrdenRepository : GenericRepository<Orden>, IOrden
    {
        private readonly MarianaropaContext _context;
        public OrdenRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}