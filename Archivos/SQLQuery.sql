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
	simbpeso varchar(2) not null,
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
primary key(Ticket),
constraint fk_Venta_ModoPago_1
Foreign key (ID_mp) references ModoPago (ID_mp)
);

/*Inserts*/


insert into Sucursal(ID_scr,Nombre, Localidad)
values (123,'Dia','Ezeiza');
insert into Sucursal(ID_scr,Nombre, Localidad)
values (70,'Dias','Monte grande');

insert into Categoria(Nombre)
values ('sistema');
insert into Categoria(Nombre)
values ('administracion');

insert into Empleado(Legajo,Nombre,Apellido,ID_ct,ID_scr)
values (12345678,'Ramon','Gonzalez',1,123);
insert into Empleado(Legajo,Nombre,Apellido,ID_ct,ID_scr)
values (87654321,'Hector','Fiaz',2,70);

insert into Usuario(ID_user,Pass)
values(12345678,'hola');
insert into Usuario(ID_user,Pass)
values(87654321,'chau');

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

insert into Venta(Ticket,monto,n_comp,ID_mp)
values (12345678901234,10005.50,12345678,1);
insert into Venta(Ticket,monto,n_comp,ID_mp)
values (12345678911234,10005.50,12345678,2);
insert into Venta(Ticket,monto,n_comp,ID_mp)
values (1234567921234,10005.50,12345678,3);

/*Selects*/

select * from Empleado;
select * from Categoria;
select * from Usuario;
select * from Sucursal;
select * from Proveedor;
select * from Producto;
select * from Categoria;
select * from Producto_Sucursal;

/*Drops*/

/*
drop table Usuario;
drop table Empleado;
drop table  Sucursal;
drop table Categoria;
drop table Producto_Sucursal;
drop table Producto;
drop table Proveedor;
drop table ModoPago;
drop table Venta;
*/