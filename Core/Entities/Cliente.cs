
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public DateOnly FechaRegistro { get; set; }
    }
}
