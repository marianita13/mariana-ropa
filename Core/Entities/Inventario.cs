
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventario : BaseEntity
    {
        /*UNICA*/
        public int CodInv { get; set; }
        public double ValorVtaCop { get; set; }
        public double ValorVtaUsd { get; set; }

        public Prenda Prenda { get; set; }
        public int IdPrendaFk { get; set; }

        public ICollection<InventarioTalla> InventarioTallas { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
}
