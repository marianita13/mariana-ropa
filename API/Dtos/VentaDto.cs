using Core.Entities;

namespace API.Dtos
{
    public class VentaDto
    {
        public int Id { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public int IdEmpleadoFk { get; set; }
        public int IdClienteFk { get; set; }
        public int IdFormaPagoFk { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
}