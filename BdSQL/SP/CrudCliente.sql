CREATE PROCEDURE InsertarCliente
    @Nombre NVARCHAR(50),
    @Email NVARCHAR(255),
    @Telefono VARCHAR(10),
    @NuevoID INT OUTPUT  
AS
BEGIN
    INSERT INTO Cliente (Nombre, Email, Telefono)
    VALUES (@Nombre, @Email, @Telefono);
    SET @NuevoID = SCOPE_IDENTITY();
END;

CREATE PROCEDURE ObtenerClientes
AS
BEGIN
    SELECT IdCliente, Nombre, Email, Telefono
    FROM Cliente;
END;

CREATE PROCEDURE ActualizarCliente
    @IdCliente INT,
    @Nombre NVARCHAR(50),
    @Email NVARCHAR(255),
    @Telefono VARCHAR(10)
AS
BEGIN
    UPDATE Cliente
    SET Nombre = @Nombre, Email = @Email, Telefono = @Telefono
    WHERE IdCliente = @IdCliente;
END;

CREATE PROCEDURE EliminarCliente
    @IdCliente INT
AS
BEGIN
    DELETE FROM Cliente
    WHERE IdCliente = @IdCliente;
END;
EXEC InsertarCliente 'Juan Pérez', 'juan@example.com', '1234567890';
EXEC ObtenerClientes;
EXEC ActualizarCliente @IdCliente = 1, @Nombre = 'María González', @Email = 'maria@example.com', @Telefono = '9876543210';
EXEC EliminarCliente @IdCliente = 601;

