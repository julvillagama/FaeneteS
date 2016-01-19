
USE `faenetesDB`;

-- Inserta en tabla `academia`

INSERT INTO `faenetesDB`.`academia` (`_id`, `fecha`, `preparador`, `opositor`, `material`) VALUES (NULL, '2016-01-08', 'Pedro Fandos', 'Fernando Fos', 'Folios');
INSERT INTO `faenetesDB`.`academia` (`_id`, `fecha`, `preparador`, `opositor`, `material`) VALUES (NULL, '2015-10-10', 'Paz Cucarella', 'Victoria Herrera', 'Fotocopias');
INSERT INTO `faenetesDB`.`academia` (`_id`, `fecha`, `preparador`, `opositor`, `material`) VALUES (NULL, '2016-01-15', 'Víctor Prado', 'Almudena Jover', 'Programa');
INSERT INTO `faenetesDB`.`academia` (`_id`, `fecha`, `preparador`, `opositor`, `material`) VALUES (NULL, '2016-01-09', 'Ana Llosa', 'Juan Vilanova', 'Folios');


-- Inserta en tabla `actos`

INSERT INTO `actos` (`_id`, `fecha`, `acto`, `lugar`, `empresaCatering`, `nombreMenu`, `precioPersona`, `observaciones`) 
VALUES (NULL, '2015-12-12', 'Entrega medalla al mérito profesional', 'Salón de Actos Decanato', 'Catering cinco S.L', 'Menú Básico', 10, 'Se prueba el menú básico para ver si es bueno');

INSERT INTO `actos` (`_id`, `fecha`, `acto`, `lugar`, `empresaCatering`, `nombreMenu`, `precioPersona`, `observaciones`) 
VALUES (NULL, '2016-01-17', 'Jornada Ausbanc Hipoteca', 'Salón de Actos Decanato', 'Catering Hotel Excelsior', 'Menú Albufera', 11.5, 'Probamos el catering por recomendación de Adrián Jareño');

INSERT INTO `actos` (`_id`, `fecha`, `acto`, `lugar`, `empresaCatering`, `nombreMenu`, `precioPersona`, `observaciones`) 
VALUES (NULL, '2016-01-03', 'Mesa Redonda "Desaucios"', 'Salón de Actos Decanato', 'Catering Hotel Excelsior', 'Menú Albufera', 11.5, 'Repetimos con Excelsior');


-- Inserta en tabla `configuracion`

INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 1', 'Regina Martinez Vicente', 'Fax', 'Pedro Fandos');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 2', 'Alicia Villalmanzo Manrique', 'E-Mail', 'Ana Llosa');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 3', 'Dolores Fernández Puerta', 'Teléfono', 'Víctor Prado');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 4', NULL, 'Correo', 'Paz Cucarella');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 5', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 6', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 7', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 8', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 9', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 10', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 11', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia 12', NULL, NULL, NULL);


-- Inserta en tabla `consultas`

INSERT INTO `consultas` (`_id`, `fecha`, `nombre`, `consulta`, `via`, `respuesta`) VALUES (NULL, '2016-01-11', 'Manuel Fiz Company', 'Honorarios aranceles', 'Teléfono', 'Se resuelve en el acto');
INSERT INTO `consultas` (`_id`, `fecha`, `nombre`, `consulta`, `via`, `respuesta`) VALUES (NULL, '2016-01-12', 'Andrés Calabuig Moreno', 'Horario Decanato', 'E-Mail', 'En el acto, por el mismo medio');
INSERT INTO `consultas` (`_id`, `fecha`, `nombre`, `consulta`, `via`, `respuesta`) VALUES (NULL, '2016-01-13', 'Cristina Marivent Bordiu', 'Nota Simple', 'Fax', 'Se le resuelve telefónicamete ');
INSERT INTO `consultas` (`_id`, `fecha`, `nombre`, `consulta`, `via`, `respuesta`) VALUES (NULL, '2016-01-14', 'Manuela Morcillo Martínez', 'Legalización de Firma', 'Correo', 'Respondido por el mismo medio');


-- Inserta en tabla `correo`

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-18', 1, 0, 0, 'Antonio Melero Fernández', 'Carta al conseller de vivienda', 'Conselleria de Vivienda', 'Alicia Villalmanzo Manrique', 'En espera', 0);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-17', 1, 0, 0, 'Julian Espada Fuerza', 'Acta de toma de posesion y entrega a interino', 'Registro Massamagrell', 'Regina Martinez Vicente', 'Archivado carpeta massamagrell', 0);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2015-01-16', 0, 1, 0, 'Miranda Cidia López', 'Agradecimiento recepción llei hipotecària', 'Conselleria de Vivienda', 'Dolores Fernández Puerta', 'En espera', 0);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-15', 0, 0, 1, 'Patronato fundaciones', 'Acuse de recibo', 'Conselleria de Vivienda', 'Alicia Villalmanzo Manrique', 'En espera', 0);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2015-01-15', 1, 0, 0, 'Colegio graduados sociales', 'Convenio', 'Museo del prado', 'Regina Martinez Vicente', 'Archivado', 1);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-15', 0, 1, 0, 'Universidad de Valencia', 'Diplomas curso de arbitraje', 'Colegio de Titulares Mercantiles', 'Alicia Villalmanzo Manrique', 'Archivado', 1);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-14', 0, 0, 1, 'Caja Madrid', 'Diplomas curso de arbitraje', 'Colegio de Registradores', 'Dolores Fernández Puerta', 'Remitida por e-mail a la decana', 0);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2014-01-14', 0, 1, 0, 'Usuaria Registro Gandia 3', 'Memoria 2014', 'Revista Impuestos', 'Dolores Fernández Puerta', 'Remitida por e-mail a la decana', 0);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-14', 0, 1, 0, 'Generali seguros', 'Licencia vacaciones', 'Registro de Sueca', 'Regina Martinez Vicente', 'Archivado', 1);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-13', 1, 0, 0, 'T. Systems', 'Acuse de recibo', 'Colegio Notarial Baleares', 'Regina Martinez Vicente', 'Archivado', 1);

