create database DIAZ_DB
go
use DIAZ_DB
go
SET DATEFORMAT DMY
--USUARIOS


create table Usuarios(
	ID int not null primary key identity (1,1),
	Nombre varchar(50) not null,
	Contraseña varchar(50) not null
)
go
INSERT INTO Usuarios (Nombre,Contraseña) values ('admin', 'admin')
GO

--LOCALIDAD
create table Localidades(
	CPLoc int not null primary key,
	NombreLoc varchar (100) not null,
	Pais varchar (50) null,
	Provincia varchar (50) null,
	Ciudad varchar (50) null	
)
go
INSERT INTO Localidades (CPLoc,NombreLoc,Pais,Provincia,Ciudad)
VALUES (1617,'El Talar','Argentina','Buenos Aires','Tigre')

--CLIENTES

CREATE TABLE Clientes(
	ID int not null primary key identity(1,1), 
	DNI int not null unique, 
	Nombre varchar (50) not null, 
	Apellido varchar (50) not null, 
	Genero varchar (50) not null, 
	Fnac datetime not null, 
	Edad int not null,
	CUILCUIT bigint not null,
	Direccion varchar(100) not null,
	CP int not null foreign key references Localidades(CPLoc),
	Tipo varchar(50) not null,
	RazonSocial varchar(100) null,
	Estado bit not null 
)
GO	

INSERT INTO Clientes (DNI,Nombre,Apellido,Genero,Fnac,Edad,CUILCUIT,Direccion,CP,Tipo,Estado) 
values (39105320,'Luciano','Diaz','Masculino','10-09-1995',23,20391053201,'Groussac 2038',1617, 'Fisico',1)
GO
--ARTICULOS
create table Articulos(
	ID int not null primary key identity (1,1),
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

--EMAILS
create table Emails(
	ID int not null primary key identity(1,1),
	Nombre int not null,
	IDClientes int not null foreign key references Clientes(ID)
)
go
---CUENTA BANCARIA
create table CuentasBancarias(
	ID int not null primary key identity (1,1),
	IDClientes int not null foreign key references Clientes(ID),
	Banco varchar (50) not null,
	CBU int null
)
go



--PROVEEDORES
create table Proveedores(
	ID int not null primary key identity(1,1),
	IDArticulo int not null foreign key references Articulos(ID)
)
go

--TELEFONos
create table Telefonos(
	ID int not null primary key identity(1,1),
	IDClientes int not null foreign key references Clientes(ID),
	Telefono varchar(50) not null,
	Tipo varchar(50) not null
)
go 

