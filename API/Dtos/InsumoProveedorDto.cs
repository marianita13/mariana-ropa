using Core.Entities;

namespace API.Dtos
{
    public class InsumoProveedorDto
    {
        public int Id { get; set; }
        public int IdInsumoFk { get; set; }
        public int IdProveedorFk { get; set; }
    }
}