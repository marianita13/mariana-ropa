using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
    {
        private readonly MarianaropaContext _context;
        public MunicipioRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}