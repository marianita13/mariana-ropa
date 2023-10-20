using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ColorRepository : GenericRepository<Color>, IColor
    {
        private readonly MarianaropaContext _context;
        public ColorRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}