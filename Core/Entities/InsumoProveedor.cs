
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoProveedor : BaseEntity
    {
        /*PRIMARY KEY*/
        public Insumo Insumo { get; set; }
        public int IdInsumoFk { get; set; }

        /*PRIMARY KEY*/
        public Proveedor Proveedor { get; set; }
        public int IdProveedorFk { get; set; }
    }
}
