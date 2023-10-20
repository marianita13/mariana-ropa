using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleado
    {
        private readonly MarianaropaContext _context;
        public EmpleadoRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}