using Core.Entities;

namespace API.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaRegistro { get; set; }

        public int IdTipoPersonaFk { get; set; }
        public int IdMunicipioFk { get; set; }
        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}