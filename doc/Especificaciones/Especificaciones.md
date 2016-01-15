Versión: 1.0.3Gestión Administrativa en el Decanato de los Registros de la Propiedad de la Comunidad Valenciana
# FaeneteS #
Especificación de requisitos
Julio Villamón Gamarra

26-11-2015

## Contenido ##

- Introducción
- Propósito	
- Ámbito del Sistema	
- Definiciones	
- Acrónimos	
- Descripción General	
- Funciones del sistema	
- Gestión de las consultas que se reciben	
- Gestión de las quejas que se presentan	
- Gestión del correo postal	
- Gestión de llamadas institucionales	
- Gestión de entradas y salidas de especial relevancia	
- Gestión de la Academia de Opositores	
- Gestión de los actos organizados	
- Generación de informes	
- Características de los usuarios	
- Restricciones	
- Resumen	
- Requisitos Funcionales	
- Gestión de las consultas que se reciben	
	- R001. El usuario podrá dar de alta una consulta	
	- R002. El usuario podrá modificar una consulta	
	- R003. El usuario podrá eliminar una consulta existente	
	- R004. El usuario podrá consultar una consulta	
- Gestión de las quejas que se presentan	
	- R005. El usuario podrá dar de alta una queja	
	- R006. El usuario podrá modificar una queja	
	- R007. El usuario podrá eliminar una queja existente	
	- R008. El usuario podrá consultar una queja	
- Gestión del correo postal	
	- R009. El usuario podrá dar de alta un correo	
	- R010. El usuario podrá modificar un correo	
	- R01El usuario podrá eliminar un correo existente	
	- R012. El usuario podrá consultar un correo	
- Gestión de las llamadas institucionales	
	- R013. El usuario podrá dar de alta una llamada	
	- R014. El usuario podrá modificar una llamada	
	- R015. El usuario podrá eliminar una llamada existente	
	- R016. El usuario podrá consultar una llamada	
- Gestión de entradas y salidas de especial relevancia	
	- R017. El usuario podrá dar de alta una entrada o salida	
	- R018. El usuario podrá modificar una entrada o salida	
	- R019. El usuario podrá eliminar una entrada o salida existente	
	- R020. El usuario podrá consultar una entrada o salida	
- Gestión de la Academia de Opositores	
	- R02El usuario podrá dar de alta un trabajo de la academia	
	- R022. El usuario podrá modificar un trabajo de la academia	
	- R023. El usuario podrá eliminar un trabajo de la academia existente	
	- R024. El usuario podrá consultar un trabajo de la academia	
- Gestión de los actos organizados	
	- R025. El usuario podrá dar de alta un acto	
	- R026. El usuario podrá modificar un acto	
	- R027. El usuario podrá eliminar un acto existente	
	- R028. El usuario podrá consultar un acto	
- Generación de informes	
	- R029. El usuario podrá crear informes de correo	
	- R030. El usuario podrá crear informes de consultas	
	- R03El usuario podrá crear informes de quejas	
	- R032. El usuario podrá crear informes de llamadas institucionales	
- Requisitos Tecnológicos	
- [Tecnologías y Herramientas](#0) 
	- 1) Sistema Operativo Microsoft Windows 7	
	- 2) Entorno de Desarrollo Microsoft Visual Studio 2015	
	- 3) Base de Datos MariaDB	
	- 4) Suite Ofimática Microsoft Office 2013	
	- 5) Planificación de Proyectos Gantt Project	
	- 6) Diagramas UML ArgoUML	
	- 7) Diseño de Base de Datos MySQL Workbench	
	- 8) S.O. Servidor Debian 8	

 
## Introducción ##

Este documento es una especificación de los requisitos software para un gestor de trabajo administrativo en una oficina con tres secretarias de dirección

## Propósito ##

El objeto de la especificación es definir de manera clara y precisa todas las funcionalidades del sistema para que sirva como base en el desarrollo del software

## Ámbito del Sistema ##

Sigue el modelo de arquitectura cliente/servidor, el cual tendrá una base de datos centralizada en un servidor y varios clientes que leerán/escribirán en la base de datos
Definiciones
FaeneteS	Nombre de la aplicación

