CREATE DATABASE Almacén;
GO
USE Almacén;
GO
CREATE TABLE Cliente (
    IdCliente int IDENTITY(500,1) PRIMARY KEY NOT NULL,
    Nombre NVARCHAR(50),
	Email NVARCHAR(255),
	Telefono varchar(10)
);
-- Insertar un registro en la tabla Categoria
--INSERT INTO Categoria(Tipo_Categoria)
--VALUES ('aluminio');

--select*from DetallesPedido

--delete Empleado

CREATE TABLE Categoria(
 id_Categoria int IDENTITY(20,1) primary key,
Tipo_Categoria nvarchar(15)
);
select*from DetallesPedido
CREATE TABLE Sucursales (
    IDSucursal INT IDENTITY(100,1) PRIMARY KEY,
    NombreSucursal NVARCHAR(100),
    Direccion NVARCHAR(255),
    Ciudad NVARCHAR(50),
    CodigoPostal NVARCHAR(10),
    Telefono NVARCHAR(15),
);
CREATE TABLE Productos (
    IdArticulo int IDENTITY(700,1) PRIMARY KEY NOT NULL,
    NombreProducto NVARCHAR(255),
    Precio DECIMAL(10, 2),
    Stock INT,
	Descripcion NVARCHAR(MAX),
	ID_Categoria int,
	IDSucursal INT
	FOREIGN KEY (ID_Categoria) REFERENCES Categoria(id_Categoria),
	FOREIGN KEY (IDSucursal) REFERENCES sucursales(IDSucursal)
);
CREATE TABLE Pedidos (
    PedidoID INT IDENTITY(200,1) PRIMARY KEY,
    FechaPedido varchar(10) not null,
    ClienteID INT,
    FOREIGN KEY (ClienteID) REFERENCES Cliente(IdCliente)
);
CREATE TABLE Transporte (
    IDTransporte INT IDENTITY(600,1)  PRIMARY KEY,
    Nombre NVARCHAR(100),
    Tipo NVARCHAR(50),
    CapacidadKg INT,
    NumeroPlaca NVARCHAR(20)
);
--faltan
	CREATE TABLE DetallesPedido (
		DetalleID INT IDENTITY(1,1)  PRIMARY KEY,
		PedidoID INT,
		ProductoID INT,
		IDTransporte INT,
		Cantidad INT,
		PrecioUnitario DECIMAL(10, 2),
		FOREIGN KEY (PedidoID) REFERENCES Pedidos(PedidoID),
		FOREIGN KEY (IDTransporte) REFERENCES transporte(IDTransporte),
		FOREIGN KEY (ProductoID) REFERENCES Productos(IdArticulo)
	);
CREATE TABLE Proveedor (
    IdProveedor int IDENTITY(1,1)  PRIMARY KEY NOT NULL,
    Nombre NVARCHAR(50),
    Telefono VARCHAR(10),
    Direccion NVARCHAR(100),
    RFC CHAR(13),
);

CREATE TABLE Empleado (
    IdEmpleado int IDENTITY(1200,1) PRIMARY KEY NOT NULL,
    Nombre NVARCHAR(50),
    Edad INT,
    RFC VARBINARY(1600)unique,
    Telefono VARCHAR(10)unique,
    CURP VARCHAR(18)unique,
    NSS CHAR(11)unique,
    Puesto NVARCHAR(100),
	IDSucursal INT
	FOREIGN KEY (IDSucursal) REFERENCES sucursales(IDSucursal)
);
CREATE TABLE Compras (
    CompraID INT IDENTITY(300,1) PRIMARY KEY,
    FechaCompra varchar(10),
    ProveedorID INT,
	EmpleadoID int,
    FOREIGN KEY (ProveedorID) REFERENCES Proveedor(IdProveedor),
	FOREIGN KEY (EmpleadoID) REFERENCES Empleado(IdEmpleado)
);
CREATE TABLE DetallesCompra (
    DetalleCompraID INT IDENTITY(400,1) PRIMARY KEY,
    CompraID INT,
    ProductoID INT,
	IDTransporte INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10, 2),
	 FOREIGN KEY (IDTransporte) REFERENCES transporte(IDTransporte),
    FOREIGN KEY (CompraID) REFERENCES Compras(CompraID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(IdArticulo)
);
--ALTER TABLE Compras
--add FechaCompra  varchar(10);

--ALTER TABLE productos ADD FOREIGN KEY (IDSucursal) REFERENCES Sucursales(IDSucursal);
--select*from Compras
----DROP COLUMN FechaCompra 

--ALTER TABLE detallescompra
--add IDTransporte  INT

--ALTER TABLE productos ADD FOREIGN KEY (IDSucursal) REFERENCES Sucursales(IDSucursal);

--DECLARE @Contraseña NVARCHAR(50)
--SET @Contraseña = 'R0bert541'

--DECLARE @RFCOriginal NVARCHAR(50)
--SET @RFCOriginal = 'SAAR821D'

--SELECT
--    IdEmpleado,
--    Nombre,
--    Edad,
--    CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE('R0bert541', RFC)) AS RFC_Desencriptado,
--    Telefono,
--    CURP,
--    NSS,
--    Puesto,
--    IDSucursal
--FROM Empleado
--WHERE Nombre = 'Juan Pérez';

--DECLARE @Contraseña NVARCHAR(50)
--SET @Contraseña = 'R0bert541'

--DECLARE @RFCOriginal NVARCHAR(50)
--SET @RFCOriginal = 'SAAR821D'

--DECLARE @RFCEncriptado VARBINARY(1600)
--SET @RFCEncriptado = ENCRYPTBYPASSPHRASE(@Contraseña, @RFCOriginal)

-- Ahora puedes insertar el valor encriptado en la columna RFC de tu tabla Empleado
--INSERT INTO Empleado (Nombre, Edad, RFC, Telefono, CURP, NSS, Puesto, IDSucursal)
--VALUES ('Juan Pérez', 30, @RFCEncriptado, '1234567890', 'CURP12345678901234', '12345678901', 'Gerente', 100);

--select*from Empleado
