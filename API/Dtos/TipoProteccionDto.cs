using Core.Entities;

namespace API.Dtos
{
    public class TipoProteccionDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
    }
}