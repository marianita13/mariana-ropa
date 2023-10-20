using Core.Entities;

namespace API.Dtos
{
    public class ColorDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    }
}