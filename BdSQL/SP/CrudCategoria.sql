CREATE PROCEDURE InsertarCategoria
    @TipoCategoria NVARCHAR(15)
AS
BEGIN
    INSERT INTO Categoria (Tipo_Categoria)
    VALUES (@TipoCategoria);
END;
CREATE PROCEDURE ObtenerCategorias
AS
BEGIN
    SELECT id_Categoria, Tipo_Categoria
    FROM Categoria;
END;
CREATE PROCEDURE ActualizarCategoria
    @IdCategoria INT,
    @TipoCategoria NVARCHAR(15)
AS
BEGIN
    UPDATE Categoria
    SET Tipo_Categoria = @TipoCategoria
    WHERE id_Categoria = @IdCategoria;
END;
CREATE PROCEDURE EliminarCategoria
    @IdCategoria INT
AS
BEGIN
    DELETE FROM Categoria
    WHERE id_Categoria = @IdCategoria;
END;
EXEC InsertarCategoria @TipoCategoria = 'Electrónicos';
EXEC ObtenerCategorias;
EXEC ActualizarCategoria @IdCategoria = 1, @TipoCategoria = 'Ropa';
EXEC EliminarCategoria @IdCategoria = 30;
