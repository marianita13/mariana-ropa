
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoPrenda : BaseEntity
    {
        public int Cantidad { get; set; }

        /*PRIMARY KEY*/
        public Insumo Insumo { get; set; }
        public int IdInsumoFk { get; set; }

        /*PRIMARY KEY*/
        public Prenda Prenda { get; set; }
        public int IdPrendaFk { get; set; }
    }
}
