using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
    {
        private readonly MarianaropaContext _context;
        public DepartamentoRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}