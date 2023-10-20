using Core.Entities;

namespace API.Dtos
{
    public class InsumoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double ValorUnit { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
    }
}