CREATE PROCEDURE InsertarProveedor
    @Nombre NVARCHAR(50),
    @Telefono VARCHAR(10),
    @Direccion NVARCHAR(100),
    @RFC CHAR(13)
AS
BEGIN
    INSERT INTO Proveedor (Nombre, Telefono, Direccion, RFC)
    VALUES (@Nombre, @Telefono, @Direccion, @RFC);
END;
CREATE PROCEDURE ObtenerProveedores
AS
BEGIN
    SELECT IdProveedor, Nombre, Telefono, Direccion, RFC
    FROM Proveedor;
END;
CREATE PROCEDURE ActualizarProveedor
    @IdProveedor INT,
    @Nombre NVARCHAR(50),
    @Telefono VARCHAR(10),
    @Direccion NVARCHAR(100),
    @RFC CHAR(13)
AS
BEGIN
    UPDATE Proveedor
    SET 
        Nombre = @Nombre,
        Telefono = @Telefono,
        Direccion = @Direccion,
        RFC = @RFC
    WHERE IdProveedor = @IdProveedor;
END;
CREATE PROCEDURE EliminarProveedor
    @IdProveedor INT
AS
BEGIN
    DELETE FROM Proveedor
    WHERE IdProveedor = @IdProveedor;
END;
EXEC InsertarProveedor 
    @Nombre = 'Proveedor A',
    @Telefono = '1234567890',
    @Direccion = 'Calle Principal 123',
    @RFC = 'ABC123456789';

EXEC ObtenerProveedores;

	EXEC ActualizarProveedor 
    @IdProveedor = 101, -- Ajustar según el proveedor deseado
    @Nombre = 'Proveedor B',
    @Telefono = '9876543210',
    @Direccion = 'Nueva Calle 456',
    @RFC = 'XYZ987654321';
	EXEC EliminarProveedor @IdProveedor = 101; -- Ajustar según el proveedor deseado
