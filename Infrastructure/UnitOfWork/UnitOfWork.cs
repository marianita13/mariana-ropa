using System;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;


namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly MarianaropaContext _context;
    private ICargo _cargo;
    private ICliente _cliente;
    private IColor _color;
    private IDepartamento _departamento;
    private IDetalleOrden _detalleOrden;
    private IDetalleVenta _detalleVenta;
    private IEmpleado _empleado;
    private IEmpresa _empresa;
    private IEstado _estado;
    private IFormaPago _formaPago;
    private IGenero _genero;
    private IInsumo _insumo;
    private IInventario _inventario;
    private IMunicipio _municipio;
    private IOrden _orden;
    private IPais _pais;
    private IPrenda _prenda;
    private IProveedor _proveedor;
    private ITalla _talla;
    private ITipoEstado _tipoEstado;
    private ITipoPersona _tipoPersona;
    private ITipoProteccion _tipoProteccion;
    private IVenta _venta;

    public UnitOfWork(MarianaropaContext context)
    {
        _context = context;
    }

    public ICargo Cargos {
        get {
            if (_cargo == null) {
                _cargo = new CargoRepository(_context);
            }
            return _cargo;
        }
    }

    public ICliente Clientes {
        get {
            if (_cliente == null) {
                _cliente = new ClienteRepository(_context);
            }
            return _cliente;
        }
    }

    public IColor Colores {
        get {
            if (_color == null) {
                _color = new ColorRepository(_context);
            }
            return _color;
        }
    }

    public IDetalleOrden DetalleOrdenes {
        get {
            if (_detalleOrden == null) {
                _detalleOrden = new DetalleOrdenRepository(_context);
            }
            return _detalleOrden;
        }
    }

    public IDetalleVenta DetalleVentas {
        get {
            if (_detalleVenta == null) {
                _detalleVenta = new DetalleVentaRepository(_context);
            }
            return _detalleVenta;
        }
    }

    public IEmpleado Empleados {
        get {
            if (_empleado == null) {
                _empleado = new EmpleadoRepository(_context);
            }
            return _empleado;
        }
    }

    public IEmpresa Empresas {
        get {
            if (_empresa == null) {
                _empresa = new EmpresaRepository(_context);
            }
            return _empresa;
        }
    }

    public IEstado Estados {
        get {
            if (_estado == null) {
                _estado = new EstadoRepository(_context);
            }
            return _estado;
        }
    }
    public IOrden Ordenes {
        get {
            if (_orden == null) {
                _orden = new OrdenRepository(_context);
            }
            return _orden;
        }
    }
    public IInsumo Insumos {
        get {
            if (_insumo == null) {
                _insumo = new InsumoRepository(_context);
            }
            return _insumo;
        }
    }

    public IPais Paises {
        get {
            if (_pais == null) {
                _pais = new PaisRepository(_context);
            }
            return _pais;
        }
    }

    public IPrenda Prendas {
        get {
            if (_prenda == null) {
                _prenda = new PrendaRepository(_context);
            }
            return _prenda;
        }
    }

    public IProveedor Proveedores {
        get {
            if (_proveedor == null) {
                _proveedor = new ProveedorRepository(_context);
            }
            return _proveedor;
        }
    }

    public ITalla Tallas {
        get {
            if (_talla == null) {
                _talla = new TallaRepository(_context);
            }
            return _talla;
        }
    }
    public IVenta Ventas {
        get {
            if (_venta == null) {
                _venta = new VentaRepository(_context);
            }
            return _venta;
    }
    }

    public IDepartamento DeparIDepartamentos{
        get {
            if (_departamento == null) {
                _departamento = new DepartamentoRepository(_context);
            }
            return _departamento;
        }
    }

    public IFormaPago FormaPagos{
        get {
            if (_formaPago == null) {
                _formaPago = new FormaPagoRepository(_context);
            }
            return _formaPago;
        }
    }

    public IGenero GenIGeneros{
        get {
            if (_genero == null) {
                _genero = new GeneroRepository(_context);
            }
            return _genero;
        }
    }

    public IInventario InIInventarios{
        get {
            if (_inventario == null) {
                _inventario = new InventarioRepository(_context);
            }
            return _inventario;
        }
    }

    public IMunicipio MIMunicipios {
        get {
            if (_municipio == null) {
                _municipio = new MunicipioRepository(_context);
            }
            return _municipio;
        }
    }

    public ITipoEstado TipoEstados {
        get {
            if (_tipoEstado == null) {
                _tipoEstado = new TipoEstadoRepository(_context);
            }
            return _tipoEstado;
        }
    }

    public ITipoPersona TipoPersonas {
        get {
            if (_tipoPersona == null) {
                _tipoPersona = new TipoPersonaRepository(_context);
            }
            return _tipoPersona;
        }
    }

    public ITipoProteccion TipoProteccions{
        get {
            if (_tipoProteccion == null) {
                _tipoProteccion = new TipoProteccionRepository(_context);
            }
            return _tipoProteccion;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