## Acrónimos ##


- RXXX	El estándar seguido para la especificación del identificador de cada requisito será de la siguiente forma:
	- R = Requisito
	- XXX = secuencia de tres dígitos que servirá para la enumeración de cada requisito


## Descripción General ##

Se presenta una descripción a alto nivel del sistema, enumerando las principales áreas de negocio a las cuales el sistema debe dar soporte: las funciones que debe realizar, la información utilizada, las restricciones y otros factores que afecten al desarrollo del mismo
Funciones del sistema
En términos generales, FaeneteS deberá proporcionar soporte a las siguientes tareas administrativas llevadas a cabo en la secretaría del Decanato del Colegio Nacional de Registradores en la Comunidad Valenciana:

- Gestión de las consultas que se reciben
- Gestión de las quejas que se presentan
- Gestión del correo postal
- Gestión de llamadas institucionales
- Gestión de entradas y salidas de especial relevancia 
- Gestión de la Academia de Opositores
- Gestión de los actos organizados
- Generación de informes

A continuación se describen con más detalle éstas tareas y cómo serán soportadas por el sistema

## Gestión de las consultas que se reciben ##

La oficina recibe consultas por parte de registradores, profesionales y particulares. Las recibe vía telefónica, por email, por correo postal o presencialmente en la oficina. Nos interesa mantener la siguiente información:
 
1.	Fecha
2.	Nombre de la persona que realiza la consulta 
3.	Motivo de la consulta
4.	Vía por la que llega la consulta (teléfono, email, correo, presencial)
5.	Respuesta dada (descripción de la solución)

## Gestión de las quejas que se presentan ##

La oficina tramita las posibles quejas que puedan tener los usuarios de los Registros de la Propiedad. Cuando el usuario presenta la queja, lo puede hacer de dos maneras:

-	Desde el propio Registro en el que no está conforme
-	Desde la secretaría del Decanato

Esto hace que la secretaría reciba la queja del usuario de dos modos posibles:

-	Recibida desde el Registro
-	Recibida por parte del usuario

Nos interesa mantener la siguiente información:

1.	Fecha
2.	Nombre del usuario que presenta la queja
3.	Queja
4.	Registro al que afecta
5.	Resolución de la queja

## Gestión del correo postal ##

La secretaría recibe y envía grandes cantidades de correo postal, aunque sólo se gestionará el correo entrante. Nos interesa mantener la siguiente información:

1.	Fecha
2.	Nombre del remitente
3.	Contenido del correo
4.	Nombre de la secretaria que lo gestiona
5.	Si es certificado o no lo es
6.	Estado actual de la gestión
7.	Si la gestión ha finalizado o no

## Gestión de llamadas institucionales ##

La oficina recibe ciertas llamadas de especial relevancia que se tienen que diferenciar del resto. Suelen ser llamadas de cargos públicos o instituciones. Nos interesa mantener la siguiente información:

1.	Fecha
2.	Nombre de la persona o institución
3.	Consulta

## Gestión de entradas y salidas de especial relevancia ##

Hay diversas gestiones que se deben etiquetar como entradas, salidas o ambas. Nos interesa mantener la siguiente información:

1.	Identificador
2.	Fecha
3.	Si es entrada
4.	Si es salida
5.	Procedencia (en caso de que sea una entrada)
6.	Destino (en caso de que sea una salida)
7.	Contenido
 
## Gestión de la Academia de Opositores ##

En el edificio donde se ubica la secretaría hay una academia de preparación al cuerpo de Registradores, tanto opositores como preparadores hacen uso –a veces- del material de la secretaría. Nos interesa mantener la siguiente información:

1.	Fecha
2.	Nombre del preparador
3.	Nombre del opositor
4.	Material que usa

## Gestión de los actos organizados ##

La secretaría organiza actos públicos y privados, tanto en las propias instalaciones del Decanato como en locales exteriores. Hay actos en los que se contrata un catering. Los motivos son variados: cursos, conferencias, mesas redondas…

Nos interesa mantener la siguiente información:

