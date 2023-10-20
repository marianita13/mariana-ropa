using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class PaisRepository : GenericRepository<Pais>, IPais
    {
        private readonly MarianaropaContext _context;
        public PaisRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}