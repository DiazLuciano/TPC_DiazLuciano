create database DIAZ_DB
go
use DIAZ_DB
go
SET DATEFORMAT DMY
go

--USUARIOS

create table Usuarios(
	ID bigint primary key identity (1,1) not null,
	DNI bigint not null foreign key references Clientes(DNI),
	Nombre varchar (50) not null,
	Contraseña varchar (50) not null,
	Tipo varchar (50) not null,
	Estado bit not null
)
go
insert into usuarios (DNI,Nombre,Contraseña,Tipo,Estado) values (12323412,'admin','admin','Administrador',1)
insert into usuarios (DNI,Nombre,Contraseña,Tipo,Estado) values (39105320,'user','user','Usuario',1)

go

--TELEFONOS
create table Telefonos(
	ID bigint not null primary key identity (1,1),
	DNICliente bigint not null,
	Telefono varchar(50) not null,
	Tipo varchar(50) not null
)
go

create procedure SP_TraerTelefonos(@dni bigint) as
begin
	Select ID,DNICliente,Telefono,Tipo from Telefonos where DNICliente= @dni
end
go

create procedure SP_AgregarTelefono(@dni bigint,@numero varchar(20),@tipo varchar(20))
as
begin
	Insert Into Telefonos(DNICliente,Telefono,Tipo) Values (@dni,@numero,@tipo)
end
go

exec SP_AgregarTelefono 39105320,1159102957,Celular
exec SP_AgregarTelefono 39105320,1122334455,Casa
exec SP_AgregarTelefono 12323412,1199887733,Trabajo
go


CREATE TABLE Clientes(

	ID bigint not null primary key identity(1,1), 
	DNI bigint not null unique, 
	Nombre varchar (50) not null, 
	Apellido varchar (50) not null, 
	Genero char not null check (genero='F' or genero='M' or genero='O'),
	Fnac date not null,
	FechaAlta date not null,
	Edad int not null,
	Email varchar(50) null,
	Direccion varchar(100) not null,
	CP int not null,
	Localidad varchar (50) not null,
	Ciudad varchar (50) not null,
	Provincia varchar (50) not null,
	CUILCUIT bigint null,
	Estado bit not null 
)
GO

create table Articulos(
	ID bigint not null primary key identity (1,1),
	Descripcion varchar (50) not null,
	Marca varchar (50) not null,
	PrecioCompra decimal not null check(PrecioCompra>0),
	PrecioVenta decimal not null check(PrecioVenta>0),
	TipoArticulo varchar (50) not null,
	Fecha_alta date not null,
	Stock int not null,
	Imagen varchar(800)  NULL,
	Estado bit not null
)
GO

CREATE TABLE Pedidos (
  IdPedido int primary key,
  DNI bigint foreign key references Clientes (DNI),
  FechaPedido datetime not null Default(getdate()),
  Monto decimal not null
 
)
go

CREATE TABLE PedidosDetalle (
  IdPedido int References Pedidos,
  IdProducto bigint References Articulos,
  PrecioUnidad decimal(10,0) not null,
  Cantidad int not null,
)
go
create procedure SP_InsertarArticulo(@des varchar(50),@mar varchar(50),@prec decimal,@prev decimal,@tipoA varchar (50))as
begin
	Insert into Articulos (Descripcion,Marca,TipoArticulo,PrecioCompra,PrecioVenta,Fecha_alta,Estado) values (@des,@mar,@tipoA,@prec,@prev,getdate(),1)
end
go
Exec SP_InsertarArticulo 'Leche','Serenisima',35,45,'Comida'
Exec SP_InsertarArticulo 'Fideos','Knor',20,35,'Comida'
Exec SP_InsertarArticulo 'Televisor','Samsung',12000,15000,'Electronica'
go
create procedure SP_ModificarArticulo(@id bigint,@des varchar(50),@mar varchar(50),@tipoA varchar (50),@prec decimal,@prev decimal)as
begin
	update Articulos set Descripcion=@des,Marca=@mar, TipoArticulo=@tipoA,PrecioCompra=@prec,PrecioVenta=@prev where ID=@id
end
go

-------PROCESOS
create procedure SP_VerClientesFiltrado as
begin
	select DNI,Apellido,Nombre,Fnac,Edad,Direccion,Localidad from Clientes
end
Go

create procedure SP_VerClientesCompleto as
begin
	select * from Clientes as c left join telefonos as t on t.DNICliente = c.DNI
