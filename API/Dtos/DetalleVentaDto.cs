using Core.Entities;

namespace API.Dtos
{
    public class DetalleVentaDto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ValorUnit { get; set; }
        public int IdVentaFk { get; set; }
        public int IdProductoFk { get; set; }
        public int IdTallaFk { get; set; }
    }
}