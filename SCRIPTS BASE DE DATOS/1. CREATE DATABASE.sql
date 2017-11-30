CREATE TABLE DIPLOMADO
(
	dipId Integer not null,
	dipNombre NCHAR(100) not null,
	dipHorasDuracion Int  not null,
	dipModalidad NCHAR(16) not null,
	CONSTRAINT pk_diplomado PRIMARY KEY (dipId),
	CONSTRAINT ckc_dipModalidad CHECK (dipModalidad in ( 'presencial', 'semipresencial', 'virtual')),
);

CREATE TABLE ESTILISTA
(
	estId Integer not null,
	estNombre NCHAR(40) not null,
	estGenero NCHAR(1) not null,
	estFechaNacimiento DATE not null,
	CONSTRAINT pk_estilista PRIMARY KEY (estId),
	CONSTRAINT ckc_estGenero CHECK (estGenero in ('f','m','o'))
);

CREATE TABLE REGISTRA
(
	estId INT not null,
	dipId INT not null,
	regFechaInicio DATE not null,
	regFechaFin DATE,
	CONSTRAINT pk_registra PRIMARY KEY (estId,dipId,regFechaInicio,regFechaFin),
	CONSTRAINT fk_estReg FOREIGN KEY (estId) REFERENCES ESTILISTA(estId),
	CONSTRAINT fk_dipReg FOREIGN KEY (dipId) REFERENCES DIPLOMADO(dipId),

);
