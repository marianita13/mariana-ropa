using Core.Entities;

namespace API.Dtos
{
    public class PaisDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
