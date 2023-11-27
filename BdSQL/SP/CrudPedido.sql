CREATE PROCEDURE InsertarPedidoID
    @FechaPedido VARCHAR(10),
    @ClienteID INT,
	 @UltimoID INT OUTPUT
AS
BEGIN
    INSERT INTO Pedidos (FechaPedido, ClienteID)
    VALUES (@FechaPedido, @ClienteID);
	SET @UltimoID = SCOPE_IDENTITY();
END;
CREATE PROCEDURE ObtenerPedidos
AS
BEGIN
    SELECT PedidoID, FechaPedido, ClienteID
    FROM Pedidos;
END;
CREATE PROCEDURE ActualizarPedido
    @PedidoID INT,
    @FechaPedido VARCHAR(10),
    @ClienteID INT
AS
BEGIN
    UPDATE Pedidos
    SET 
        FechaPedido = @FechaPedido,
        ClienteID = @ClienteID
    WHERE PedidoID = @PedidoID;
END;
CREATE PROCEDURE EliminarPedido
    @PedidoID INT
AS
BEGIN
    DELETE FROM Pedidos
    WHERE PedidoID = @PedidoID;
END;
EXEC InsertarPedido 
    @FechaPedido = '2023-11-15',
    @ClienteID = 501; -- Ajustar según el cliente deseado

	EXEC ObtenerPedidos;

	EXEC ActualizarPedido 
    @PedidoID = 1200, -- Ajustar según el pedido deseado
    @FechaPedido = '2023-11-14',
    @ClienteID = 501; -- Ajustar según el nuevo cliente
	EXEC EliminarPedido @PedidoID = 1200; -- Ajustar según el pedido deseado
SELECT * FROM Proveedor