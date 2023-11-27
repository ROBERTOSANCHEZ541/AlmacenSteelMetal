CREATE PROCEDURE InsertarSucursal
    @NombreSucursal NVARCHAR(100),
    @Direccion NVARCHAR(255),
    @Ciudad NVARCHAR(50),
    @CodigoPostal NVARCHAR(10),
    @Telefono NVARCHAR(15)
AS
BEGIN
    INSERT INTO Sucursales (NombreSucursal, Direccion, Ciudad, CodigoPostal, Telefono)
    VALUES (@NombreSucursal, @Direccion, @Ciudad, @CodigoPostal, @Telefono);
END;

CREATE PROCEDURE ObtenerSucursales
AS
BEGIN
    SELECT IDSucursal, NombreSucursal, Direccion, Ciudad, CodigoPostal, Telefono
    FROM Sucursales;
END;

CREATE PROCEDURE ActualizarSucursal
    @IDSucursal INT,
    @NombreSucursal NVARCHAR(100),
    @Direccion NVARCHAR(255),
    @Ciudad NVARCHAR(50),
    @CodigoPostal NVARCHAR(10),
    @Telefono NVARCHAR(15)
AS
BEGIN
    UPDATE Sucursales
    SET
        NombreSucursal = @NombreSucursal,
        Direccion = @Direccion,
        Ciudad = @Ciudad,
        CodigoPostal = @CodigoPostal,
        Telefono = @Telefono
    WHERE IDSucursal = @IDSucursal;
END;

CREATE PROCEDURE EliminarSucursal
    @IDSucursal INT
AS
BEGIN
    DELETE FROM Sucursales
    WHERE IDSucursal = @IDSucursal;
END;
EXEC InsertarSucursal 
    @NombreSucursal = 'Sucursal ABC',
    @Direccion = 'Calle Principal 123',
    @Ciudad = 'Frontera',
    @CodigoPostal = '12345',
    @Telefono = '123-456-7890';

	EXEC ObtenerSucursales;

	EXEC ActualizarSucursal 
    @IDSucursal = 1,
    @NombreSucursal = 'Sucursal B',
    @Direccion = 'Nueva Calle 456',
    @Ciudad = 'Ciudad B',
    @CodigoPostal = '54321',
    @Telefono = '987-654-3210';
	EXEC EliminarSucursal @IDSucursal = 200;
