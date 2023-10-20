using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TipoEstadoRepository : GenericRepository<TipoEstado>, ITipoEstado
    {
        private readonly MarianaropaContext _context;
        public TipoEstadoRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}