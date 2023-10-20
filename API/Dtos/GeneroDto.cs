using Core.Entities;

namespace API.Dtos
{
    public class GeneroDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
    }
}