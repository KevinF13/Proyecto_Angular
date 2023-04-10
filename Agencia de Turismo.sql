---------Base de datos Agencia de Turismo-------
---------Kevin Fajardo-------
--Creacion de Base de datos
CREATE DATABASE Agencia
USE master
Go
if exists(
    Select name
    from sys.sysdatabases
    where name = 'Agencia')
        drop database Agencia
create database Agencia
go
USE Agencia
Go

--/Creacion tabla Plan de viaje/
--/Fecha última modificación: 01 de abril 2023/
	if exists(
		select * from sys.sysobjects
		where type = 'U' and name = 'Cliente')
			drop table Cliente 
	else
		
		create table Cliente
		(
		idCliente int identity(1,1) primary key not null,
		nombre varchar(60) not null,
		apellido varchar(60) not null,
		cedula char(10) not null,
		email varchar(60) not null,
		celular varchar(15) not null
		)
		go


--/Creacion tabla Usuarios para Login/
--/Fecha última modificación: 08 de abril 2023/
	if exists(
		select * from sys.sysobjects
		where type = 'U' and name = 'Usuario')
			drop table Usuario 
	else
		
		create table Usuario
		(
		idUsuario int identity(1,1) primary key not null,
		nombre varchar(60) not null,
		apellido varchar(60) not null,
		email varchar(60) not null,
		contrasena varchar(60) not null,
		rcontrasena varchar(60) not null,
		celular varchar(15) not null
		)
		go

--/Procedimiento almacenado para realizar AGREGAR USUARIO/
--/Fecha última modificación: 09 de abril 2023/
CREATE PROC Usuario_add
@nombre varchar(60),
@apellido varchar(60),
@email varchar(60),
@contrasena varchar(60),
@rcontrasena varchar(60),
@celular varchar(15)
AS
INSERT INTO Usuario(nombre,apellido,celular,email,contrasena,rcontrasena)
VALUES(@nombre,
@apellido,
@celular,
@email,
@contrasena,
@rcontrasena)
GO

--/Procedimiento almacenado para realizar consultas/
--/Fecha última modificación: 09 de abril 2023/
CREATE PROC Usuario_all
as
SELECT idUsuario, nombre, apellido, celular, email, contrasena, rcontrasena FROM Usuario
ORDER BY idUsuario ASC
GO

		
--/Procedimiento almacenado para realizar validacionLogin/
--/Fecha última modificación: 09 de abril 2023/
	
Alter PROC usp_ValidaAcceso
@usuario varchar(60),
@contrasena varchar(30)
as
begin 
	set nocount on;

	if exists(select * from Usuario where nombre= @usuario)
	begin
		select * from Usuario where nombre = @usuario
	end
	else
	begin
		select GETDATE() 
	end
end

exec usp_ValidaAcceso 'Pedro', '1234567' 
go

--/Procedimiento almacenado para realizar consultas/
--/Fecha última modificación: 01 de abril 2023/
CREATE PROC Clientes_all
as
SELECT idCliente, nombre, apellido, cedula, email, celular FROM Cliente
ORDER BY idCliente ASC
GO
--/Procedimiento almacenado para realizar AGREGAR CLIENTE/
--/Fecha última modificación: 01 de abril 2023/
CREATE PROC Clientes_add
@nombre varchar(60),
@apellido varchar(60),
@cedula char(10),
@email varchar(60),
@celular varchar(15)
AS
INSERT INTO Cliente(nombre,apellido,cedula,email,celular)
VALUES(@nombre,
@apellido,
@cedula,
@email,
@celular)
GO

--/Procedimiento almacenado para realizar ACTUALIZAR CLIENTE/
--/Fecha última modificación: 01 de abril 2023/
CREATE PROC Clientes_update
@id int,
@nombre varchar(60),
@apellido varchar(60),
@cedula char(10),
@email varchar(60),
@celular varchar(15)
AS
UPDATE Cliente
SET nombre = @nombre,
apellido = @apellido,
cedula = @cedula,
email = @email,
celular = @celular
WHERE idCliente = @id
GO
--/Procedimiento almacenado para realizar ELIMINAR CLIENTE/
--/Fecha última modificación: 01 de abril 2023/
CREATE PROC Clientes_delete
@id int
AS
DELETE FROM Cliente
WHERE idCliente = @id
GO


