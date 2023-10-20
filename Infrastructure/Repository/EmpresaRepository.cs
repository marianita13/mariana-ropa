using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class EmpresaRepository : GenericRepository<Empresa>, IEmpresa
    {
        private readonly MarianaropaContext _context;
        public EmpresaRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}