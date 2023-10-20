using Core.Entities;

namespace API.Dtos
{
    public class TipoPersonaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; }
    }
}