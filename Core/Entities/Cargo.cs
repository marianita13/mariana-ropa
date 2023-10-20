
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cargo : BaseEntity
    {
        public string Descripcion { get; set; }
        public int SueldoBase { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
