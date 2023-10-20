using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TipoProteccionRepository : GenericRepository<TipoProteccion>, ITipoProteccion
    {
        private readonly MarianaropaContext _context;
        public TipoProteccionRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}