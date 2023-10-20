
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empresa : BaseEntity
    {
        /*UNICA*/
        public int Nit { get; set; }
        public string RazonSocial { get; set; }
        public string RepresentanteLegal { get; set; }
        public DateOnly FechaCreacion { get; set; }

        public Municipio Municipio { get; set; }
        public int IdMunicipioFk { get; set; }
    }
}