1.	Número de identificador
2.	Fecha
3.	Acto
4.	Lugar
5.	Nombre de la empresa de catering
6.	Nombre del menú
7.	Precio por persona
8.	Observaciones del servicio de catering

## Generación de informes ##

Las secretarias emiten informes con el trabajo realizado semanalmente que son remitidos a sus superiores. Los informes se deben generar automáticamente seleccionando las siguientes opciones:

1.	Correo recibido entre dos fechas (normalmente la última semana)
2.	Consultas realizadas entre dos fechas (normalmente la última semana)
3.	Quejas recibidas entre dos fechas (normalmente la última semana)
4.	Llamadas institucionales recibidas entre dos fechas (normalmente la última semana)

## Características de los usuarios ##

Los usuarios de este sistema están familiarizados con aplicaciones de ofimática Microsoft Windows y usan el sistema operativo de Microsoft Windows 7
Es por ello que el sistema ha de ser gráfico, con una interfaz sencilla e intuitiva, que no exija gran tiempo para su aprendizaje, a la vez que lo suficientemente potente para que el usuario pueda hacer aquello que necesita
Restricciones
El sistema será accedido por cualquier secretaria, pudiendo modificar la base de datos que comparten






## Resumen ##


#### Consultas que se reciben ####
	
1.	Fecha
2.	Nombre de la persona que realiza la consulta 
3.	Motivo de la consulta
4.	Vía por la que llega la consulta
5.	Respuesta dada 

#### Quejas que se presentan ####
	
1.	Fecha
2.	Nombre del usuario que presenta la queja
3.	Queja
4.	Registro al que afecta
5.	Resolución de la queja

#### Correo postal ####
	
1.	Fecha
2.	Nombre del remitente
3.	Contenido del correo
4.	Nombre de la secretaria que lo gestiona
5.	Si es certificado o no lo es
6.	Estado actual de la gestión
7.	Si la gestión ha finalizado o no

#### Llamadas institucionales ####
	
1.	Fecha
2.	Nombre de la persona o institución
3.	Consulta

#### Entradas y salidas de especial relevancia ####
	
1.	Identificador
2.	Fecha
3.	Si es entrada
4.	Si es salida
5.	Procedencia (en caso de que sea una entrada)
6.	Destino (en caso de que sea una salida)
7.	Contenido

#### Academia de Opositores ####
	
1.	Fecha
2.	Nombre del preparador
3.	Nombre del opositor
4.	Material que usa

#### Actos organizados ####
	
1.	Número de identificador
2.	Fecha
3.	Acto
4.	Lugar
5.	Nombre de la empresa de catering
6.	Nombre del menú
7.	Precio por persona
8.	Observaciones del servicio de catering

#### Informes ####
	
1.	Correo recibido entre dos fechas 
2.	Consultas realizadas entre dos fechas
3.	Quejas recibidas entre dos fechas 
4.	Llamadas institucionales recibidas entre dos fechas 

## Requisitos Funcionales ##

#### Gestión de las consultas que se reciben ####

R001. El usuario podrá dar de alta una consulta
Mediante una interfaz gráfica se le pedirán los datos correspondientes a cada consulta. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar el alta de la consulta y se comprobará que todos los campos son correctos y están todos rellenados

R002. El usuario podrá modificar una consulta
Mediante una interfaz gráfica se le permitirá seleccionar una consulta para modificar los datos que contenga. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar la modificación de la consulta y se comprobará que todos los campos son correctos y están todos rellenados. Antes de modificarla se le pedirá una confirmación

R003. El usuario podrá eliminar una consulta existente
Mediante una interfaz gráfica se le permitirá seleccionar una consulta para eliminarla. Antes de eliminarla se le pedirá una confirmación para que no elimine la consulta por error

R004. El usuario podrá consultar una consulta 
Mediante una interfaz gráfica obtendrá un listado con todas las consultas almacenadas a las que podrá acceder recorriéndolas todas o bien usando filtros por fecha, nombre que realiza la consulta, motivo de la consulta, vía por la que llega la consulta o respuesta dada. Además podrá hacer una ordenación por fecha

