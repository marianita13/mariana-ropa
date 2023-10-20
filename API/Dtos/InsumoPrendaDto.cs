using Core.Entities;

namespace API.Dtos
{
    public class InsumoPrendaDto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int IdInsumoFk { get; set; }
        public int IdPrendaFk { get; set; }
    }
}