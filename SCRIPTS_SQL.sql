/*  CREACION DE LA BASE DE DATOS**/
create table torneo
( torCodigo number not null,
torNombre varchar2(40) not null,
torModalidad varchar2(10) not null,
torFrecuencia varchar2(10) not null,
constraint pk_torneo primary key (torCodigo),
constraint ckc_torModalidad check (torModalidad in('infantil','juvenil','adultos')),
constraint ckc_torFrecuencia check (torFrecuencia in ('anual', 'semestral')),
constraint ckc_torCodigo check (torCodigo > 0)
);

create table ciudad
( ciuCodigo number not null,
ciuNombre varchar2(40) not null,
constraint pk_ciudad primary key (ciuCodigo),
constraint ckc_ciuCodigo check (ciuCodigo > 0)
);

create table karateca
( karatCodigo number not null,
karatNombre varchar2(40) not null,
karatApellido varchar2(40) not null,
karatPeso number(4,1) not null,
ciuCodigo number not null,
constraint pk_karateca primary key (karatCodigo),
constraint fk_karateca_ciudad_ciuCodigo foreign key (ciuCodigo) references ciudad (ciuCodigo),
constraint ckc_karatCodigo check (karatCodigo > 0),
constraint ckc_karatPeso check (karatPeso between 30 and 400)
);

create table participa
(
partFecha Date not null,
karatCodigo number not null,
torCodigo number not null,
constraint pk_participa primary key (partFecha),
constraint uq_participa unique (partFecha,torCodigo,karatCodigo),
constraint fk_participa_torneo foreign key(torCodigo) references torneo(torCodigo),
constraint fk_participa_karateca foreign key(karatCodigo) references karateca(karatCodigo)
);

/*INSERT INTO PARTICIPA(partFecha, karatCodigo,torCodigo)  VALUES(TO_DATE('{0} {1}', 'yyyy/mm/dd HH24:MI:SS'),{2},{3});*/
INSERT INTO PARTICIPA(partFecha, karatCodigo,torCodigo)  VALUES(TO_DATE('2020/03/22 18:19:57', 'yyyy/mm/dd hh24:mm:ss'),1,2);



/*ejEJEMPLO DE COMO SELECCIONAR LA HORA Y LA FECHA DEL CAMPO partFecha*/
SELECT TO_CHAR(partFecha, 'yyyy/mm/dd'), TO_CHAR(partFecha, 'hh24:mi:ss'), karatCodigo , torCodigo FROM participa;





/*CONSULTA 1*/
/*'''se mostrará TODA la información
de los Torneos de karate y Karatecas que han participado
en ellos junto con la fecha y hora participación.'''*/



select  KARATECA.karatCodigo as "CODIGO KARATECA" ,
        karatNombre AS "NOMBE KARATECA",
        karatNombre AS "APELLIDO KARATECA",
        karatPeso AS "PESO KARATECA",
        TORNEO.torCodigo AS "CODIGO TORNEO",
        torNombre AS "NOMBRE TORNEO",
        torModalidad AS "MODALIDAD",
        torFrecuencia AS "FRECUENCIA",
        TO_CHAR(partFecha, 'yyyy/mm/dd') AS "FECHA",
        TO_CHAR(partFecha, 'hh24:mi:ss') AS "HORA"
from karateca inner join participa on karateca.karatcodigo = participa.karatcodigo
inner join torneo on torneo.torcodigo = participa.karatcodigo;
/*CONSULTA 2*/
/*'''Buscar por fecha de participación: Se solicitará al usuario que ingrese (seleccione) la fecha de participación,
se desplegará
el nombre torneo, código, nombre, apellido del Karateca, nombre ciudad de donde es oriundo y hora participación.'''
//torneo,karateca,ciudad,participa*/
select  CIUDAD.ciuCodigo AS "CODIGO CIUDAD",
        ciuNombre AS "CIUDAD",
        KARATECA.karatCodigo as "CODIGO KARATECA" ,
        karatNombre AS "NOMBE CARATECA",
        karatNombre AS "APELLIDO KARATECA",
        karatPeso AS "PESO KARATECA",
        TORNEO.torCodigo AS "CODIGO TORNEO",
        torNombre AS "NOMBRE TORNEO",
        torModalidad AS "MODALIDAD",
        torFrecuencia AS "FRECUENCIA",
        TO_CHAR(partFecha, 'yyyy/mm/dd') AS "FECHA",
        TO_CHAR(partFecha, 'hh24:mi:ss') AS "HORA"
from ciudad inner join karateca on ciudad.ciucodigo = karateca.ciucodigo
inner join participa on participa.karatcodigo = karateca.karatcodigo
inner join torneo on torneo.torcodigo = participa.torcodigo
where TO_CHAR(participa.partFecha, 'yyyy/mm/dd') LIKE '2012/12/12';
/*CONSULTA 3*/
/*Consultar cuántos karatecas participaron en torneos de modalidad infantil en el año 2019.*/
 select count(karateca.karatcodigo) as "CANTIDAD" from karateca 
 inner join participa on karateca.karatcodigo = participa.karatcodigo 
 inner join torneo on torneo.torcodigo = participa.karatcodigo 
 where TORMODALIDAD= 'semestral' and extract (year from participa.partfecha) = 2019;
/*                  campo_dinamico                                          campo_dinamico                     