#### Gestión de las quejas que se presentan ####

R005. El usuario podrá dar de alta una queja
Mediante una interfaz gráfica se le pedirán los datos correspondientes a cada queja. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar el alta de la queja y se comprobará que todos los campos son correctos y están todos rellenados

R006. El usuario podrá modificar una queja
Mediante una interfaz gráfica se le permitirá seleccionar una queja para modificar los datos que contenga. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar la modificación de la queja y se comprobará que todos los campos son correctos y están todos rellenados. Antes de modificarla se le pedirá una confirmación

R007. El usuario podrá eliminar una queja existente
Mediante una interfaz gráfica se le permitirá seleccionar una queja para eliminarla. Antes de eliminarla se le pedirá una confirmación para que no elimine la queja por error

R008. El usuario podrá consultar una queja 
Mediante una interfaz gráfica obtendrá un listado con todas las quejas almacenadas a las que podrá acceder recorriéndolas todas o bien usando filtros por fecha, nombre que realiza la queja, motivo de la queja, registro al que afecta o resolución de la queja. Además podrá hacer una ordenación por fecha

#### Gestión del correo postal ####

R009. El usuario podrá dar de alta un correo
Mediante una interfaz gráfica se le pedirán los datos correspondientes a cada correo. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar el alta del correo y se comprobará que todos los campos son correctos y están todos rellenados

R010. El usuario podrá modificar un correo
Mediante una interfaz gráfica se le permitirá seleccionar un correo para modificar los datos que contenga. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar la modificación del correo y se comprobará que todos los campos son correctos y están todos rellenados. Antes de modificarlo se le pedirá una confirmación

R011. El usuario podrá eliminar un correo existente
Mediante una interfaz gráfica se le permitirá seleccionar un correo para eliminarlo. Antes de eliminarlo se le pedirá una confirmación para que no lo elimine por error

R012. El usuario podrá consultar un correo 
Mediante una interfaz gráfica obtendrá un listado con todas los correos almacenados a las que podrá acceder recorriéndolas todos o bien usando filtros por fecha, nombre del remitente, contenido del correo, nombre de la secretaria que lo gestiona, si es o no certificado, por el estado de la gestión o por si la gestión ha finalizado. Además podrá hacer una ordenación por fecha

#### Gestión de las llamadas institucionales ####

R013. El usuario podrá dar de alta una llamada
Mediante una interfaz gráfica se le pedirán los datos correspondientes a cada llamada. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar el alta de la llamada y se comprobará que todos los campos son correctos y están todos rellenados

R014. El usuario podrá modificar una llamada
Mediante una interfaz gráfica se le permitirá seleccionar una llamada para modificar los datos que contenga. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar la modificación de la llamada y se comprobará que todos los campos son correctos y están todos rellenados. Antes de modificarla se le pedirá una confirmación

R015. El usuario podrá eliminar una llamada existente
Mediante una interfaz gráfica se le permitirá seleccionar una llamada para eliminarla. Antes de eliminarla se le pedirá una confirmación para que no la elimine por error

R016. El usuario podrá consultar una llamada 
Mediante una interfaz gráfica obtendrá un listado con todas las llamadas almacenadas a las que podrá acceder recorriéndolas todas o bien usando filtros por fecha, por nombre de la persona o institución o por consulta. Además podrá hacer una ordenación por fecha

#### Gestión de entradas y salidas de especial relevancia ####

R017. El usuario podrá dar de alta una entrada o salida
Mediante una interfaz gráfica se le pedirán los datos correspondientes a cada entrada o salida. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar el alta de la entrada o salida y se comprobará que todos los campos son correctos y están todos rellenados
R018. El usuario podrá modificar una entrada o salida

Mediante una interfaz gráfica se le permitirá seleccionar una entrada o salida para modificar los datos que contenga. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar la modificación de la entrada o salida y se comprobará que todos los campos son correctos y están todos rellenados. Antes de modificarla se le pedirá una confirmación