end
go
select *from Clientes
select *from Usuarios
create procedure SP_InsertarClientes(@dni bigint,@nom varchar(50),@ape varchar (50),@gen char,@fnac date,@edad int,@email varchar(50),@dir varchar(50),@cp int,@loc varchar(50),@ciu varchar (50),@prov varchar (50),@cuilcuit bigint)as
begin
set dateformat dmy
	declare @fechaalta date
	declare @fechaNac date
	select @fechaalta = Cast(GETDATE() as date)
	select @fechaNac = CAST(@fnac as date)
	Insert into Clientes (dni,nombre,apellido,Genero,Fnac,fechaalta,Edad,email,Direccion,cp,Localidad,Ciudad,Provincia,CUILCUIT,Estado) values (@dni,@nom,@ape,@gen,@fechaNac,@fechaalta,@edad,@email,@dir,@cp,@loc,@ciu,@prov,@cuilcuit,1)
end
go

Exec SP_InsertarClientes 21,'ff','ff','F','02/03/1993 00:00:00',5,'adf','ff',44,'ff' ,'fff' ,'ff' ,33
exec SP_InsertarClientes 12323412,'Alejandra','More','F','12-01-1999',20,'ale@gmail.com','thomas 333',1324,'Munro','Vicente Lopez','Buenos Aires',12123234122
exec SP_InsertarClientes 39105320,'Luciano','Diaz','M','10-09-1995',23,'luchodiaz1995@gmail.com','Groussac 2038',1617,'El Talar','Tigre','Buenos Aires',20391053201
go


create table Detalles(
	NumFac bigint not null,
	CodPro bigint not null,
	PrecioV decimal not null,
	CantVend int not null
	)
go

create table Facturas(
	NumFac bigint not null primary key,
	Fecha_fac date not null,
	IDCliente bigint not null
	)
go

create procedure sp_disminuirstock(@id bigint,@can int)as
begin
	update articulos set Stock = Stock - @can where ID = @id
end
go

create procedure sp_pedidoscliente(@dni bigint)as
begin
	select * from Pedidos where dni = @dni
end
go
	select *from clientes

create procedure SP_ActualizarDetalles (@numF bigint,@codPro bigint,@preV decimal,@cantV int) AS
begin
	insert into Detalles (NumFac,CodPro,PrecioV,CantVend) values (@numF,@codPro,@preV,@cantV)
end
go

create procedure SP_ActualizarFacturas (@codCli bigint) as 
begin
	declare @numFac bigint
	select @numFac=max(NumFac)from Facturas
	if @numFac is null set @numFac = 0
	set @numFac = @numFac+1
	insert into Facturas (NumFac,Fecha_fac,IDCliente)values (@numFac,cast(GETDATE() as date), @codCli)
	select *from Facturas where NumFac=@numFac
end

go

create procedure SP_DatosFactura (@numfac bigint )as
begin
	select f.*,d.PrecioV,d.CantVend,c.Nombre,a.Descripcion,d.PrecioV*d.CantVend as Importe
	from Facturas as f inner join detalles as d on f.NumFac=d.NumFac
	inner join Articulos as A on A.ID=d.CodPro
	inner join Clientes as c on c.DNI=f.IDCliente
	where f.NumFac=@numfac
end
go
select *from Usuarios
create procedure SP_DatosFacturaXDni (@dni bigint )as
begin
	select f.*,d.PrecioV,d.CantVend,c.Nombre,a.Descripcion,d.PrecioV*d.CantVend as Importe
	from Facturas as f inner join detalles as d on f.NumFac=d.NumFac
	inner join Articulos as A on A.ID=d.CodPro
	inner join Clientes as c on c.DNI=f.IDCliente
	where f.IDCliente=@dni
end
go

insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Celular','Motorola',12000,14500,'Celulares',getdate(),30,'CelularMotorola.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Celular','Samsung',10000,11500,'Celulares',getdate(),25,'CelularSamsung.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Celular','Xiaomi',9000,11000,'Celulares',getdate(),60,'CelularXiaomi.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Notebook','Samusung',15000,17000,'Notebooks',getdate(),55,'NotebookSamsung.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Notebook','Lenovo',14000,16000,'Notebooks',getdate(),76,'NotebookLenovo.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Heladera','Coventry',19000,21000,'Heladeras',getdate(),55,'HeladeraCoventry.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Heladera','Patrick',23000,25000,'Heladeras',getdate(),43,'HeladeraPatrick.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Microondas','ATMA',4000,5000,'Microondas',getdate(),54,'MicroondasAtma.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Microondas','Aurora',3500,4500,'Microondas',getdate(),43,'MicroondasAurora.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Televisor','Noblex',16000,17000,'Televisores',getdate(),23,'TelevisorNoblex.jpg',1)
insert into Articulos(Descripcion,Marca,PrecioCompra,PrecioVenta,TipoArticulo,Fecha_alta,Stock,Imagen,Estado) values ('Televisor','Philips',14500,16000,'Televisores',getdate(),53,'TelevisorPhilips.jpg',1)