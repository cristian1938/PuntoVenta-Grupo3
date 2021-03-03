use
master
go
if exists (select * from sysdatabases where name = 'BDSISTEMA_VENTAS')
	drop database BDSISTEMA_VENTAS
go

--Crearemos la base de datos que contendra las entidades necesarias para un sistema de Venta
create database BDSISTEMA_VENTAS
go

USE BDSISTEMA_VENTAS
go

--Creamos la tabla de Usuarios Con sus Contraseñas respectivas
if exists (select * from sysobjects where name = 'TUsuarios')
	drop table TUsuarios
go
create table TUsuarios
(
	Usuario varchar(30) not null,
	Contraseña varchar(20) not null,
	Nombre varchar(40) not null,
	Apellidos varchar(30) not null,
	DNI varchar(8) not null,
	Correo varchar(50)not null,
	Categoria varchar(13) not null,
	primary key(Usuario)
)
go

-- Creamos la tabla TAlmacenProductos contendra los productos y la cantidad de cada uno de ellos dentro de un almacen
if exists (select * from sysobjects where name = 'TProductos')
	drop table TProductos
go
create table TProductos
( 
	CodigoProducto varchar(4) not null,
	Descripcion varchar(60) not null,
	Unidad varchar(10) not null,
	Stock int not null,
	PrecioUnitario float not null,
	primary key(CodigoProducto),
)
go
-- Creacion tabla
if exists (select * from sysobjects where name = 'TVentas')
	drop table TVentas
go
create table TVentas
( 
	CodigoVenta varchar(4) not null,
	PrecioTotal float not null,
	Fecha date not null,
	Usuario varchar(30) not null,
	primary key(CodigoVenta),
	foreign key(Usuario) references TUsuarios,
)
go
-- Creacion tabla
if exists (select * from sysobjects where name = 'TProductosVendidos')
	drop table TProductosVendidos
go
create table TProductosVendidos
( 
	CodigoVenta varchar(4) not null,
	CodigoProducto varchar(4) not null,
	Cantidad int not null,
	primary key(CodigoVenta, CodigoProducto),
	foreign key(CodigoVenta) references TVentas,
	foreign key(CodigoProducto) references TProductos,
)
go
--Insertamos los valores a la tabla de base de datos Usuaios
insert into TUsuarios values('150394','alexander','Alexander Javier','Huaman Guevara','76895691','alexander@gmail.com','Cajero')
insert into TUsuarios values('182914','elvis','Elvis','Huaman Mendoza','76895694','cristian120@gmail.com','Cajero')
insert into TUsuarios values('171061','cristian','Cristian Luis','Guevara Ferro','76895693','cristianA2@gmail.com','Cajero')
insert into TUsuarios values('161367','benjamin','Benjamin Alexander','Hualverde Quispe','76895697','benjaminA9@gmail.com','Cajero')
insert into TUsuarios values('140156','johan','Johan Wilfredo','Huaman Mendoza','76895695','JWHM234@gmail.com','Administrador')

--mostramos la tabla ususarios
--select*from TUsuarios
--Insertamos los productos 

