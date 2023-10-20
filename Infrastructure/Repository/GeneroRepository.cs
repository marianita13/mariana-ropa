using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class GeneroRepository : GenericRepository<Genero>, IGenero
    {
        private readonly MarianaropaContext _context;
        public GeneroRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}