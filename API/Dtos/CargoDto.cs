using Core.Entities;

namespace API.Dtos
{
    public class CargoDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int SueldoBase { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}