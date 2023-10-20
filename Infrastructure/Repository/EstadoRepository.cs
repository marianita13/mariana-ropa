using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class EstadoRepository : GenericRepository<Estado>, IEstado
    {
        private readonly MarianaropaContext _context;
        public EstadoRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}