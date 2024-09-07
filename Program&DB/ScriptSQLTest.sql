-- Crear base de datos
CREATE DATABASE Test;
GO

-- Usar la base de datos creada
USE Test;
GO

-- Crear la tabla TipoProducto
CREATE TABLE TipoProducto (
    IdTipoProducto INT PRIMARY KEY,
    Descripcion VARCHAR(300)
);
GO

-- Crear la tabla Producto
CREATE TABLE Producto (
    IdProducto INT PRIMARY KEY IDENTITY(1,1), -- Autoincremental
    IdTipoProducto INT,
    Nombre VARCHAR(50),
    Precio FLOAT,
	Cantidad INT
    FOREIGN KEY (IdTipoProducto) REFERENCES TipoProducto(IdTipoProducto)
);
GO

-- Crear la tabla Stock
CREATE TABLE Stock (
    IdStock INT PRIMARY KEY IDENTITY(1,1), -- Autoincremental
    IdProducto INT,
    Cantidad INT,
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);
GO

-- Crear la vista vw_StockProducto
CREATE VIEW vw_StockProducto
as
SELECT IdStock, IdProducto, Cantidad
FROM Stock
GO

-- Crear el procedimiento almacenado para insertar un producto
CREATE PROCEDURE sp_InsertarProducto
    @IdTipoProducto INT,
    @Nombre VARCHAR(50),
    @Precio FLOAT,
    @Cantidad INT
AS
BEGIN
    -- Insertar en la tabla Producto
    INSERT INTO Producto (IdTipoProducto, Nombre, Precio, Cantidad)
    VALUES (@IdTipoProducto, @Nombre, @Precio, @Cantidad);
END;
GO

-- Crear el procedimiento almacenado para modificar un producto
CREATE PROCEDURE sp_ModificarProducto
    @IdProducto INT,
    @NuevoIdTipoProducto INT,
    @NuevoNombre VARCHAR(50),
    @NuevoPrecio MONEY,
    @NuevaCantidad INT
AS
BEGIN
    -- Actualizar los datos en la tabla Producto
    UPDATE Producto
    SET IdTipoProducto = @NuevoIdTipoProducto,
        Nombre = @NuevoNombre,
        Precio = @NuevoPrecio
    WHERE IdProducto = @IdProducto;
END;
GO

-- Crear el procedimiento almacenado para eliminar un producto
CREATE PROCEDURE sp_EliminarProducto
    @IdProducto INT
AS
BEGIN
    -- Eliminar primero de la tabla Stock
    DELETE FROM Stock WHERE IdProducto = @IdProducto;

    -- Eliminar luego de la tabla Producto
    DELETE FROM Producto WHERE IdProducto = @IdProducto;
END;
GO

-- Eliminar la clave foránea en Producto que referencia a TipoProducto
ALTER TABLE Producto
DROP CONSTRAINT FK_Producto_TipoProducto;


INSERT INTO TipoProducto (IdTipoProducto, Descripcion) VALUES (1, 'Resistencia');
INSERT INTO TipoProducto (IdTipoProducto, Descripcion) VALUES (2, 'Capacitor');
INSERT INTO TipoProducto (IdTipoProducto, Descripcion) VALUES (3, 'Transistor');
INSERT INTO TipoProducto (IdTipoProducto, Descripcion) VALUES (4, 'Diodo');
INSERT INTO TipoProducto (IdTipoProducto, Descripcion) VALUES (5, 'Potenciometro');

SELECT * FROM TipoProducto
SELECT * FROM Producto
