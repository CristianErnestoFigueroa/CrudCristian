create database sistema_ventas;
use sistema_ventas;

create table tb_usuario(
iDUsuario int primary key identity(1,1),
email varchar (50),
contrasena varchar(100)
);

create table tb_documento(
iDDocumento int primary key identity (1,1),
nombreDocumento varchar (50)
);

create table tb_cliente (
iDCliente int primary key identity(1,1),
nombreCliente varchar (50),
direccionCliente varchar(50),
duiCliente varchar(50)
);

create table tb_producto(
idProducto int primary key identity (1,1),
nombreProducto varchar(50),
precioProducto varchar (50),
estadoProducto varchar (50)
);
Create table tb_venta(
iDVenta int primary Key identity(1,1),
iDDocumento int,
iDCliente int,
iDUsuario int,
iDProducto int,
totalVenta decimal(18,5),
fecha Date
);

create table tb_detalleVenta(
iDDetalleVenta int primary key identity(1,1),
idVenta int,
idProducto int,
cantidad int,
precio Decimal(18,5),
total Decimal(18,5)
);





--alter table tb_detalleventa alter column precio decimal(18,5)
--alter table tb_detalleventa alter column total decimal(18,5)

--alter table tb_venta alter column totalventa decimal(18,5)