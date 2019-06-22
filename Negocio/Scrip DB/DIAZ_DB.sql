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
use DIAZ_DB
go


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
	TipoArticulo varchar (50) not null,
	Fecha_alta date not null,
	Imagen varchar(800)  NULL,
	Estado bit not null
)
GO


create procedure SP_InsertarArticulo(@des varchar(50),@mar varchar(50),@tipoA varchar (50),@prec decimal,@prev decimal)as
begin
	Insert into Articulos (Descripcion,Marca,TipoArticulo,PrecioCompra,PrecioVenta,Fecha_alta,Estado) values (@des,@mar,@tipoA,@prec,@prev,getdate(),1)
end
go
Exec SP_InsertarArticulo 'Leche','Serenisima','lacteo',35,45
Exec SP_InsertarArticulo 'Fideos','Knor','Pastas',20,35
Exec SP_InsertarArticulo 'Televisor','Samsung','Electronica',12000,15000
go
create procedure SP_ModificarArticulo(@id bigint,@des varchar(50),@mar varchar(50),@tipoA varchar (50),@prec decimal,@prev decimal)as
begin
	update Articulos set Descripcion=@des,Marca=@mar, TipoArticulo=@tipoA,PrecioCompra=@prec,PrecioVenta=@prev where ID=@id
end
go

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


create table Detalles(
	NumFac bigint not null,
	CodPro bigint not null,
	PrecioV decimal not null,
	CantVend int not null
	)
go
create table Facturas(
	ID bigint not null primary key identity(1,1),
	Fecha_fac date not null,
	IDCliente bigint not null
	)
go

create procedure SP_ActualizarDetalles (@numF bigint,@codPro bigint,@preV decimal,@cantV int) AS
begin
	insert into Detalles (NumFac,CodPro,PrecioV,CantVend) values (@numF,@codPro,@preV,@cantV)
end
go

create procedure SP_ActualizarFacturas (@codCli bigint) as 
begin
	declare @numFac bigint
	select @numFac=max(ID)from Facturas
	if @numFac is null set @numFac = 0
	set @numFac = @numFac+1
	insert into Facturas (ID,Fecha_fac,IDCliente)values (@numFac,GETDATE(), @codCli)
	select *from Facturas where ID=@numFac
end

go
--ESTE PROCEDIMIENTO ME SIRVE PARA RECOLECTAR DATOS DE LA VENTANA FACTURACION
create procedure SP_DatosFactura (@numfac bigint )as
begin
	select f.*,d.PrecioV,d.CantVend,c.Nombre,a.Descripcion,d.PrecioV*d.CantVend as Importe
	from Facturas as f inner join detalles as d on f.ID=d.NumFac
	inner join Articulos as A on A.ID=d.CodPro
	inner join Clientes as c on c.ID=f.IDCliente
	where f.ID=@numfac
end