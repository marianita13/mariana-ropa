using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPago
    {
        private readonly MarianaropaContext _context;
        public FormaPagoRepository(MarianaropaContext context) : base(context)
        {
            _context = context;
        }
    }
}