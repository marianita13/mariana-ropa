using Core.Entities;

namespace API.Dtos
{
    public class InventarioTallaDto
    {
        public int Id { get; set; }
        public int IdInventarioFk { get; set; }
        public int IdTallaFk { get; set; }
        public int Cantidad { get; set; }
    }
}