USE master
GO

--Creamos la base de datos.
CREATE DATABASE comentarios
GO

USE comentarios
/*
	Creación de tablas.
*/

-- Tabla Usuarios.
CREATE TABLE Comentarios (
	Id INT IDENTITY,
	Nombre Varchar(80),
	Mensaje VARCHAR(140),
	CONSTRAINT pk_Comentarios_Id PRIMARY KEY NONCLUSTERED(Id)
)
GO

CREATE PROCEDURE InsertarMensaje
(
	@Nombre Varchar(80),
	@Mensaje Varchar(140)
)
AS
BEGIN
	INSERT INTO comentarios..Comentarios (Nombre, Mensaje) VALUES (@Nombre, @Mensaje)
END

CREATE PROCEDURE MostrarMensajes
(
	@Id INT
)
AS
BEGIN
	SELECT Nombre, Mensaje from Comentarios ORDER BY Id
END