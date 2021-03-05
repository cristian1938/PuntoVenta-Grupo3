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
if exists (select * from sysobjects where name = 'TUsuario')
	drop table TUsuario
go
create table TUsuarios
(
	Usuario varchar(30) not null,
	Contraseña varchar(20) not null,
	Nombre varchar(30) not null,
	Apellido varchar(30) not null,
	DNI varchar(8) not null,
	Correo varchar(30) not null,
	Categoria varchar(30)not null,
	primary key(Usuario)
)
go
--Insertamos los valores a la tabla de base de datos Usuaios
--insert into TUsuarios values('alexander@unsaac.edu.pe','alexander','Alexander Javier','Huaman','Guevara','76895691')
--insert into TUsuarios values('elvis@unsaac.edu.pe','elvis','Elvis','Huaman','Mendoza','76895694')
--insert into TUsuarios values('cristian@unsaac.edu.pe','cristian','Cristian Fernando','Guevara','Ferro','76895693')
--insert into TUsuarios values('benjamin@unsaac.edu.pe','benjamin','Benjamin Alexander','Hualverde','Quispe','76895697')
--insert into TUsuarios values('johan@unsaac.edu.pe','johan','Johan Wilfredo','Huaman','Mendoza','76895695')

insert into TUsuarios values('150394','alexander','Alexander Javier','Huaman Guevara','76895691','150394@unsaac.edu.pe','Administrador')
insert into TUsuarios values('182914','elvis','Elvis','Huaman Mendoza','76895694','182914@unsaac.edu.pe','Administrador')
insert into TUsuarios values('171061','cristian','Cristian Luis','Guevara Ferro','76895693','171061@unsaac.edu.pe','Administrador')
insert into TUsuarios values('161367','benjamin','Benjamin Alexander','Hualverde Quispe','76895697','161367@unsaac.edu.pe','Administrador')
insert into TUsuarios values('140156','johan','Johan Wilfredo','Huaman Mendoza','70707070','140156@unsaac.edu.pe','Administrador')
insert into TUsuarios values('admin','admin','admin','admin','70707070','admin@unsaac.edu.pe','Administrador')
insert into TUsuarios values('cajero','cajero','cajero','cajero','70707070','cajero@unsaac.edu.pe','Cajero')

--mostramos la tabla ususarios
--select * from TUsuarios where  Usuario='123456'
create table TAlmacenProductos
( 
	CodigoProducto varchar(4) not null,
	Descripcion varchar(60) not null,
	Unidad varchar(10) not null,
	Cantidad int not null,
	PrecioUnitario float not null,
	primary key(CodigoProducto),
)
--Insertamos los productos 

