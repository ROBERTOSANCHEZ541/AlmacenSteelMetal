CREATE PROCEDURE InsertarDetallePedido
    @PedidoID INT,
    @ProductoID INT,
	@IDTransporte INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO DetallesPedido (PedidoID, ProductoID, IDTransporte, Cantidad, PrecioUnitario)
    VALUES (@PedidoID, @ProductoID, @IDTransporte, @Cantidad, @PrecioUnitario);
END;
CREATE PROCEDURE ObtenerDetallesPedido
AS
BEGIN
    SELECT DetalleID, PedidoID, ProductoID, IDTransporte, Cantidad, PrecioUnitario
    FROM DetallesPedido;
END;
CREATE PROCEDURE ActualizarDetallePedido
    @DetalleID INT,
    @PedidoID INT,
    @ProductoID INT,
	@IDTransporte INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2)
AS
BEGIN
    UPDATE DetallesPedido
    SET 
        PedidoID = @PedidoID,
        ProductoID = @ProductoID,
		IDTransporte = @IDTransporte,
        Cantidad = @Cantidad,
        PrecioUnitario = @PrecioUnitario
    WHERE DetalleID = @DetalleID;
END;
CREATE PROCEDURE EliminarDetallePedido
    @DetalleID INT
AS
BEGIN
    DELETE FROM DetallesPedido
    WHERE DetalleID = @DetalleID;
END;
EXEC InsertarDetallePedido 
    @PedidoID = 201,
    @ProductoID = 703,
	@IDTransporte = 601,
    @Cantidad = 10,
    @PrecioUnitario = 29.99;

	EXEC ObtenerDetallesPedido;

	EXEC ActualizarDetallePedido 
    @DetalleID = 1,
    @PedidoID = 2,
    @ProductoID = 2,
	@IDTransporte = 2,
    @Cantidad = 15,
    @PrecioUnitario = 39.99;

	EXEC EliminarDetallePedido @DetalleID = 404;

