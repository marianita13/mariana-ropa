using Core.Entities;

namespace API.Dtos
{
    public class PrendaDto
    {
        public int Id { get; set; }
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public double ValorUnitCop { get; set; }
        public double ValorUnitUsd { get; set; }
        public int IdEstadoFk { get; set; }
        public int IdTipoProteccionFk { get; set; }
        public int IdGeneroFk { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    }
}