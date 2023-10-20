using Core.Entities;

namespace API.Dtos
{
    public class MunicipioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamentoFk { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; }
    }
}