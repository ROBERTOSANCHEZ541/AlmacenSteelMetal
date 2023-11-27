CREATE PROCEDURE VerificarLogin
    @Nombre NVARCHAR(50),
    @RFCDesencriptado NVARCHAR(50)
AS
BEGIN
    DECLARE @RFCEncriptado VARBINARY(1600)
    
    SELECT @RFCEncriptado = RFC
    FROM Empleado
    WHERE Nombre = @Nombre;

    IF @RFCEncriptado IS NOT NULL AND CONVERT(NVARCHAR(50), DECRYPTBYPASSPHRASE('R0bert541', @RFCEncriptado)) = @RFCDesencriptado
    BEGIN
        -- Login exitoso
        SELECT 'Login exitoso' AS Mensaje, 1 AS Resultado;
    END
    ELSE
    BEGIN
        -- Credenciales inválidas
        SELECT 'Credenciales inválidas' AS Mensaje, 0 AS Resultado;
    END
END;

DECLARE @Mensaje NVARCHAR(MAX);
DECLARE @Resultado INT;

EXEC VerificarLogin
    @Nombre = 'Mario Gutierrez',
    @RFCDesencriptado = 'MAGS5793568';

SELECT @Mensaje AS Mensaje, @Resultado AS Resultado;

select*from DetallesCompra