insert into TAlmacenProductos values('A001','Arroz Campero','kilo',200,3.50)
insert into TAlmacenProductos values('A002','Azucar Blanca Cartavio','kilo',200,2.50)
insert into TAlmacenProductos values('A003','Fideo Canuto Molitalia','kilo',100,2.00)
insert into TAlmacenProductos values('A004','Fideo Spaghetti Nicolini','paquete',100,2.50)
insert into TAlmacenProductos values('A005','Detergente en polvo Ariel','paquete',100,2.70)
insert into TAlmacenProductos values('A006','Aceite Vegetal Primor','Litro',100,6.70)
insert into TAlmacenProductos values('A007','Leche en polvo Gloria','Tarro',100,4.00)
insert into TAlmacenProductos values('A008','Yogurt Gloria','Litro',100,5.40)
insert into TAlmacenProductos values('A009','Gaseosa Guarana','Litro',100,3.00)
insert into TAlmacenProductos values('A010','Cereal Angel','paquete',100,2.50)
insert into TAlmacenProductos values('A011','Galleta Soda ','paquete',100,0.70)
insert into TAlmacenProductos values('A012','Vino Blanco  Torres','Litro',100,19.50)
insert into TAlmacenProductos values('A013','Vino Borgoña  Torres','Litro',100,20.50)
insert into TAlmacenProductos values('A014','Vino Tinto Torres','Litro',100,18.70)
insert into TAlmacenProductos values('A015','Filete de Atun Florida','Tarro',100,3.50)
insert into TAlmacenProductos values('A016','Mermelada de Naranja','Tarro',100,3.70)
insert into TAlmacenProductos values('A017','Gelatina','Paquete',100,2.50)
insert into TAlmacenProductos values('A018','Jabon','paquete',100,2.00)
insert into TAlmacenProductos values('A019','Ayudin','paquete',100,3.50)
insert into TAlmacenProductos values('A020','Refresco Naranja Zuco','paquete',100,1.90)
insert into TAlmacenProductos values('A021','Shampoo Head Shoulders','paquete',100,11.50)
insert into TAlmacenProductos values('A022','Mayonesa','paquete',100,6.50)
insert into TAlmacenProductos values('A023','Cuaquer','paquete',100,2.50)
insert into TAlmacenProductos values('A024','Legia','paquete',100,3.50)
insert into TAlmacenProductos values('A025','Suavizante para ropa','paquete',100,2.70)
insert into TAlmacenProductos values('A026','Agua mineral San Mateo','paquete',100,1.50)
insert into TAlmacenProductos values('A027','Agua Mineral San Luis','paquete',100,1.80)
insert into TAlmacenProductos values('A028','Gaseosa Fanta','Litro',100,4.50)
insert into TAlmacenProductos values('A029','Gaseosa Inka Cola','Litro',100,4.00)
insert into TAlmacenProductos values('A030','Gaseosa CocaCola','Litro',100,3.90)
insert into TAlmacenProductos values('A031','Gaseosa Pepsi','Litro',100,4.50)
insert into TAlmacenProductos values('A032','Frugos Sabor Naranja','Litro',100,2.70)
insert into TAlmacenProductos values('A033','Frugos Sabor Durazno','Litro',100,2.70)
insert into TAlmacenProductos values('A034','Frugos Sabor Mango','Litro',100,2.70)
insert into TAlmacenProductos values('A035','Frugos Sabor Manzana','Litro',100,2.70)
insert into TAlmacenProductos values('A036','Milo','Tarro',100,7.00)
insert into TAlmacenProductos values('A037','Nescafe Kirma','Paquete',100,5.50)
insert into TAlmacenProductos values('A038','Suavizante Suavitel','paquete',100,3.50)
insert into TAlmacenProductos values('A039','Papel Higienico Elite x2 Unidades','paquete',100,2.40)
insert into TAlmacenProductos values('A040','Salchicha De Pollo x6 unidades','paquete',100,5.60)
insert into TAlmacenProductos values('A041','Mantequilla','paquete',100,4.50)
insert into TAlmacenProductos values('A042','Mermelada de Sauco Gloria','Tarro',100,5.50)
insert into TAlmacenProductos values('A043','Mermelada de Fresa Gloria','Tarro',100,5.50)
insert into TAlmacenProductos values('A044','Miel de Abeja Olivos del Sur','paquete',100,6.00)
insert into TAlmacenProductos values('A045','Infusion Filtrante Manzanilla','Caja',100,2.00)
insert into TAlmacenProductos values('A046','Avena Tradicional Quaker','paquete',100,1.80)
insert into TAlmacenProductos values('A047','Pan de Molde Blanco','paquete',100,2.50)
insert into TAlmacenProductos values('A048','Arroz Paisana','Kilo',100,3.50)
insert into TAlmacenProductos values('A049','Azucar Rubia Cartavio','Kilo',100,3.00)
insert into TAlmacenProductos values('A050','Leche evaporada entera Gloria','Tarro',100,2.90)
--Mostramos la tabla TAlmacenProductos
--select* from TAlmacenProductos
--SELECT * FROM TUsuarios

--select * from TAlmacenProductos where Descripcion like'Arroz%'
--select * from TAlmacenProductos where CodigoProducto='A049'

--update TAlmacenProductos set Cantidad = 5 where CodigoProducto='A050'

--select Cantidad from TAlmacenProductos where CodigoProducto='A049'

--update TUsuarios set Usuario='alexander',Nombre='NOSE',Apellidos='ASD' WHERE Usuario='qwe'

create table TVentas(
CodVenta varchar(6),
PrecioTotal float not null,
Fecha date  ,
Estado varchar(9),
primary key (CodVenta)
)
--drop table TVentas

insert into TVentas values('V00002',12.5,'2021/05/30','VENDIDO')
insert into TVentas values('V00001',10.3,'2021/06/25','VENDIDO')
insert into TVentas values('V00003',12.5,'2021/06/30','VENDIDO')
insert into TVentas values('V00005',10.3,'2021/07/30','VENDIDO')



create table arqueo(
Usuario varchar(30),
Categoria varchar(30),
Fecha Varchar(30),
Hora varchar(5),
diferencia varchar(10),
Montototal varchar(10),
)
--drop table arqueo
--select * from arqueo
insert into arqueo values('alex','nose','2021/07/30','11:30','12.00','50.00')

--SELECT * FROM TVentas
--SELECT * FROM TVentas WHERE Fecha BETWEEN '2021/05/30' and '2021/06/30'

--select * from TVentas WHERE FECHA='2021/03/03'
--select MAX(CodVenta) AS  ULTIMO  from TVentas
--SELECT  * FROM ARQUEO

--delete 

select * from TUsuarios