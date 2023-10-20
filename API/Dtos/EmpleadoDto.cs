using Core.Entities;

namespace API.Dtos
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public int IdEmp { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public int IdCargoFk { get; set; }
        public int IdMunicipioFk { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}