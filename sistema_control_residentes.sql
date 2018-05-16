create database sistema_control_residentes;
use sistema_control_residentes;

create table asesores(
	id_asesor			int			primary key		auto_increment,
    usuario				varchar(50) unique			not null,
    pass				varchar(50) not null,
    nombre				varchar(60)	not null,
    apellido_paterno	varchar(60)	not null,
    apellido_materno	varchar(60)	not null,
    email				varchar(80) not null,
    telefono			varchar(10)	not null
);

insert into asesores values(null, 'JohannesFS', 'V@3sDothrak117', 'Johannes', 'Guzmán', 'Pito', 'johannes_fs@gmail.com', '4451407057');
insert into asesores values(null, 'Judelka_117', 'Bitfrost@117', 'Judith', 'Guzmán', 'Mora', 'judelka_stormbreaker@gmail.com', '4451083741');

select * from asesores where usuario like 'JohannesFS';

drop table alumnos;

create table alumnos(
	matricula			char(9)		primary key,
    usuario				varchar(50)	unique	not null,
    pass				varchar(50) not null,
    nombre				varchar(60)	not null,
    apellido_paterno	varchar(60)	not null,
    apellido_materno	varchar(60) not null,
    email				varchar(80)	not null,
    telefono			varchar(10)	not null,
    estatus				enum('Liberado', 'No liberado'),
    idAsesor			int			not null,
    constraint fk_asesor foreign key(idAsesor) references asesores(id_asesor)
);


create table coordinador(

id_coordinador			int			primary key		auto_increment,
    usuario				varchar(50) unique			not null,
    pass				varchar(50) not null,
    nombre				varchar(60)	not null,
    apellido_paterno	varchar(60)	not null,
    apellido_materno	varchar(60)	not null,
    email				varchar(80) not null,
    telefono			varchar(10)	not null



);

create table empresa(
id_empresa int primary key auto_increment,
rfc varchar(10) not null,
nombre_empresa varchar(50) not null,
ciudad varchar(30) not null,
fax varchar(10) not null,
mision varchar (70) not null,
colonia  varchar(30) not null,
cp varchar(5) not null,
direccion varchar(50),
tel varchar(10)
);


create table proyecto(

id_proyecto int primary key auto_increment,
lugar varchar(9) not null,
fecha varchar(9) not null,
noResidente varchar(9) not null,
nombres_proyecto varchar(25),
periodo varchar(30) not null

);

insert into alumnos values('S15120003', 'John117', '12345', 'Juan Carlos', 'Guzmán', 'Pito', 'S15120003@alumnos.itsur.edu.mx', '4451180319', 'No liberado', 1);
insert into alumnos values('S15120001', 'aaron_rocks', '12345', 'Aaron', 'Mercado', 'Hurtado', 'S15120001@alumnos.itsur.edu.mx', '4451003461', 'No liberado', 1);
insert into alumnos values('S15120002', 'Boyso666', '12345', 'José', 'Magaña', 'Boyso', 'S15120002@alumnos.itsur.edu.mx', '4451196720', 'No liberado', 2);

select * from alumnos;

select * from alumnos where idAsesor = 1;

select * from alumnos where matricula like 'S15120003';

describe alumnos;

drop table observaciones;

create table observaciones(
	id_observacion		int			primary key		auto_increment,
    fecha				char(10)	not null,
    descripcion			text		not null,
    id_asesor			int			not null,
    matricula			char(9)		not null,
    constraint fk_asesor_obs foreign key(id_asesor) references asesores(id_asesor),
    constraint fk_alumno_obs foreign key(matricula) references alumnos(matricula)
);

select * from observaciones;


