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


