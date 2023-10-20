using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnityOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly MarianaropaContext _context;
    private CargoRepository _cargos;
    private ClienteRepository _clientes;
    private ColorRepository _colores;
    private DepartamentoRepository _departamentos;
    private DetalleOrdenRepository _detalleOrdenes;
    private DetalleVentaRepository _detalleVentas;
    private EmpleadoRepository _empleados;
    private EmpresaRepository _empresas;
    private EstadoRepository _estados;
    private FormaPagoRepository _formaPagos;
    private GeneroRepository _generos;
    private InsumoRepository _insumos;
    private InsumoPrendaRepository _insumosPrendas;
    private InsumoProveedorRepository _insumosProveedores;
    private InventarioRepository _Inventarios;
    private InventarioTallaRepository _InventariosTalla;
    private MunicipioRepository _municipios;
    private OrdenRepository _Ordens;
    private PaisRepository _Paiss;
    private PrendaRepository _Prendas;
    private ProveedorRepository _Proveedors;
    private TallaRepository _Tallas;
    private TipoEstadoRepository _TipoEstados;
    private TipoPersonaRepository _TipoPersonas;
    private TipoProteccionRepository _TipoProteccions;
    private VentaRepository _Ventas;

    public ICargo Cargos
    {
        get
        {
            if (_cargos == null)
            {
                _cargos = new CargoRepository(_context);
            }
            return _cargos;
        }
    }
    public ICliente cliente
    {
        get
        {
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(_context);
            }
            return _clientes;
        }
    }
    public IColor color
    {
        get
        {
            if (_colores == null)
            {
                _colores = new ColorRepository(_context);
            }
            return _colores;
        }
    }
    public IDepartamento departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }
    public IDetalleVenta detalleVentas
    {
        get
        {
            if (_detalleVentas == null)
            {
                _detalleVentas = new DetalleVentaRepository(_context);
            }
            return _detalleVentas;
        }
    }
    public IDetalleOrden orden
    {
        get
        {
            if (_detalleOrdenes == null)
            {
                _detalleOrdenes = new DetalleOrdenRepository(_context);
            }
            return _detalleOrdenes;
        }
    }
    public IEmpleado empleado
    {
        get
        {
            if (_empleados == null)
            {
                _empleados = new EmpleadoRepository(_context);
            }
            return _empleados;
        }
    }
    public IEmpresa empresa
    {
        get
        {
            if (_empresas == null)
            {
                _empresas = new EmpresaRepository(_context);
            }
            return _empresas;
        }
    }
    public IEstado estado
    {
        get
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }
    public IFormaPago formaPago
    {
        get
        {
            if (_formaPagos == null)
            {
                _formaPagos = new FormaPagoRepository(_context);
            }
            return _formaPagos;
        }
    }
    public IGenero genero
    {
        get
        {
            if (_generos == null)
            {
                _generos = new GeneroRepository(_context);
            }
            return _generos;
        }
    }
    public IInsumo insumo
    {
        get
        {
            if (_insumos == null)
            {
                _insumos = new InsumoRepository(_context);
            }
            return _insumos;
        }
    }
    public IInsumoPrenda insumoPrenda
    {
        get
        {
            if (_insumosPrendas == null)
            {
                _insumosPrendas = new InsumoPrendaRepository(_context);
            }
            return _insumosPrendas;
        }
    }
    public IInsumoProveedor insumoProveedor
    {
        get
        {
            if (_insumosProveedores == null)
            {
                _insumosProveedores = new InsumoProveedorRepository(_context);
            }
            return _insumosProveedores;
        }
    }
    public IInventario inventario
    {
        get
        {
            if (_Inventarios == null)
            {
                _Inventarios = new InventarioRepository(_context);
            }
            return _Inventarios;
        }
    }
    public IInventarioTalla inventarioTalla
    {
        get
        {
            if (_InventariosTalla == null)
            {
                _InventariosTalla = new InventarioTallaRepository(_context);
            }
            return _InventariosTalla;
        }
    }
    public IMunicipio municipio
    {
        get
        {
            if (_municipios == null)
            {
                _municipios = new MunicipioRepository(_context);
            }
            return _municipios;
        }
    }
    public IOrden ordenes
    {
        get
        {
            if (_Ordens == null)
            {
                _Ordens = new OrdenRepository(_context);
            }
            return _Ordens;
        }
    }
    public IPais pais
    {
        get
        {
            if (_Paiss == null)
            {
                _Paiss = new PaisRepository(_context);
            }
            return _Paiss;
        }
    }
    public IPrenda prenda
    {
        get
        {
            if (_Prendas == null)
            {
                _Prendas = new PrendaRepository(_context);
            }
            return _Prendas;
        }
    }
    public IProveedor proveedor
    {
        get
        {
            if (_Proveedors == null)
            {
                _Proveedors = new ProveedorRepository(_context);
            }
            return _Proveedors;
        }
    }
    public ITalla talla
    {
        get
        {
            if (_Tallas == null)
            {
                _Tallas = new TallaRepository(_context);
            }
            return _Tallas;
        }
    }
    public ITipoEstado tipoEstado
    {
        get
        {
            if (_TipoEstados == null)
            {
                _TipoEstados = new TipoEstadoRepository(_context);
            }
            return _TipoEstados;
        }
    }
    public ITipoPersona tipoPersona
    {
        get
        {
            if (_TipoPersonas == null)
            {
                _TipoPersonas = new TipoPersonaRepository(_context);
            }
            return _TipoPersonas;
        }
    }
    public ITipoProteccion tipoProteccion
    {
        get
        {
            if (_TipoProteccions == null)
            {
                _TipoProteccions = new TipoProteccionRepository(_context);
            }
            return _TipoProteccions;
        }
    }

    public IVenta venta
    {
        get
        {
            if (_Ventas == null)
            {
                _Ventas = new VentaRepository(_context);
            }
            return _Ventas;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
