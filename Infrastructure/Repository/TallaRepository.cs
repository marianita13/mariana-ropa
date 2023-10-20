using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TallaRepository : GenericRepository<Talla>, ITalla
    {
        private readonly MarianaropaContext _context;
        public TallaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}