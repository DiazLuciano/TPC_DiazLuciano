create database DIAZ_DB
go
use DIAZ_DB
go
SET DATEFORMAT DMY

--USUARIOS

create table Usuarios(
	ID bigint not null primary key identity (1,1),
	Nombre varchar(50) not null,
	Contraseña varchar(50) not null
)
go
INSERT INTO Usuarios (Nombre,Contraseña) values ('admin', 'admin')
GO

--LOCALIDAD
--create table Localidades(
--	CPLoc int null primary key,
--	NombreLoc varchar (100) not null,
--	Pais varchar (50) null,
--	Provincia varchar (50) null,
--	Ciudad varchar (50) null	
--)
--go
--INSERT INTO Localidades (CPLoc,NombreLoc,Pais,Provincia,Ciudad)
--VALUES (1617,'El Talar','Argentina','Buenos Aires','Tigre')

--TELEFONOS

create table Telefonos(
	ID bigint not null primary key identity (1,1),
	IDCliente bigint not null,
	Telefono varchar(50) not null,
	Tipo varchar(50) not null
)
go

create procedure SP_TraerTelefonos(@idCli bigint) as
begin
	Select ID,IDCliente,Telefono,Tipo from Telefonos where IDCliente= @idCli
end

go

create procedure SP_AgregarTelefono(@idcliente bigint,@numero varchar(20),@tipo varchar(20))
as
begin
	Insert Into Telefonos(IDCliente,Telefono,Tipo) Values (@idcliente,@numero,@tipo)
end

go

exec SP_AgregarTelefono 1,1159102957,Celular
exec SP_AgregarTelefono 1,1122334455,Casa
exec SP_AgregarTelefono 2,1199887733,Trabajo
go
select *from Telefonos
---CUENTA BANCARIA
create table CuentasBancarias(
	ID bigint not null primary key identity (1,1),
	IDClientes bigint not null,
	Banco varchar (50) null,
	CBU bigint null unique
)
go

---CLIENTES

CREATE TABLE Clientes(
	------datos personales-----
	ID bigint not null primary key identity(1,1), 
	DNI bigint not null unique, 
	Nombre varchar (50) not null, 
	Apellido varchar (50) not null, 
	Genero char not null check (genero='F' or genero='M' or genero='O'),
	Fnac date not null,
	FechaAlta date not null,
	Edad int not null,
	Email varchar(50) null,
	-----direccion----
	Direccion varchar(100) not null,
	CP int not null,
	Localidad varchar (50) not null,
	Ciudad varchar (50) not null,
	Provincia varchar (50) not null,
	---------tipo---------
	Tipo char not null check (Tipo = 'F' OR TIPO = 'J'),
	CUIL bigint null ,
	CUIT bigint null ,
	RazonSocial varchar(50) null ,

	Estado bit not null 
)
GO

--Insert into Clientes Values( )
--values 
--INSERT INTO Clientes (DNI,Nombre,Apellido,Genero,Fnac,Edad,CUILCUIT,Direccion,CP,Localidad,Ciudad,Provincia,Tipo,RazonSocial,Email,EmailAlt,Estado) 
--values (3345654,'Leonardo','Juber','Masculino','9-09-1995',23,2133456542,'Alberdi 423',1615,'Benavidez','Tigre','Buenos Aires','Fisico','leonardo@gmail.com',1)
--INSERT INTO Clientes (DNI,Nombre,Apellido,Genero,Fnac,Edad,CUILCUIT,Direccion,CP,Localidad,Ciudad,Provincia,Tipo,RazonSocial,Email,EmailAlt,Estado) 
--values (3345653,'Lara','Lor','F','9-08-1995',24,2133456542,'Tocas 222',1543,'Don Torcuato','Tigre','Buenos Aires','Fisico','lara@gmail.com',1)
--GO

--ARTICULOS

create table Articulos(
	ID bigint not null primary key identity (1,1),
	Descripcion varchar (50) not null,
	Marca varchar (50) not null,
	PrecioCompra decimal not null check(PrecioCompra>0),
	PrecioVenta decimal not null check(PrecioVenta>0),
	PrecioVentaMayorista decimal not null check(PrecioVentaMayorista>0),
	TipoArticulo varchar (50) not null
)
GO

INSERT INTO Articulos (Descripcion,Marca,PrecioCompra,PrecioVenta,PrecioVentaMayorista,TipoArticulo) values ('Leche','Serenisima',35,45,40,'Comida')
INSERT INTO Articulos (Descripcion,Marca,PrecioCompra,PrecioVenta,PrecioVentaMayorista,TipoArticulo) values ('Fideos','Knor',20,35,30,'Comida')
INSERT INTO Articulos (Descripcion,Marca,PrecioCompra,PrecioVenta,PrecioVentaMayorista,TipoArticulo) values ('Televisor','Samsung',12000,15000,13000,'Electronica')
GO

--PROVEEDORES
create table Proveedores(
	ID bigint not null primary key identity(1,1),
	IDArticulo bigint not null foreign key references Articulos(ID)
)
go

-------PROCESOS
create procedure SP_VerClientesPorDni (@dni bigint) as
begin
	select *from Clientes
	where DNI=@dni
end
Go

create procedure SP_VerClientes as
begin
	select * from Clientes
end
GO

create procedure SP_InsertarClientes(@dni bigint,@nom varchar(50),@ape varchar (50),@gen char,@fnac date,@edad int,@email varchar(50),@dir varchar(50),@cp int,@loc varchar(50),@ciu varchar (50),@prov varchar (50),@tipo char,@cuil bigint,@cuit bigint,@rz varchar (50))as
begin
	declare @fechaalta date
	select @fechaalta = Cast(GETDATE() as date)
	Insert into Clientes (dni,nombre,apellido,Genero,Fnac,fechaalta,Edad,email,Direccion,cp,Localidad,Ciudad,Provincia,Tipo,CUIL,CUIT,RazonSocial,Estado) values (@dni,@nom,@ape,@gen,@fnac,@fechaalta,@edad,@email,@dir,@cp,@loc,@ciu,@prov,@tipo,@cuil,@cuit,@rz,1)
end
go

exec SP_InsertarClientes 12323412,'Alejandra','More','F','12-1-1999',20,'ale@gmail.com','thomas 333',1324,'Munro','Vicente Lopez','Buenos Aires','F',12123234122,'',''
exec SP_InsertarClientes 39105320,'Luciano','Diaz','M','10-09-1995',23,'luchodiaz1995@gmail.com','Groussac 2038',1617,'El Talar','Tigre','Buenos Aires','F',20391053201,'',''
go



