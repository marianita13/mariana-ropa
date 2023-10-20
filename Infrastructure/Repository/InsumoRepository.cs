using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InsumoRepository : GenericRepository<Insumo>, IInsumo
    {
        private readonly MarianaropaContext _context;
        public InsumoRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}