R019. El usuario podrá eliminar una entrada o salida existente
Mediante una interfaz gráfica se le permitirá seleccionar una entrada o salida para eliminarla. Antes de eliminarla se le pedirá una confirmación para que no la elimine por error

R020. El usuario podrá consultar una entrada o salida
Mediante una interfaz gráfica obtendrá un listado con todas las entradas o salidas almacenadas a las que podrá acceder recorriéndolas todas o bien usando filtros por identificador, fecha, si es entrada o salida, por procedencia, por destino o por contenido. Además podrá hacer una ordenación por fecha

#### Gestión de la Academia de Opositores ####

R021. El usuario podrá dar de alta un trabajo de la academia
Mediante una interfaz gráfica se le pedirán los datos correspondientes a cada trabajo de la academia. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar el alta del trabajo de la academia y se comprobará que todos los campos son correctos y están todos rellenados

R022. El usuario podrá modificar un trabajo de la academia
Mediante una interfaz gráfica se le permitirá seleccionar un trabajo de la academia para modificar los datos que contenga. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar la modificación del trabajo de la academia y se comprobará que todos los campos son correctos y están todos rellenados. Antes de modificarlo se le pedirá una confirmación

R023. El usuario podrá eliminar un trabajo de la academia existente
Mediante una interfaz gráfica se le permitirá seleccionar un trabajo de la academia para eliminarlo. Antes de eliminarlo se le pedirá una confirmación para que no lo elimine por error

R024. El usuario podrá consultar un trabajo de la academia
Mediante una interfaz gráfica obtendrá un listado con todos los trabajos de la academia almacenados a los que podrá acceder recorriéndolos todas o bien usando filtros por fecha, nombre del preparador, nombre del opositor o material que usa. Además podrá hacer una ordenación por fecha

#### Gestión de los actos organizados ####

R025. El usuario podrá dar de alta un acto
Mediante una interfaz gráfica se le pedirán los datos correspondientes a cada acto. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar el alta del acto y se comprobará que todos los campos son correctos y están todos rellenados

R026. El usuario podrá modificar un acto
Mediante una interfaz gráfica se le permitirá seleccionar un acto para modificar los datos que contenga. Deberá completar de forma correcta e íntegra cada campo de información que se le pida. Una vez hecho esto, apretará el botón para realizar la modificación del acto y se comprobará que todos los campos son correctos y están todos rellenados. Antes de modificarlo se le pedirá una confirmación

R027. El usuario podrá eliminar un acto existente
Mediante una interfaz gráfica se le permitirá seleccionar un acto para eliminarlo. Antes de eliminarlo se le pedirá una confirmación para que no lo elimine por error

R028. El usuario podrá consultar un acto
Mediante una interfaz gráfica obtendrá un listado con todos los actos almacenados a los que podrá acceder recorriéndolos todos o bien usando filtros por identificador, por fecha, por acto, por lugar, por nombre de la empresa de catering, por nombre de menú, por precio por persona o por observaciones. Además podrá hacer una ordenación por fecha

#### Generación de informes ####

R029. El usuario podrá crear informes de correo
Mediante una interfaz gráfica se le permitirá seleccionar los datos que deben aparecer en el informe. Para éste informe debe aparecer la fecha, si es o no certificado, nombre del remitente y contenido del correo. El informe se generará en formato .pdf y se ofrecerá un explorador de archivos para guardarlo en el equipo del usuario

R030. El usuario podrá crear informes de consultas 
Mediante una interfaz gráfica se le permitirá seleccionar los datos que deben aparecer en el informe. Para éste informe debe aparecer la fecha, consulta y nombre del consultante. El informe se generará en formato .pdf y se ofrecerá un explorador de archivos para guardarlo en el equipo del usuario

R031. El usuario podrá crear informes de quejas
Mediante una interfaz gráfica se le permitirá seleccionar los datos que deben aparecer en el informe. Para éste informe debe aparecer la fecha, consulta, registro al que afecta, nombre del usuario y resolución. El informe se generará en formato .pdf y se ofrecerá un explorador de archivos para guardarlo en el equipo del usuario

