CREATE PROCEDURE InsertarDetalleCompra
    @CompraID INT,
    @ProductoID INT,
	@IDTransporte INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO DetallesCompra (CompraID, ProductoID, IDTransporte, Cantidad, PrecioUnitario)
    VALUES (@CompraID, @ProductoID, @IDTransporte, @Cantidad, @PrecioUnitario);
END;
CREATE PROCEDURE ObtenerDetallesCompra
AS
BEGIN
    SELECT DetalleCompraID, CompraID, ProductoID, IDTransporte, Cantidad, PrecioUnitario
    FROM DetallesCompra;
END;
CREATE PROCEDURE ActualizarDetalleCompra
    @DetalleCompraID INT,
    @CompraID INT,
    @ProductoID INT,
	@IDTransporte INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2)
AS
BEGIN
    UPDATE DetallesCompra
    SET 
        CompraID = @CompraID,
        ProductoID = @ProductoID,
		IDTransporte = @IDTransporte,
        Cantidad = @Cantidad,
        PrecioUnitario = @PrecioUnitario
    WHERE DetalleCompraID = @DetalleCompraID;
END;
CREATE PROCEDURE EliminarDetalleCompra
    @DetalleCompraID INT
AS
BEGIN
    DELETE FROM DetallesCompra
    WHERE DetalleCompraID = @DetalleCompraID;
END;
EXEC InsertarDetalleCompra 
    @CompraID = 301,
    @ProductoID = 703, 
	@IDTransporte = 608, 
    @Cantidad = 5,
    @PrecioUnitario = 520.00;

	EXEC ObtenerDetallesCompra;

	EXEC ActualizarDetalleCompra 
    @DetalleCompraID = 1, -- Ajustar según el detalle de compra deseado
    @CompraID = 2, -- Ajustar según la nueva compra
    @ProductoID = 2, -- Ajustar según el nuevo producto
	@IDTransporte = 2, -- Ajustar según el nuevo transporte
    @Cantidad = 10,
    @PrecioUnitario = 29.99;

	EXEC EliminarDetalleCompra @DetalleCompraID = 1; -- Ajustar según el detalle de compra deseado
