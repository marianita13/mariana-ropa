using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersona
    {
        private readonly MarianaropaContext _context;
        public TipoPersonaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}