R032. El usuario podrá crear informes de llamadas institucionales
Mediante una interfaz gráfica se le permitirá seleccionar los datos que deben aparecer en el informe. Para éste informe debe aparecer la fecha, nombre del contacto o institución y la consulta. El informe se generará en formato .pdf y se ofrecerá un explorador de archivos para guardarlo en el equipo del usuario

## Requisitos Tecnológicos ##

La aplicación deberá correr como mínimo en sistemas Windows 7, lo que exige una configuración mínima de:

- Procesador de 32 bits (x86) o 64 bits (x64) a 1 gigahercio (GHz) o más
- Memoria RAM de 1 GB (32 bits) o memoria RAM de 2 GB (64 bits)
- Espacio disponible en disco rígido de 16 GB (32 bits) o 20 GB (64 bits)
- Dispositivo gráfico DirectX 9 con controlador WDDM 1.0 o superior

<a name="0"></a>
## Tecnologías y Herramientas ##

1. Sistema Operativo:	Microsoft Windows 7
1. Entorno de Desarrollo:	Microsoft Visual Studio 2015
1. Base de Datos:	MariaDB
1. Suite Ofimática:	Microsoft Office 2013
1. Planificación de Proyectos:	Gantt Project 2.7.1
1. Diagramas UML:	ArgoUML v.034
1. Diseño de Base de Datos:	MySQL Workbench 6.3.5
1. S.O. Servidor:	Debian 8

**1) Sistema Operativo Microsoft Windows 7**

La principal pieza de software para el desarrollo es el sistema operativo, sobre él irán instaladas el resto de herramientas. FaeneteS se va a codificar en C# usando el IDE de Microsoft “Visual Studio 2015” el cual sólo se puede ejecutar en entornos Windows. Se usa la versión Windows 7 por ser el Sistema Operativo que se usa en el Decanato, aunque se podría haber usado perfectamente las versiones 8, 8.1 o 10

**2) Entorno de Desarrollo Microsoft Visual Studio 2015**

Éste IDE es el que más ha manejado el desarrollador cursando el ciclo, se usará el lenguaje C# (muy parecido a Java) y XAML (lenguaje de marcado para aplicaciones basado en XML) el cual hará que FaeneteS pueda correr en futuras versiones de Microsoft Windows. Se elige la versión 2015 por ser la actual en el momento de redactar éste documento

**3) Base de Datos MariaDB**
 
El proyecto necesita de un SGBD (Sistema de Gestión de Base de Datos). El Decanato dispone de un servidor con Windows Server 2003, pero no tiene instalado SQL Server, por lo que hace falta una licencia para poder usarlo.
Para evitar los costes se usará  MariaDB, que es un SGBD derivado de MySQL con licencia GPL

**4) Suite Ofimática Microsoft Office 2013**

Para generar la documentación se usará Word 2013, aunque se podría haber usado perfectamente la suite Libre Office, la elección de la suite de Microsoft se debe exclusivamente al conocimiento en su manejo, pues en el momento de redactar éste documento, el desarrollador está cursando un curso de Word 2013

**5) Planificación de Proyectos Gantt Project**

Para planificar el desarrollo se hace muy útil representarlo mediante diagrama de Gantt (gráfico de barras). Para automatizar la generación del diagrama se usa Gantt Project, con licencia GPL

**6) Diagramas UML ArgoUML**

Para modelar en UML los diferentes diagramas (casos de uso, clases…) se usa ArgoUML, con licencia GPL

**7) Diseño de Base de Datos MySQL Workbench**

Para el diseño visual de la base de datos se usa MySQL Workbench, con licencia GPL también

**8) S.O. Servidor Debian 8**

El sistema operativo en el servidor es una distribución de Debian 8 64-bit con entorno gráfico. La elección de Linux es principalmente por ahorrar costes en la licencia de un Windows Server. El desarrollador conoce el sistema por haberlo usado en equipos de escritorio. No se usa la versión server, por sencillez se instala un entorno gráfico con los paquetes necesarios para desplegar la base de datos. El servidor no se administrará remotamente, se conectará un monitor, teclado y ratón para manejarlo


