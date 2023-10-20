using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class InsumoPrendaRepository : GenericRepository<InsumoPrenda>, IInsumoPrenda
    {
        private readonly MarianaropaContext _context;
        public InsumoPrendaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}