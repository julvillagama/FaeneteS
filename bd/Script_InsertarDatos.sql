
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

	-- Inserta Registros
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Albaida', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alberique', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Albocácer', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alcoy', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Aldaia', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Algemesí', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante Mercantil I', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante Mercantil II', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante Mercantil III', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante Mercantil IV', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante 1', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante 2', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante 3', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante 4', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante 5', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante 7', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alicante 8', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Almoradí', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Altea', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alzira 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Alzira 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Aspe', NULL, NULL, NULL);  
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Benaguacil', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Benicarló', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Benidorm 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Benidorm 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Benidorm 3', NULL, NULL, NULL);  
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Benissa', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Burjassot', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Calpe', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Callosa de Ensarrià', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Callosa de Segura', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Carlet 1', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Carlet 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Castellón 1', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Castellón 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Castellón 3', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Castellón 4', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Castellón 5', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Cocentaina', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Cullera', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Chelva', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Chiva 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Chiva 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Denia 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Denia 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Dolores', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'El Campello', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Elche 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Elche 2', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Elche 3', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Elche 4', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Elche 5', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Elda 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Elda 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Enguera', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Gandía 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Gandía 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Gandía 3', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Gandía 4', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Guardamar del Segura', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Ibi', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Játiva 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Játiva  2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Javea 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Javea 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Jijona', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Liria', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Lucena del Cid', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Manises', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Massamagrell', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Moncada 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Moncada 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Monóvar', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Morella', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Novelda', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Nules 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Nules 2', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Nules 3', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Oliva', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Ontinyent', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Orihuela 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Orihuela 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Oropesa de Mar 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Oropesa de Mar 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Paterna  1', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Paterna  2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Pedreguer', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Pego', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Picasent 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Picasent 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Pilar de la Horadada', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'La Pobla de Vallbona', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Puçol', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Requena', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Sagunto 1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Sagunto 2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'San mateo', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'San Vicente del Raspeig', NULL, NULL, NULL);  
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Santa pola', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Segorbe', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Sueca', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Tavernes de Valldigna', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Torrent I', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Torrent II', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Torrent III', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Torrevieja I', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Torrevieja II', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Torrevieja III', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia Mercantil I', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia Mercantil II', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia Mercantil III', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia Mercantil IV', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia Mercantil V', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia Mercantil VI', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia I', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia II', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia III', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia IV', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia V', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia VI', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia VII', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia VIII', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia IV', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia X', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XI', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XII', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XIII', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XIV', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XV', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XVI', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XVII', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Valencia XVIII', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Villajoyosa  1', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Villajoyosa  2', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Villar del Arzobispo', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Villarreal I', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Villarreal II', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Villarreal III', NULL, NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Villena', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Vinaroz', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Viver', NULL, NULL, NULL); 
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, 'Xirivella', NULL, NULL, NULL); 

	-- Inserta Trabajadores
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, 'Alicia Villalmanzo Manrique', NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, 'Dolores Fernández Puerta', NULL, NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, 'Regina Martinez Vicente', NULL, NULL);

	-- Inserta Via
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, 'Correo', NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, 'E-Mail', NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, 'Fax', NULL);
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, 'Teléfono', NULL);

	-- Inserta Preparador
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, NULL, 'Paz Cucarella');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, NULL, 'Pedro Fandos');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, NULL, 'Fernando Miguel Vicente Faubel');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, NULL, 'José Miguel Laorden Arnao');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, NULL, 'Ana Llosa');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, NULL, 'Miren Monforte Duart');
INSERT INTO `configuracion` (`_id`, `registro`, `trabajador`, `via`, `preparador`) VALUES (NULL, NULL, NULL, NULL, 'Víctor Prado');


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








