CREATE PROCEDURE InsertarTransporte
    @Nombre NVARCHAR(100),
    @Tipo NVARCHAR(50),
    @CapacidadKg INT,
    @NumeroPlaca NVARCHAR(20)
AS
BEGIN
    INSERT INTO Transporte (Nombre, Tipo, CapacidadKg, NumeroPlaca)
    VALUES (@Nombre, @Tipo, @CapacidadKg, @NumeroPlaca);
END;
CREATE PROCEDURE ObtenerTransportes
AS
BEGIN
    SELECT IDTransporte, Nombre, Tipo, CapacidadKg, NumeroPlaca
    FROM Transporte;
END;
CREATE PROCEDURE ActualizarTransporte
    @IDTransporte INT,
    @Nombre NVARCHAR(100),
    @Tipo NVARCHAR(50),
    @CapacidadKg INT,
    @NumeroPlaca NVARCHAR(20)
AS
BEGIN
    UPDATE Transporte
    SET 
        Nombre = @Nombre,
        Tipo = @Tipo,
        CapacidadKg = @CapacidadKg,
        NumeroPlaca = @NumeroPlaca
    WHERE IDTransporte = @IDTransporte;
END;
CREATE PROCEDURE EliminarTransporte
    @IDTransporte INT
AS
BEGIN
    DELETE FROM Transporte
    WHERE IDTransporte = @IDTransporte;
END;
EXEC InsertarTransporte 
    @Nombre = 'Camión A',
    @Tipo = 'Camión',
    @CapacidadKg = 5000,
    @NumeroPlaca = 'ABC123';
	EXEC ObtenerTransportes;

	EXEC ActualizarTransporte 
    @IDTransporte = 606, -- Ajustar según el transporte deseado
    @Nombre = 'Camión B',
    @Tipo = 'Camión',
    @CapacidadKg = 6000,
    @NumeroPlaca = 'XYZ789';
	EXEC EliminarTransporte @IDTransporte = 606; -- Ajustar según el transporte deseado
