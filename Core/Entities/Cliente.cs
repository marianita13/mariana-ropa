
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        /*UNICA*/
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaRegistro { get; set; }

        public TipoPersona TipoPersona { get; set; }
        public int IdTipoPersonaFk { get; set; }

        public Municipio Municipio {get; set;}
        public int IdMunicipioFk { get; set; }

        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}
