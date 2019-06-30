/*Create*/
create table Categoria(
	ID_ct int not null identity (1,1), 
	Nombre varchar (50) not null,
	primary key (ID_ct)
);

create table Sucursal(
	ID_scr int not null, 
	Nombre varchar (50) not null,
	Localidad varchar (50) not null,
	primary key (ID_scr)
);

create table Empleado(
	Legajo int not null, 
	Nombre varchar (50) not null,
	Apellido varchar (50) not null,
	ID_ct int not null,
	ID_scr int not null,
	primary key (Legajo),
	constraint fk_Empleado_Categoria_1
	foreign key (ID_ct) references Categoria(ID_ct),
	constraint fk_Empleado_Sucursal_1
	foreign key (ID_scr) references Sucursal(ID_scr),
	
);

create table Usuario(
	ID_user int not null,
	Pass varchar(16) not null,
	primary key (ID_user),
	constraint fk_Usuario_Empleado_1
	foreign key (ID_user) references Empleado(Legajo)
);


create table Proveedor(
	ID_prov int not null identity (1,1),
	nombre varchar(50) not null,
	telefono bigint not null,
	primary key(ID_prov)

);

create table Producto(
	Cod_art int not null identity (1,1),
	descripcion varchar(50) not null,
	peso int not null,
	simbpeso varchar(3) not null,
	ID_prov int not null,
	primary key(Cod_art),
	constraint fk_Stock_Proveedor_1
	Foreign key (ID_prov) references Proveedor (ID_prov)
);
create table Producto_Sucursal(
	Cod_art int not null,
	ID_scr int not null,
	cantidad int not null,
	precio decimal(10,2) not null,
	primary key(Cod_art,ID_scr),
	constraint fk_Producto_Sucursal_1
	Foreign key (Cod_art) references Producto (Cod_art),
	constraint fk_Producto_Sucursal_2
	Foreign key (ID_scr) references Sucursal (ID_scr)
);


create table ModoPago(
	ID_mp int identity (1,1) not null,
	nombre varchar(50) not null,
	primary key(ID_mp)

);

create table Venta(
Ticket bigint not null,
monto decimal (11,2) not null,
n_comp int default 0,
ID_mp int not null,
fecha datetime not null,
ID_scr int not null,
primary key(Ticket),
constraint fk_Detalle_Sucursal_1
Foreign key (ID_scr) references Sucursal (ID_scr),
constraint fk_Venta_ModoPago_1
Foreign key (ID_mp) references ModoPago (ID_mp)
);

create table Detalle(
ID_det bigint identity (1,1) not null,
Cod_art int not null,
descripcion varchar(100) not null,
P_unidad decimal(10,2) not null,
cantidad int not null,
total decimal(38,2) not null,
Ticket bigint not null,
primary key(ID_det),
constraint fk_Detalle_Venta_1
Foreign key(Ticket) references Venta(Ticket),
constraint fk_Detalle_Producto
Foreign key(Cod_art) references Producto(Cod_art)
);



/*Inserts*/


insert into Sucursal(ID_scr,Nombre, Localidad)
values (123,'Dia','Ezeiza');
insert into Sucursal(ID_scr,Nombre, Localidad)
values (70,'Dias','Monte grande');

insert into Categoria(Nombre)
values ('Cajero');
insert into Categoria(Nombre)
values ('Repositor');
insert into Categoria(Nombre)
values ('Tesoreria');
insert into Categoria(Nombre)
values ('Gerencia');

insert into Empleado(Legajo,Nombre,Apellido,ID_ct,ID_scr)
values (12345678,'Cajero','SR',1,123);
insert into Empleado(Legajo,Nombre,Apellido,ID_ct,ID_scr)
values (87654321,'Repositor','SR',2,70);
insert into Empleado(Legajo,Nombre,Apellido,ID_ct,ID_scr)
values (11223344,'Tesorera','SRA',3,123);
insert into Empleado(Legajo,Nombre,Apellido,ID_ct,ID_scr)
values (44332211,'Gerente','SR',4,70);

