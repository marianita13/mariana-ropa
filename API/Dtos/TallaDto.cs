using Core.Entities;

namespace API.Dtos
{
    public class TallaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
        public ICollection<InventarioTalla> InventarioTallas { get; set; }
    }
}