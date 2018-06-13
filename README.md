# DmlBasesDeDatos1
Un programa en c# qe permita gestional el DML de una base de datos relacional de forma directa.
Descripción General: 
  En un Diplomado (código, nombre, horas de duración, modalidad) se registran
  de uno a muchos Estilistas (identificación, nombre, género, fecha de nacimiento). Un Estilista se
  registra en uno o varios diplomados en el tiempo, registrando así fecha inicio y fecha fin del
  diplomado.
Requerimientos:
  1. Gestionar Diplomado
    o Registrar Diplomado
    o Actualizar Diplomado
    o Eliminar Diplomado
  2. Gestionar Estilista
    o Registrar Estilista.
    o Actualizar Estilista.
    o Eliminar Estilista.
  3. Registrar la vinculación entre Diplomado y Estilista.
  4. Consultar Toda la Información: se mostrará TODA la información del Diplomado y de los
  Estilistas vinculados en ellas, junto con la fecha inicio y fin del Diplomado.
  5. Buscar por fecha de inicio Diplomado: Se solicitará al usuario que ingrese la fecha de inicio del
  Diplomado, se desplegará el código y nombre del Diplomado, identificación, nombre, género
  del Estilista y fecha fin del Diplomado.
  6. Consultar el número de Estilista que son de género masculino.
  Debe utilizar obligatoriamente los siguientes controles para los campos que se indican:
     Para los campos fecha usar el Date Time Picker.
     Modalidad: lista desplegable o combo box con la información presencial, semipresencial, virtual
     género: radio buttons con las opciones de femenino o masculino.
     Para mostrar la información del punto 4 y 5: utilizar una grilla.
     Tenga en cuenta las validaciones de los datos.
