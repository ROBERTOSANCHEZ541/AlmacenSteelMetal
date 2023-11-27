CREATE PROCEDURE InsertarProducto
    @NombreProducto NVARCHAR(255),
    @Precio DECIMAL(10, 2),
    @Stock INT,
    @Descripcion NVARCHAR(MAX),
    @IDCategoria INT,
    @IDSucursal INT
AS
BEGIN
    INSERT INTO Productos (NombreProducto, Precio, Stock, Descripcion, ID_Categoria, IDSucursal)
    VALUES (@NombreProducto, @Precio, @Stock, @Descripcion, @IDCategoria, @IDSucursal);
END;
CREATE PROCEDURE ObtenerProductos
AS
BEGIN
    SELECT 
        IdArticulo,
        NombreProducto,
        Precio,
        Stock,
        Descripcion,
        ID_Categoria,
        IDSucursal
    FROM Productos;
END;
CREATE PROCEDURE ActualizarProducto
    @IdArticulo INT,
    @NombreProducto NVARCHAR(255),
    @Precio DECIMAL(10, 2),
    @Stock INT,
    @Descripcion NVARCHAR(MAX),
    @IDCategoria INT,
    @IDSucursal INT
AS
BEGIN
    UPDATE Productos
    SET 
        NombreProducto = @NombreProducto,
        Precio = @Precio,
        Stock = @Stock,
        Descripcion = @Descripcion,
        ID_Categoria = @IDCategoria,
        IDSucursal = @IDSucursal
    WHERE IdArticulo = @IdArticulo;
END;
CREATE PROCEDURE EliminarProducto
    @IdArticulo INT
AS
BEGIN
    DELETE FROM Productos
    WHERE IdArticulo = @IdArticulo;
END;
EXEC InsertarProducto 
    @NombreProducto = 'Producto A',
    @Precio = 19.99,
    @Stock = 100,
    @Descripcion = 'Descripci�n del Producto A',
    @IDCategoria = 22, -- Ajustar seg�n la categor�a deseada
    @IDSucursal = 101; -- Ajustar seg�n la sucursal deseada

	EXEC ObtenerProductos;

	EXEC ActualizarProducto 
    @IdArticulo = 804, -- Ajustar seg�n el producto deseado
    @NombreProducto = 'Producto B',
    @Precio = 29.99,
    @Stock = 150,
    @Descripcion = 'Nueva descripci�n del Producto B',
    @IDCategoria = 23, -- Ajustar seg�n la nueva categor�a
    @IDSucursal = 102; -- Ajustar seg�n la nueva sucursal

	EXEC EliminarProducto @IdArticulo = 804; -- Ajustar seg�n el producto deseado

	CREATE PROCEDURE ActualizarProducto1
    @IdArticulo INT,
    @NombreProducto NVARCHAR(255),
    @Precio DECIMAL(10, 2),
    @Stock INT
AS
BEGIN
    UPDATE Productos
    SET 
        NombreProducto = @NombreProducto,
        Precio = @Precio,
        Stock = @Stock
    WHERE IdArticulo = @IdArticulo;
END;