insert into TProductos values('A001','Arroz Campero','kilo',200,3.50)
insert into TProductos values('A002','Azucar Blanca Cartavio','kilo',200,2.50)
insert into TProductos values('A003','Fideo Canuto Molitalia','kilo',100,2.00)
insert into TProductos values('A004','Fideo Spaghetti Nicolini','paquete',100,2.50)
insert into TProductos values('A005','Detergente en polvo Ariel','paquete',100,2.70)
insert into TProductos values('A006','Aceite Vegetal Primor','Litro',100,6.70)
insert into TProductos values('A007','Leche en polvo Gloria','Tarro',100,4.00)
insert into TProductos values('A008','Yogurt Gloria','Litro',100,5.40)
insert into TProductos values('A009','Gaseosa Guarana','Litro',100,3.00)
insert into TProductos values('A010','Cereal Angel','paquete',100,2.50)
insert into TProductos values('A011','Galleta Soda ','paquete',100,0.70)
insert into TProductos values('A012','Vino Blanco  Torres','Litro',100,19.50)
insert into TProductos values('A013','Vino Borgoña  Torres','Litro',100,20.50)
insert into TProductos values('A014','Vino Tinto Torres','Litro',100,18.70)
insert into TProductos values('A015','Filete de Atun Florida','Tarro',100,3.50)
insert into TProductos values('A016','Mermelada de Naranja','Tarro',100,3.70)
insert into TProductos values('A017','Gelatina','Paquete',100,2.50)
insert into TProductos values('A018','Jabon','paquete',100,2.00)
insert into TProductos values('A019','Ayudin','paquete',100,3.50)
insert into TProductos values('A020','Refresco Naranja Zuco','paquete',100,1.90)
insert into TProductos values('A021','Shampoo Head Shoulders','paquete',100,11.50)
insert into TProductos values('A022','Mayonesa','paquete',100,6.50)
insert into TProductos values('A023','Cuaquer','paquete',100,2.50)
insert into TProductos values('A024','Legia','paquete',100,3.50)
insert into TProductos values('A025','Suavizante para ropa','paquete',100,2.70)
insert into TProductos values('A026','Agua mineral San Mateo','paquete',100,1.50)
insert into TProductos values('A027','Agua Mineral San Luis','paquete',100,1.80)
insert into TProductos values('A028','Gaseosa Fanta','Litro',100,4.50)
insert into TProductos values('A029','Gaseosa Inka Cola','Litro',100,4.00)
insert into TProductos values('A030','Gaseosa CocaCola','Litro',100,3.90)
insert into TProductos values('A031','Gaseosa Pepsi','Litro',100,4.50)
insert into TProductos values('A032','Frugos Sabor Naranja','Litro',100,2.70)
insert into TProductos values('A033','Frugos Sabor Durazno','Litro',100,2.70)
insert into TProductos values('A034','Frugos Sabor Mango','Litro',100,2.70)
insert into TProductos values('A035','Frugos Sabor Manzana','Litro',100,2.70)
insert into TProductos values('A036','Milo','Tarro',100,7.00)
insert into TProductos values('A037','Nescafe Kirma','Paquete',100,5.50)
insert into TProductos values('A038','Suavizante Suavitel','paquete',100,3.50)
insert into TProductos values('A039','Papel Higienico Elite x2 Unidades','paquete',100,2.40)
insert into TProductos values('A040','Salchicha De Pollo x6 unidades','paquete',100,5.60)
insert into TProductos values('A041','Mantequilla','paquete',100,4.50)
insert into TProductos values('A042','Mermelada de Sauco Gloria','Tarro',100,5.50)
insert into TProductos values('A043','Mermelada de Fresa Gloria','Tarro',100,5.50)
insert into TProductos values('A044','Miel de Abeja Olivos del Sur','paquete',100,6.00)
insert into TProductos values('A045','Infusion Filtrante Manzanilla','Caja',100,2.00)
insert into TProductos values('A046','Avena Tradicional Quaker','paquete',100,1.80)
insert into TProductos values('A047','Pan de Molde Blanco','paquete',100,2.50)
insert into TProductos values('A048','Arroz Paisana','Kilo',100,3.50)
insert into TProductos values('A049','Azucar Rubia Cartavio','Kilo',100,3.00)
insert into TProductos values('A050','Leche evaporada entera Gloria','Tarro',100,2.90)
--Mostramos la tabla TAlmacenProductos
--select* from TProductos


insert into TVentas values('V001',120,'2021/03/03','182914')
insert into TVentas values('V002',8.90,'2021/03/03','182914')
insert into TProductosVendidos values('V002','A049',2)
insert into TProductosVendidos values('V002','A050',1)
--select * from TVentas
--select * from TProductosVendidos