using Core.Entities;

namespace API.Dtos
{
    public class ProveedorDto
    {
        public int Id { get; set; }
        public int NitProveedor { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public int IdMunicipioFk { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
    }
}