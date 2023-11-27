--CRUD Empleado
CREATE PROCEDURE InsertarEmpleado
    @Nombre NVARCHAR(50),
    @Edad INT,
    @RFC NVARCHAR(50),
    @Telefono VARCHAR(10),
    @CURP VARCHAR(18),
    @NSS CHAR(11),
    @Puesto NVARCHAR(100),
    @IDSucursal INT
AS
BEGIN
    DECLARE @RFCEncriptado VARBINARY(1600)
    SET @RFCEncriptado = ENCRYPTBYPASSPHRASE('R0bert541', @RFC)
    INSERT INTO Empleado (Nombre, Edad, RFC, Telefono, CURP, NSS, Puesto, IDSucursal)
    VALUES (@Nombre, @Edad, @RFCEncriptado, @Telefono, @CURP, @NSS, @Puesto, @IDSucursal);
END;

EXEC InsertarEmpleado 'Mario Gutierrez', 28, 'MAGS5793568', '866114256', 'MAGS6794769603748h', 'MAGS0102204', 'Gerente', 120;

--SP_select 
CREATE PROCEDURE ObtenerEmpleados
    @IDSucursal INT
AS
BEGIN
    SELECT
        IdEmpleado,
        Nombre,
        Edad,
        CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE('R0bert541', RFC)) AS RFC_Desencriptado,
        Telefono,
        CURP,
        NSS,
        Puesto,
        IDSucursal
    FROM Empleado
    WHERE IDSucursal = @IDSucursal;
END;
EXEC ObtenerEmpleados @IDSucursal = 120;
CREATE PROCEDURE ObtenerEmpleadosG 
AS
BEGIN
    SELECT
        IdEmpleado,
        Nombre,
        Edad,
        CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE('R0bert541', RFC)) AS RFC_Desencriptado,
        Telefono,
        CURP,
        NSS,
        Puesto,
        IDSucursal
    FROM Empleado
END;
EXEC ObtenerEmpleadosG;
CREATE PROCEDURE ActualizarEmpleado
    @IdEmpleado INT,
    @Nombre NVARCHAR(50),
    @Edad INT,
    @RFC NVARCHAR(50),
    @Telefono VARCHAR(10),
    @CURP VARCHAR(18),
    @NSS CHAR(11),
    @Puesto NVARCHAR(100),
    @IDSucursal INT
AS
BEGIN
    DECLARE @RFCEncriptado VARBINARY(1600)
    SET @RFCEncriptado = ENCRYPTBYPASSPHRASE('TuContraseña', @RFC)

    UPDATE Empleado
    SET
        Nombre = @Nombre,
        Edad = @Edad,
        RFC = @RFCEncriptado,
        Telefono = @Telefono,
        CURP = @CURP,
        NSS = @NSS,
        Puesto = @Puesto,
        IDSucursal = @IDSucursal
    WHERE IdEmpleado = @IdEmpleado;
END;
EXEC ActualizarEmpleado 1206, 'robert ackerman ', 22, 'HGFJ023402', '8661234365', 'RASS432546', '22234676', 'Asistente', 101;


CREATE PROCEDURE EliminarEmpleado
    @IdEmpleado INT
AS
BEGIN
    DELETE FROM Empleado
    WHERE IdEmpleado = @IdEmpleado;
END;
EXEC EliminarEmpleado 1206;


