create database DIAZ_DB
go
use DIAZ_DB
go
--USUARIOS

create table Usuarios(
	ID int not null primary key identity (1,1),
	Nombre varchar(50) not null,
	Contraseña varchar(50) not null
)
go

insert into Usuarios (Nombre,Contraseña) values ('admin', 'admin')
GO

--CLIENTES

CREATE TABLE Clientes(
	ID int not null primary key identity(1,1),
	DNI int not null unique,
	Nombre varchar (50) not null,
	Apellido varchar (50) not null,
	/*Genero varchar (50) not null,
	Edad int not null,
	Fnac datetime not null,
	CUIL int not null,
	CUIT int null,
	Direccion varchar(100) not null,
	CP int not null foreign key references Localidad(CP),
	IDUsuario int null foreign key references Usuarios(ID),
	Tipo varchar(50) not null,
	RazonSocial varchar(100) null*/
)
GO
INSERT INTO Clientes (DNI,Nombre,Apellido) 
values (39105320,'Luciano','Diaz')
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

--LOCALIDAD
create table Localidad(
	CP int not null primary key,
	Nombre varchar (100) not null,
	Pais varchar (50) null,
	Provincia varchar (50) null,
	Ciudad varchar (50) null	
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

