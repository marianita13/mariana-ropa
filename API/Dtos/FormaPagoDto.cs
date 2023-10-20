using Core.Entities;

namespace API.Dtos
{
    public class FormaPagoDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}