insert into Usuario(ID_user,Pass)
values(12345678,'hola');
insert into Usuario(ID_user,Pass)
values(87654321,'chau');
insert into Usuario(ID_user,Pass)
values(11223344,'hola');
insert into Usuario(ID_user,Pass)
values(44332211,'chau')

insert into Proveedor(nombre,telefono)
values ('Arcor',45678948);
insert into Proveedor(nombre,telefono)
values ('Maxiconsumo',1245673);

insert into Producto(descripcion, peso,simbpeso,ID_prov)
values ('Arroz',1,'kg',1);
insert into Producto(descripcion, peso,simbpeso,ID_prov)
values ('Pure',500,'ml',1);
insert into Producto(descripcion, peso,simbpeso,ID_prov)
values ('Fideo',500,'gr',2);
insert into Producto(descripcion, peso,simbpeso,ID_prov)
values ('Caldo',15,'gr',2);

insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (1,123,100,16.50);
insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (2,123,100,12.50);
insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (3,123,100,10.25);
insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (4,123,100,3.50);

insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (1,70,100,16.50);
insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (2,70,100,12.50);
insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (3,70,100,10.25);
insert into Producto_Sucursal(Cod_art,ID_scr,cantidad,precio)
values (4,70,100,3.50);

insert into ModoPago(nombre)
values ('Efectivo');
insert into ModoPago(nombre)
values ('Tarjeta de Credito');
insert into ModoPago(nombre)
values ('Tarjeta de Debito');


insert into Venta(Ticket,monto,n_comp,ID_mp,fecha,ID_scr)
values (12345678901234,10005.50,0,1,GETDATE(),70);
insert into Venta(Ticket,monto,n_comp,ID_mp,fecha,ID_scr)
values (12345678911235,10005.50,12345678,2,GETDATE(),70);
insert into Venta(Ticket,monto,n_comp,ID_mp,fecha,ID_scr)
values (12345679212340,10005.50,12345678,3,GETDATE(),123);

insert into Detalle(Cod_art, descripcion, p_unidad, cantidad, total, Ticket) 
values(1,'Arroz 1kg',16.50,1,16.50,12345678901234);
insert into Detalle(Cod_art, descripcion, p_unidad, cantidad, total, Ticket) 
values(2,'Pure 500ml',12.50,1,12.50,12345678911235);
insert into Detalle(Cod_art, descripcion, p_unidad, cantidad, total, Ticket) 
values(3,'Fideo 500gr',10.25,1,10.25,12345679212340);

/*Selects*/
select * from Usuario;
select * from Empleado;
select * from Categoria;
select * from Producto_Sucursal;
select * from Sucursal;
select * from Producto;
select * from Proveedor;
select * from Venta;
select * from ModoPago;
select * from Detalle;


/*Contador*/

/*
Select COUNT(Cod_art) from Producto;
select P.Cod_art, P.descripcion, P.peso,P.simbpeso,PS.cantidad,PS.ID_scr from Producto P INNER JOIN Producto_Sucursal PS ON P.Cod_art = PS.Cod_art;
select PS.cantidad from Producto P inner join Producto_Sucursal PS on P.Cod_art = PS.Cod_art where P.Cod_art = 9 and PS.ID_scr =123;
select P.Cod_art, P.descripcion, P.peso,P.simbpeso,PS.cantidad,PS.ID_scr from Producto P INNER JOIN Producto_Sucursal PS ON P.Cod_art = PS.Cod_art;
update Producto_Sucursal set precio=15 where ID_scr = 123  and Cod_art= 1;
select Cod_art,descripcion,p_unidad,cantidad,total,Ticket from Detalle;
select Cod_art,descripcion,p_unidad,cantidad,total,Ticket from Detalle;
select P.descripcion,P.peso,P.simbpeso, PS.precio from Producto P inner join Producto_Sucursal PS on P.Cod_art = PS.Cod_art where P.Cod_art = 1 and PS.ID_scr = 123;
*/

/*Drops*/

/*
drop table Usuario;
drop table Empleado;
drop table Categoria;
drop table Producto_Sucursal;
drop table Detalle;
drop table Venta;
drop table Sucursal;
drop table Producto;
drop table Proveedor;
drop table ModoPago;
*/