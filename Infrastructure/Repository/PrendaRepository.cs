using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class PrendaRepository : GenericRepository<Prenda>, IPrenda
    {
        private readonly MarianaropaContext _context;
        public PrendaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}