using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CargoRepository : GenericRepository<Cargo>, ICargo
    {
        private readonly MarianaropaContext _context;
        public CargoRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}