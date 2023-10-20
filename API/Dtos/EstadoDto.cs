using Core.Entities;

namespace API.Dtos
{
    public class EstadoDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoEstadoFk { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}