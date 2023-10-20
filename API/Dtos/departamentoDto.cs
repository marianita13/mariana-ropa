using Core.Entities;

namespace API.Dtos
{
    public class DepartamentoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPaisFk { get; set; }
        public ICollection<Municipio> Municipios { get; set; }
    }
}