INSERT INTO `correo` (`_id`, `fecha`, `darEntrada`, `darSalida`, `certificado`, `nombreRemite`, `contenido`, `destino`, `personaSeguimiento`, `estadoGestion`, `finalizado`) 
VALUES (NULL, '2016-01-12', 1, 0, 0, 'Fundacion Broseta', 'Escrito para la decana', 'Registro de Gandia nº 3', 'Alicia Villalmanzo Manrique', 'Remitido a la decana', 0);


-- Inserta en tabla `llamadas`

INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-15', 'Sonia Lucas Mínguez', 'Quiere hablar con la decana');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-14', 'Alicia tsj. Pia calderon', 'Quiere hablar con la decana');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-13', 'Francesc Gamero', 'Retraso hora reunion');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2015-09-13', 'Conselleria de infraestructuras', 'Concertar reunion');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-16', 'Subdirector general de los reg. y notariado', 'Concertar reunion');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2015-04-07', 'Ayuntamiento de segorbe', 'Migracion bt-movistar');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-05', 'Asuncion Rausell', 'Quiere hablar con el dep. de prensa');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2015-04-08', 'Secretario del Colegio', 'Quiere hablar con el dep. de prensa');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-17', 'Usuaria que puso queja sin identificar', 'Factura i+d');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-15', 'Fundaciones', 'Factura i+d');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2015-07-18', 'Paloma consejo de camaras', 'Retraso hora reunion');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-01', 'Secretaria autonomica de hacienda', 'Quiere hablar con la decana');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-09', 'Gabinete de presidencia', 'Retraso hora reunion');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2014-11-23', 'Rne', 'Retraso hora reunion');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2014-03-28', 'Conselleria hacienda (Teresa Gadea)', 'Quiere hablar con la decana');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-11', 'Secretaria de Carmen Longares', 'Retraso hora reunion');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-07', 'D. Javier Vallejo (secretaria)', 'Quiere hablar con la decana');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2015-03-23', 'Las provincias. Jose m. Ortuño', 'Factura i+d');
INSERT INTO `llamadas` (`_id`, `fecha`, `nombre`, `consulta`) VALUES (NULL, '2016-01-03', 'Television valenciana. Jose montesinos', 'Quiere hablar con la decana');


-- Inserta en tabla `quejas`

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-14', 'Amadeo Navarro Gironés', 'Queja', 'Denia 1', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-12', 'Juan Selva Gallego', 'Queja', 'Valencia 10', 'Se remite a la decana');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-04', 'Amadeo Navarro Gironés', 'Consulta', 'Picassent 2', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-09', 'Susana Cortés Valiente', 'Consulta', 'Alicante 4', 'Se remite a la decana');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-02', 'Juan Selva Gallego', 'Queja', 'Albaida', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2014-11-14', 'Susana Cortés Valiente', 'Queja', 'Sagunto 2', 'Se remite a la decana');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2014-10-24', 'Vicente Bondia Lluesma', 'Consulta', 'Massamagrell', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2015-09-16', 'Amadeo Navarro Gironés', 'Consulta', 'Carlet 2', 'Se remite a la decana');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2014-02-24', 'Susana Cortés Valiente', 'Queja', 'Denia 1', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2015-03-17', 'Gestimed Formalización Levante', 'Consulta', 'Valencia 10', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-03', 'Susana Cortés Valiente', 'Queja', 'Denia 1', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-04', 'Vicente Bondia Lluesma', 'Consulta', 'Albaida', 'Se remite a la decana');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2014-05-04', 'Gestimed Formalización Levante', 'Queja', 'Picassent 2', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2015-08-18', 'Gestimed Formalización Levante', 'Queja', 'Denia 1', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2016-01-04', 'Gestimed Formalización Levante', 'Queja', 'Albaida', 'Se remite a la decana');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2014-07-24', 'Vicente Bondia Lluesma', 'Consulta', 'Picassent 2', 'Se remite a la vocal de consumidores');

INSERT INTO `quejas` (`_id`, `fecha`, `nombre`, `queja`, `registro`, `resolucion`) 
VALUES (NULL, '2015-06-13', 'Amadeo Navarro Gironés', 'Queja', 'Valencia 10', 'Se remite a la decana');








