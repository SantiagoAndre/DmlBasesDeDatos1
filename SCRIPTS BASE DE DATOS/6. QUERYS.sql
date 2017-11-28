select convert(char, estFechaNacimiento, 100) FROM ESTILISTA;

SELECT DIPLOMADO.dipId, dipNombre, dipHorasDuracion,dipModalidad, ESTILISTA.estId, estNombre, estGenero, estFechaNacimiento, regFechaInicio, regFechaFin
 FROM (DIPLOMADO  INNER JOIN REGISTRA 
 ON DIPLOMADO.dipId = REGISTRA.dipId) INNER JOIN ESTILISTA 
 ON ESTILISTA.estId = REGISTRA.estId
 ORDER BY DIPLOMADO.dipId;
 SELECT * FROM REGISTRA;

SELECT DIPLOMADO.dipId, dipNombre, ESTILISTA.estId,estNombre, estGenero, regFechaFin
FROM  (DIPLOMADO  INNER JOIN REGISTRA 
 ON DIPLOMADO.dipId = REGISTRA.dipId) INNER JOIN ESTILISTA 
 ON ESTILISTA.estId = REGISTRA.estId
 WHERE  DateDiff(dd, regFechaInicio, '01/01/2012') = 0;

SELECT COUNT(*)
FROM ESTILISTA
WHERE estGenero like 'F';