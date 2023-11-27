CREATE PROCEDURE InsertarCompraID
    @FechaCompra VARCHAR(10),
    @ProveedorID INT,
	@EmpleadoID INT,
    @UltimoID INT OUTPUT
AS
BEGIN
    INSERT INTO Compras (FechaCompra, ProveedorID, EmpleadoID)
    VALUES (@FechaCompra, @ProveedorID, @EmpleadoID);
    SET @UltimoID = SCOPE_IDENTITY();
END;
CREATE PROCEDURE ObtenerCompras
AS
BEGIN
    SELECT CompraID, FechaCompra, ProveedorID, EmpleadoID
    FROM Compras;
END;
CREATE PROCEDURE ActualizarCompra
    @CompraID INT,
    @FechaCompra VARCHAR(10),
    @ProveedorID INT,
	@EmpleadoID INT
AS
BEGIN
    UPDATE Compras
    SET 
        FechaCompra = @FechaCompra,
        ProveedorID = @ProveedorID,
        EmpleadoID = @EmpleadoID
    WHERE CompraID = @CompraID;
END;
CREATE PROCEDURE EliminarCompra
    @CompraID INT
AS
BEGIN
    DELETE FROM Compras
    WHERE CompraID = @CompraID;
END;
EXEC InsertarCompra 
    @FechaCompra = '2023-11-15',
    @ProveedorID = 100, -- Ajustar según el proveedor deseado
	@EmpleadoID = 1204; -- Ajustar según el empleado deseado

EXEC ObtenerCompras;

EXEC ActualizarCompra 
    @CompraID = 301, -- Ajustar según la compra deseada
    @FechaCompra = '2023-11-16',
    @ProveedorID = 100, -- Ajustar según el nuevo proveedor
	@EmpleadoID = 1204; -- Ajustar según el nuevo empleado
	EXEC EliminarCompra @CompraID = 301; -- Ajustar según la compra deseada
