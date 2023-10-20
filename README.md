# MARIANA-ROPA

# INSTRUCCIONES PARA EL BUEN FUNCIONAMIENTO

Lo primero que debes hacer luego de clonar el repo es en la consola poner el comando "dotnet restore", para eliminar los errores que apareceran.

## URL GENERAL DE LOS ENDPOINTS

http://localhost:5268

## FUNCIONALIDAD DE LOS DTOS

# CargoDto
`{
    "Descripcion" : "String",
    "SueldoBase" : Int
}`


# ClienteDto
`{
    "IdCliente" : Int,
    "Nombre" : "string",
    "FechaRegistros" : 0000/00/00,
    "IdTipoPersonaFk" : int,
    "IdMunicipioFk" : int
}`

# Color
`{
    "Descripcion" : "string"
}`

# Departamento
`{
    "Nombre" : "string",
    "IdPaisFk" : int
}`

# Detalle Venta
`{
    "Cantidad" : Int,
    "ValorUnit" : "int",
    "IdVentaFk" : "int",
    "IdProductoFk" : int,
    "IdTallaFk" : int
}`

# Detalle Orden
`{
    "IdOrdenFk" : Int,
    "IdPrendaFk" : "int",
    "IdColorFk" : "int",
    "IdEstadoFk" : int,
    "CantidadProducir" : int,
    "CantidadProducida" : int
}`

# Empleado
`{
    "IdEmp" : Int,
    "Nombre" : "string",
    "FechaIngreso" : 0000/00/00,
    "IdCargoFk" : int,
    "IdMunicipioFk" : int
}`

# Empresa
`{
    "Nit" : Int,
    "RazonSocial" : "string",
    "RepresentanteLegal" : "string",
    "FechaCreacion" : 0000/00/00,
    "IdMunicipioFk" : int
}`

# Estado
`{
    "Descripcion" : "string",
    "IdTipoEstadoFk" : int
}`

# FormaPago
`{
    "Descripcion" : "string"
}`

# Genero
`{
    "Descripcion" : "string"
}`

# Insumo
`{
    "Nombre" : Int,
    "ValorUnit" : int,
    "StockMin" : "int",
    "StockMax" : int
}`

# Inventario

`{
    "CodInv" : Int,
    "ValorVtaCop" : "int",
    "ValorVtaUsd" : "int",
    "IdPrendaFk" : int
}`

# Municipio
`{
    "Nombre" : "string",
    "IdDepartamentoFk" : "int"
}`

# Orden
`{
    "Fecha" : 0000/00/00,
    "IdEmpleadoFk" : "int",
    "IdClienteFk" : "int",
    "IdEstadoFk" : int
}`

# Pais
`{
    "Nombre" : "string"
}`

# Prenda
`{
    "IdPrenda" : Int,
    "Nombre" : "string",
    "ValorUnitCop" : int,
    "ValorUnitUsd" : int,
    "IdEstadoFk" : int,
    "IdTipoProteccionFk" : int,
    "IdGeneroFk" : int
}`

# Proveedor
`{
    "NitProveedor" : Int,
    "Nombre" : "string",
    "IdTipoPersonaFk" : int,
    "IdMunicipioFk" : int
}`

# Talla
`{
    "Descripcion" : "string"
}`

# TipoEstado
`{
    "Descripcion" : "string"
}`

# TipoPersona
`{
    "Nombre" : "string"
}`

# TipoProteccion
`{
    "Descripcion" : "string"
}`

# Venta
`{
    "FechaCreacion" : 0000/00/00,
    "IdEmpleadoFk" : int,
    "IdClienteFk" : int,
    "IdFormaPagoFk" : int
}`

