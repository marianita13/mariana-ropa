using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces;

public interface IUnitOfWork
{    
    ICargo Cargos { get; }
    ICliente Clientes { get; }
    IColor Colores { get; }
    IDepartamento DeparIDepartamentos { get; }
    IDetalleOrden DetalleOrdenes { get; }
    IDetalleVenta DetalleVentas { get; }
    IEmpleado Empleados { get; }
    IEmpresa Empresas { get; }
    IEstado Estados { get; }
    IFormaPago FormaPagos { get; }
    IGenero GenIGeneros { get; }
    IInsumo Insumos { get; }
    IInventario InIInventarios { get; }
    IMunicipio MIMunicipios { get; }
    IOrden Ordenes { get; }
    IPais Paises { get; }
    IPrenda Prendas { get; }
    IProveedor Proveedores { get; }
    ITalla Tallas { get; }
    ITipoEstado TipoEstados { get; }
    ITipoPersona TipoPersonas { get; }
    ITipoProteccion TipoProteccions { get; }
    IVenta Ventas { get; }
    
    Task<int> SaveAsync();
}
