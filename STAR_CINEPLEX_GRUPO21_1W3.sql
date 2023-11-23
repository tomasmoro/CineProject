USE MASTER
CREATE DATABASE STAR_CINEPLEX_GRUPO21_1W3
GO
USE STAR_CINEPLEX_GRUPO21_1W3
GO

--------------------------------------TABLA 1: ACTORES --------------------------------------
CREATE TABLE ACTORES
(	id_actor int,
	nombre varchar (60),
	apellido varchar(60)

CONSTRAINT pk_actor PRIMARY KEY (id_actor)
)
GO
--------------------------------------TABLA 2: CATEGORIAS --------------------------------------
CREATE TABLE CATEGORIAS
(	id_categoria int,
	descripcion varchar (60)

CONSTRAINT pk_categoria PRIMARY KEY (id_categoria)
)
GO
--------------------------------------TABLA 3: DIRECTORES --------------------------------------
CREATE TABLE DIRECTORES
(	id_director int,
	nombre varchar (60),
	apellido varchar(60)

CONSTRAINT pk_director PRIMARY KEY (id_director)
)
GO
--------------------------------------TABLA 4: GENEROS --------------------------------------

CREATE TABLE GENEROS
(	id_genero int,
	descripcion varchar (60)

CONSTRAINT pk_genero PRIMARY KEY (id_genero)
)
GO
--------------------------------------TABLA 5: PELICULAS --------------------------------------
CREATE TABLE PELICULAS
(	id_pelicula int,
	pelicula varchar (70),
	sinopsis varchar(365),
	fecha_estreno datetime,
	imagen varchar(200),
	duracion time

CONSTRAINT pk_pelicula PRIMARY KEY (id_pelicula)
)
GO
--------------------------------------TABLA 6: PELICULAS ACTORES (intermedia) --------------------------------------
CREATE TABLE PELICULAS_ACTORES
(	id_pelicula int,
	id_actor int

CONSTRAINT fk_pelicula_actor FOREIGN KEY (id_pelicula)
REFERENCES PELICULAS (id_pelicula),

CONSTRAINT fk_actor FOREIGN KEY (id_actor)
REFERENCES ACTORES (id_actor)
)
GO
--------------------------------------TABLA 7: PELICULAS CATEGORIAS (intermedia) --------------------------------------
CREATE TABLE PELICULAS_CATEGORIAS
(	id_pelicula int,
	id_categoria int

CONSTRAINT fk_pelicula_categoria FOREIGN KEY (id_pelicula)
REFERENCES PELICULAS(id_pelicula),

CONSTRAINT fk_categoria FOREIGN KEY (id_categoria)
REFERENCES CATEGORIAS (id_categoria)
)
GO
--------------------------------------TABLA 8: PELICULAS ACTORES (intermedia) --------------------------------------
CREATE TABLE PELICULAS_DIRECTORES
(	id_pelicula int,
	id_director int

CONSTRAINT fk_pelicula_director FOREIGN KEY (id_pelicula)
REFERENCES PELICULAS(id_pelicula),

CONSTRAINT fk_director FOREIGN KEY (id_director)
REFERENCES DIRECTORES (id_director)
)
GO
--------------------------------------TABLA 9: PELICULAS GENEROS (intermedia) --------------------------------------
CREATE TABLE PELICULAS_GENEROS
(	id_pelicula int,
	id_generos int

CONSTRAINT fk_pelicula_genero FOREIGN KEY (id_pelicula)
REFERENCES PELICULAS(id_pelicula),

CONSTRAINT fk_generos FOREIGN KEY (id_generos)
REFERENCES GENEROS (id_genero)
)
GO
--------------------------------------TABLA 10: LENGUAJES --------------------------------------
CREATE TABLE LENGUAJES
(	id_lenguaje int,
	lenguaje varchar(70)

CONSTRAINT pk_lenguaje PRIMARY KEY (id_lenguaje)
)
GO
--------------------------------------TABLA 11: TIPOS_SALAS --------------------------------------
CREATE TABLE TIPOS_SALAS
(	id_tipo_sala int,
	tipo_sala varchar(70)

CONSTRAINT pk_id_tipo_sala PRIMARY KEY (id_tipo_sala)
)
GO
--------------------------------------TABLA 12: SALAS --------------------------------------
CREATE TABLE SALAS
(	nro_sala int,
	id_tipo_sala int,
	cantidad_butacas int

CONSTRAINT pk_sala PRIMARY KEY(nro_sala),

CONSTRAINT fk_tipo_sala FOREIGN KEY (id_tipo_sala)
REFERENCES TIPOS_SALAS (id_tipo_sala)
)
GO
--------------------------------------TABLA 13: FUNCIONES --------------------------------------
CREATE TABLE FUNCIONES
(	id_funcion int identity(1,1),
	nro_sala int,
	id_pelicula int,
	fecha datetime,
	id_lenguaje int,
	precio_gral money

CONSTRAINT pk_funcion PRIMARY KEY (id_funcion),

CONSTRAINT fk_nro_sala_funcion FOREIGN KEY (nro_sala)
REFERENCES SALAS (nro_sala),

CONSTRAINT fk_pelicula_funcion FOREIGN KEY (id_pelicula)
REFERENCES PELICULAS (id_pelicula),

CONSTRAINT fk_lenguaje_funcion FOREIGN KEY (id_lenguaje)
REFERENCES LENGUAJES (id_lenguaje),
)
GO
--------------------------------------TABLA 14: BUTACAS_SALAS --------------------------------------
CREATE TABLE BUTACAS_SALAS
(	id_butaca_sala int IDENTITY(1,1),
	fila int,
	asiento int,
	nro_sala int
	
CONSTRAINT pk_butaca_sala PRIMARY KEY(id_butaca_sala),

CONSTRAINT fk_nro_sala_butaca_sala FOREIGN KEY (nro_sala)
REFERENCES SALAS (nro_sala)
)
GO
--------------------------------------TABLA 15: PROMOCIONES_CODIGO --------------------------------------
CREATE TABLE PROMOCIONES_CODIGO
(	id_promocion_codigo int,
	porcentaje int,
	descripcion varchar (200),
	estaActivo bit
	
CONSTRAINT pk_promocion_codigo PRIMARY KEY(id_promocion_codigo),
)
GO
--------------------------------------TABLA 16: PROMOCIONES_EDAD --------------------------------------
CREATE TABLE PROMOCIONES_EDAD
(	id_promocion_edad int,
	porcentaje int,
	descripcion varchar (200),
	
CONSTRAINT pk_promocion_edad PRIMARY KEY(id_promocion_edad),
)
GO
--------------------------------------TABLA 17: BARRIOS --------------------------------------
CREATE TABLE BARRIOS
(	id_barrio int,
	barrio varchar (150),
	
	
CONSTRAINT pk_barrio PRIMARY KEY(id_barrio),
)
GO
--------------------------------------TABLA 18: CLIENTES --------------------------------------
CREATE TABLE CLIENTES
(	id_cliente int,
	nombre varchar (150),
	apellido varchar (150),
	fecha_nacimiento datetime,
	mail varchar (150),
	telefono VARCHAR(10),
	id_barrio int
	
CONSTRAINT pk_cliente PRIMARY KEY (id_cliente),

CONSTRAINT fk_barrio_cliente FOREIGN KEY(id_barrio)
REFERENCES BARRIOS (id_barrio)
)
GO
--------------------------------------TABLA 19: VENDEDORES --------------------------------------
CREATE TABLE VENDEDORES
(	id_vendedor int,
	nombre varchar (150),
	apellido varchar (150),
	fecha_nacimiento datetime,
	mail varchar (150),
	constraseña varchar (20),
	telefono VARCHAR(10),
	id_barrio int
	
CONSTRAINT pk_vendedor PRIMARY KEY (id_vendedor),

CONSTRAINT fk_barrio_vendedor FOREIGN KEY(id_barrio)
REFERENCES BARRIOS (id_barrio)
)
GO
--------------------------------------TABLA 20: FORMAS DE PAGO --------------------------------------
CREATE TABLE FORMAS_PAGO
(	id_forma_pago int,
	forma_pago varchar (200),
	
	
CONSTRAINT pk_forma_pago PRIMARY KEY(id_forma_pago)
)
GO
--------------------------------------TABLA 21: COMPROBANTES --------------------------------------
CREATE TABLE COMPROBANTES
(	id_comprobante int IDENTITY(1,1),
	fecha datetime,
	id_vendedor int,
	id_forma_pago int,
	id_cliente int,
	id_funcion int
	
	
CONSTRAINT pk_comrpobante PRIMARY KEY(id_comprobante),

CONSTRAINT fk_vendedor FOREIGN KEY(id_vendedor)
REFERENCES VENDEDORES (id_vendedor),

CONSTRAINT fk_forma_pago FOREIGN KEY(id_forma_pago)
REFERENCES FORMAS_PAGO (id_forma_pago),

CONSTRAINT fk_cliente FOREIGN KEY(id_cliente)
REFERENCES CLIENTES (id_cliente),

CONSTRAINT fk_funcion FOREIGN KEY(id_funcion)
REFERENCES FUNCIONES (id_funcion),
)
GO
--------------------------------------TABLA 22: PRODUCTOS --------------------------------------
CREATE TABLE PRODUCTOS
(	id_producto int,
	descripcion varchar (200),
	precio money,
	peso float
	
CONSTRAINT pk_producto PRIMARY KEY(id_producto),
)
GO
--------------------------------------TABLA 23: DETALLES_PRODCUTO --------------------------------------
CREATE TABLE DETALLES_PRODUCTO
(	id_detalle int,
	id_producto int,
	cantidad int,
	total money,
	id_comprobante int
	
CONSTRAINT pk_detalle PRIMARY KEY(id_detalle),

CONSTRAINT fk_producto FOREIGN KEY (id_producto)
REFERENCES PRODUCTOS (id_producto),

CONSTRAINT fk_det_pro_comprobante FOREIGN KEY (id_comprobante)
REFERENCES COMPROBANTES (id_comprobante)
)
GO
--------------------------------------TABLA 24: TICKETS -------------------------------------
CREATE TABLE TICKETS
(	id_ticket int identity (1,1),
	id_butaca_sala int,
	id_comprobante int,
	total money,
	id_promocion_codigo int,
	id_promocion_edad int,
	leido bit
	
CONSTRAINT pk_ticket PRIMARY KEY(id_ticket),

CONSTRAINT fk_butaca_sala FOREIGN KEY (id_butaca_sala)
REFERENCES BUTACAS_SALAS (id_butaca_sala),

CONSTRAINT fk_ticket_comprobante FOREIGN KEY (id_comprobante)
REFERENCES COMPROBANTES (id_comprobante),

CONSTRAINT fk_promocion_codigo FOREIGN KEY (id_promocion_codigo)
REFERENCES PROMOCIONES_CODIGO (id_promocion_codigo),

CONSTRAINT fk_promocion_edad FOREIGN KEY (id_promocion_edad)
REFERENCES PROMOCIONES_EDAD (id_promocion_edad)

)
GO

------------------------------------------------------------------------------------------------------------
-- INSERTS—----------------------------------------------------------------------------------------
SELECT * FROM PELICULAS
GO
SET DATEFORMAT 'YMD'
GO
INSERT INTO PELICULAS (ID_PELICULA, PELICULA, SINOPSIS, FECHA_ESTRENO, IMAGEN, DURACION)
VALUES
(1, 'Harry Potter', 'Una emocionante historia de magia', '2023-05-01 18:30:00', 'https://static.wikia.nocookie.net/esharrypotter/images/3/35/Harry_Potter_y_el_Prisionero_de_Azkaban_%28DVD%29.png/revision/latest?cb=20110208175552', '02:15:00'),
(2, 'ATENTADO EN EL AIRE', 'Un avión secuestrado se estrellará en sólo 97 minutos cuando se le acabe el combustible.', '2023-11-12 18:30:00', 'https://www.citicinemas.com/_next/image?url=https%3A%2F%2Fstorage.googleapis.com%2Fciticinemas-store%2FMovie-1635%2Fposter%2FIKe6hLxcoQhw%2Fatentado.jpg&w=1920&q=75', '02:00:00'),
(3, 'LOS ASESINOS DE LA LUNA', 'Basada en el elogiado bestseller de David Grann.', '2023-11-12 18:30:00','https://sm.ign.com/t/ign_es/gallery/k/killers-of/killers-of-the-flower-moon-key-art_5eke.1080.jpg', '02:05:00'),
(4, 'EL JUSTICIERO 3', 'Desde que renunció a su vida como asesino del gobierno, ha luchado por reconciliarse con las horribles cosas que hizo en el pasado.', '2023-11-14 18:30:00', 'https://micartelera.com.ar/images/peliculas/poster/El-justiciero-3-Poster-1-900x1125.jpg', '02:15:00'),
(5, 'THE MARVELS', 'Este trío improbable deberá formar equipo y aprender a trabajar en conjunto para salvar el universo como THE MARVELS.', '2023-11-22 18:30:00', 'https://www.cinemascomics.com/wp-content/uploads/2023/07/cartel-de-the-Marvels.jpg', '02:02:00'),
(6, 'NAPOLEON', 'Napoleón es una epopeya de acción llena de espectáculo que detalla el accidentado ascenso y caída del emperador Napoleón Bonaparte.', '2023-11-06 18:30:00', 'https://hips.hearstapps.com/hmg-prod/images/napoleon-poster-64ad1c570c536.jpg', '02:30:00'),
(7,'LOS JUEGOS DEL HAMBRE','Muchos años antes de convertirse en Presidente de Panem, el joven Coriolanus Snow es elegido mentor del Distrito 12 en los nuevos Juegos del Hambre.','2023-10-30','https://pics.filmaffinity.com/Los_juegos_del_hambre_Balada_de_paajaros_cantores_y_serpientes-875832940-large.jpg','02:38:00'),
(8,'AVATAR 2','Jake y Neytiri han formado una familia y hacen todo por permanecer juntos. Pero deben abandonar su hogar y explorar  Pandora ante una antigua amenaza.','2023-11-06','https://pics.filmaffinity.com/Avatar-208925608-large.jpg','03:12:00'),
(9,'BARBIE','Después de ser expulsada de Barbieland por no ser una muñeca de aspecto perfecto, Barbie parte hacia el mundo humano para encontrar la verdadera felicidad.','2023-07-20','https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTVvWRrRBvB7-m4KPNnIvhmU7CkDrRmetnS-fN9bWil2s-VtklG','01:54:00');
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--GENEROS 

SELECT * FROM GENEROS

INSERT INTO GENEROS(id_genero, descripcion)
VALUES 
(1, 'SUSPENSO'),
(2, 'DRAMA'),
(3, 'ACCION'),
(4, 'COMEDIA'),
(5, 'AVENTURA'),
(6, 'CIENCIA FICCION');
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--ACTORES
select * from ACTORES
INSERT INTO ACTORES(id_actor, nombre, apellido)
VALUES
(1, 'Leonardo', 'Di Caprio'),
(2, 'Alec', 'Baldwin'),
(3, 'Denzel', 'Washington'),
(4, 'Brie', 'Larson'),
(5, 'Joaquin', 'Phoenix'),
(6, 'Rachel ', 'Zegier'), 
(7, 'Sam', 'Worthington'), 
(8, 'Margot', 'Robbie'),   
(9, 'Ryan', 'Gosling');
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- CATEGORIAS
select * from CATEGORIAS
INSERT INTO CATEGORIAS(id_categoria, descripcion)
VALUES
(1, 'ATP (apta para todo publico)'),
(2, '+13 (mayores de trece años de edad)'),
(3, '+17 (mayores de diecisiete años de edad)');
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--DIRECTORES
select * from DIRECTORES
INSERT INTO DIRECTORES(id_director, nombre, apellido)
VALUES 
(1, 'Antonie', 'Fuqua'),
(2, 'Timo', 'Vuorensola'),
(3, 'Martin', 'Scorsese'),
(4, 'Nia Da', 'Costa'),
(5, 'Ridley', 'Scott'),
(6, 'Francis', 'Lawrence'),
(7, 'James', 'Cameron'),
(8, 'Greta', 'Gerwig');
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--PELICULAS_DIRECTORES
select * from PELICULAS_DIRECTORES
INSERT INTO PELICULAS_DIRECTORES(id_director, id_pelicula)
VALUES
(1,1),
(1,4),
(2,2),
(3,3),
(4,5),
(5,6),
(6,7),
(7,8),
(8,9);
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--PELICULAS_ACTORES

INSERT INTO PELICULAS_ACTORES(id_actor, id_pelicula)
VALUES
(1,1),
(1,3),
(2,2),
(3,4),
(4,5),
(5,5),
(6,7),
(7,8),
(8,9),
(9,9);
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--PELICULAS_CATEGORIAS
INSERT INTO PELICULAS_CATEGORIAS(id_categoria, id_pelicula)
VALUES
(1,1),
(2,2),
(2,5),
(3,3),
(3,4),
(3,6),
(3,7),
(1,8),
(2,9);
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--PELICULAS_GENEROS

INSERT INTO PELICULAS_GENEROS(id_generos, id_pelicula)
VALUES
(1,2),
(2,1),
(2,3),
(3,4),
(3,5),
(3,6),
(3,7),
(6,7),
(3,8),
(5,8),
(6,8),
(4,9);
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--TIPOS_SALAS
select * from TIPOS_SALAS
INSERT INTO TIPOS_SALAS(id_tipo_sala, tipo_sala)
VALUES
(1,'2D'),
(2,'3D');
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--SALAS
select * from SALAS
INSERT INTO SALAS(nro_sala, id_tipo_sala, cantidad_butacas)
VALUES
(1, 1, 56),
(2, 2, 56);
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- BUTACAS_SALAS
select * from BUTACAS_SALAS
INSERT INTO BUTACAS_SALAS(nro_sala,fila,asiento)
VALUES
(1,0,1),
(1,0,2),
(1,0,3),
(1,0,4),
(1,0,5),
(1,0,6),

(1,1,0),
(1,1,1),
(1,1,2),
(1,1,3),
(1,1,4),
(1,1,5),
(1,1,6),

(1,2,0),
(1,2,1),
(1,2,2),
(1,2,3),
(1,2,4),
(1,2,5),
(1,2,6),

(1,3,0),
(1,3,1),
(1,3,2),
(1,3,3),
(1,3,4),
(1,3,5),
(1,3,6),		

(1,4,0),
(1,4,1),
(1,4,2),
(1,4,3),
(1,4,4),
(1,4,5),
(1,4,6),	

(1,5,0),
(1,5,1),
(1,5,2),
(1,5,3),
(1,5,4),
(1,5,5),
(1,5,6),	

(1,6,0),
(1,6,1),
(1,6,2),
(1,6,3),
(1,6,4),
(1,6,5),
(1,6,6),	

(1,7,0),
(1,7,1),
(1,7,2),
(1,7,3),
(1,7,4),
(1,7,5),
(1,7,6);
GO
select * from BUTACAS_SALAS
INSERT INTO BUTACAS_SALAS(nro_sala,fila,asiento)
VALUES
(2,0,1),
(2,0,2),
(2,0,3),
(2,0,4),
(2,0,5),
(2,0,6),

(2,1,0),
(2,1,1),
(2,1,2),
(2,1,3),
(2,1,4),
(2,1,5),
(2,1,6),

(2,2,0),
(2,2,1),
(2,2,2),
(2,2,3),
(2,2,4),
(2,2,5),
(2,2,6),

(2,3,0),
(2,3,1),
(2,3,2),
(2,3,3),
(2,3,4),
(2,3,5),
(2,3,6),		

(2,4,0),
(2,4,1),
(2,4,2),
(2,4,3),
(2,4,4),
(2,4,5),
(2,4,6),	

(2,5,0),
(2,5,1),
(2,5,2),
(2,5,3),
(2,5,4),
(2,5,5),
(2,5,6),	

(2,6,0),
(2,6,1),
(2,6,2),
(2,6,3),
(2,6,4),
(2,6,5),
(2,6,6),	

(2,7,0),
(2,7,1),
(2,7,2),
(2,7,3),
(2,7,4),
(2,7,5),
(2,7,6);	
GO
-------------------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- LENGUAJES
select * from LENGUAJES
INSERT INTO LENGUAJES(id_lenguaje,lenguaje)
VALUES
(1, 'ESPAÑOL'),
(2,'INGLES');
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--FUNCIONES
select * from FUNCIONES
INSERT INTO FUNCIONES(id_lenguaje,id_pelicula,precio_gral,nro_sala,fecha)
VALUES
(1,6,3000,1,'2023/11/30 22:15'),
(2,6,4000,2,'2023/11/30 22:15'),
(1,4,3000,1,'2023/11/30 16:45'),
(2,4,4000,2,'2023/11/25 16:15'),
(1,5,3000,1,'2023/11/23 22:15'),
(2,5,4000,2,'2023/11/21 16:15'),
(1,6,3000,1,'2023/11/21 23:15'),
(2,6,4000,2,'2023/11/20 18:15'),
(1,6,3000,1,'2023/11/30 11:20'),

(1,7,3000,1,'2023/11/28 11:30'),
(2,7,3000,1,'2023/11/28 15:00'),
(2,8,3000,1,'2023/11/28 18:45'),
(2,8,3000,1,'2023/11/28 22:30'),
(1,8,3000,2,'2023/11/28 20:00'),
(2,9,3000,2,'2023/11/27 16:15'),
(1,9,3000,1,'2023/11/27 16:45');
GO
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--FORMAS PAGO
 select * from FORMAS_PAGO
INSERT INTO FORMAS_PAGO(id_forma_pago,forma_pago)
VALUES
(1,'TRANSFERENCIA BANCARIA'),
(2,'DEBITO'),
(3,'CREDITO'),
(4,'EFECTIVO');
GO
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--PRODUCTOS
select * from PRODUCTOS
INSERT INTO PRODUCTOS(id_producto, descripcion, precio, peso)
VALUES
(1,'PURURU MEDIANO (BOLSA)', 400, null),
(2,'PURURU GRANDE (BOLSA)', 500, null),
(3,'PURURU CHICO (BOLSA)', 300, null),
(4,'PURURU (BALDE)', 800, null),
(5,'GASEOSA MEDIANA', 400, null),
(6,'GASEOSA CHICA', 300, null),
(7,'GASEOSA GRANDE', 500, null),
(8,'GASEOSA BOTELLA (500ML)', 800, null),
(9,'CERVEZA MEDIANA (LATA)', 900, null),
(10,'CERVEZA GRANDE (LATA)', 1000, null),
(12,'NACHOS MEDIANO', 1000, null),
(13,'NACHOS GRANDES', 1500, null),
(14,'CHOCOLATE MEDIANO (BLOCK)', 500, null);
GO
---------------------------------------------
--BARRIOS
select * from BARRIOS
INSERT INTO BARRIOS(id_barrio,barrio)
VALUES
(1,'CENTRO'),
(2,'CERRO DE LAS ROSAS'),
(3,'NUEVA CORDOBA'),
(4,'ALTA CORDOBA'),
(5,'ALTO ALBERDI'),
(6,'SAN VICENTE'),
(7,'LAS PALMAS'),
(8,'LAS FLORES'),
(9,'GENERAL PAZ');
GO
---------------------------------------------
--CLIENTES
select * from CLIENTES
INSERT INTO CLIENTES(id_cliente,id_barrio,nombre,apellido,fecha_nacimiento,mail,telefono)
VALUES
(1,1,'VALENTINO','RAGONESE','2002/06/12','CHINO@GMAIL.COM',351686),
(2,1,'VALENTINA','RAYITO','2000/07/24','CHINA@GMAIL.COM',351532),
(3,8,'SOFIA','MARTINEZ','1987/09/01','SOFINAYELEGANTE@GMAIL.COM',355768),
(4,7,'FABRICIO','COLOCCINI','1982/01/22','FABRINEWCASTLE@GMAIL.COM',351449),
(6,2,'MIRTHA','LEGRAND','1927/02/23','IAMINEVITABLE@GMAIL.COM',118982),

(9,3,'LUCAS','GARCIA','2002-06-20','FRANCO@GMAIL.COM',354876),
(10,4,'VALENTINO','TESTA','2002-06-20','FRANCO@GMAIL.COM',354876),
(11,5,'FLORENCIA','MORO','2002-06-20','FRANCO@GMAIL.COM',354876),
(12,5,'TOBIAS','MORENO','2002-06-20','FRANCO@GMAIL.COM',354876),
(7,7,'ANDREA','GOMEZ','2002-06-20','FRANCO@GMAIL.COM',354876),
(8,6,'MAURICIO','POCHETTINO','2002-06-20','FRANCO@GMAIL.COM',354876),
(15,9,'LUCIA','VÁZQUEZ','2002-06-20','FRANCO@GMAIL.COM',354876);
GO
---------------------------------------------
--VENDEDORES

INSERT INTO VENDEDORES(id_vendedor,nombre,apellido,fecha_nacimiento,mail,constraseña,telefono,id_barrio)
VALUES
(405704,'MARCOS','MORELLI','2001/08/08','MARCOS@HOTMAIL.COM','123',351686,3),
(305423,'LIONEL','MESSI','2001/07/08','TOMO@HOTMAIL.COM','qwert123',351487,7),
(405729,'MARIANO','GEORGETTI','1990/08/08','MARIANETE@HOTMAIL.COM','FACU2023',354420,4),
(401825,'JORGE','RIAL','1961/10/16','JORGERIALOK@GMAIL.COM','BAJATE JAVI',354189,9);
GO
-----------------------------------------------------------------------------------------
select * from COMPROBANTES
INSERT INTO COMPROBANTES(FECHA, id_vendedor, id_forma_pago, id_cliente, id_funcion)
VALUES
('2023/11/15',405704,1,1,1),
('2023/11/12',405704,2,1,4),
('2023/10/15',305423,1,1,5),
('2023/11/02',305423,2,2,2),
('2023/10/10',305423,1,2,1),
('2023/10/20',401825,3,3,1),
('2023/11/11',405729,3,1,2),
('2023/10/30',401825,1,2,1),
('2023/09/29',405729,2,4,2),
('2023/09/12',405704,3,3,2),

('2023/11/15',405704,1,9,1),
('2023/11/12',405704,2,10,4),
('2023/10/15',405704,1,9,5),
('2023/11/02',305423,2,12,2),
('2023/10/10',405704,1,15,1),
('2023/10/20',305423,3,12,1),
('2023/11/11',405729,3,11,2),
('2023/10/30',305423,1,10,1),
('2023/09/29',305423,2,12,2),
('2023/09/12',305423,3,12,2);
GO
-----------------------------------------------------------------------------------------------------------------
--TICKETS
select * from TICKETS
INSERT INTO TICKETS(id_butaca_sala, id_comprobante, total, id_promocion_codigo, id_promocion_edad,leido)
VALUES
(10,5,12000,NULL,NULL,1),
(11,5,10000,NULL,NULL,1),
(12,3,4000,NULL,NULL,1),
(20,3,5500,NULL,NULL,1),
(21,4,12000,NULL,NULL,1),
(6,5,3000,NULL,NULL,1),

(4,7,12000,NULL,NULL,1),
(2,6,10000,NULL,NULL,1),
(3,8,4000,NULL,NULL,1),
(5,9,5500,NULL,NULL,1),
(15,9,12000,NULL,NULL,1),
(32,10,3000,NULL,NULL,1),
(34,11,12000,NULL,NULL,1),
(39,12,10000,NULL,NULL,1),
(45,13,4000,NULL,NULL,1),
(46,14,5500,NULL,NULL,1),
(21,15,12000,NULL,NULL,1),
(22,16,3000,NULL,NULL,1);
GO
-------------------------------------------------

------------------------------------------------------------------------------------------------------
select * from DETALLES_PRODUCTO
INSERT INTO DETALLES_PRODUCTO(id_detalle,id_producto,cantidad,total,id_comprobante)
VALUES
(1,3,2,400,3),
(2,4,2,800,3),
(3,4,1,500,11),
(4,2,4,1300,7),
(5,1,2,800,9),
(6,1,3,1200,4),
(7,6,2,600,4);
-----------------------------------------------------------------------------------------------------------------
GO

-------A CONTINUACIÓN SE MOSTRARÁN LOS SP-------
---------------------- SP1:INGRESAR CLIENTES----------------------
CREATE PROCEDURE [dbo].[SP_INGRESAR_CLIENTES]
@id_cliente int,
@nombre varchar (150),
@apellido varchar (150),
@fecha_nacimiento datetime,
@mail varchar (150),
@telefono VARCHAR(10)
AS
BEGIN 
	INSERT INTO CLIENTES(id_cliente,nombre,apellido,fecha_nacimiento,mail,telefono)
	VALUES
	(@id_cliente,
	 @nombre,
	 @apellido,
	 @fecha_nacimiento,
	 @mail,
	 @telefono
	 )
END;
go

----------------------SP2: CONSULTAR BARRIOS----------------------
CREATE PROCEDURE SP_CONSULTAR_BARRIOS
AS
BEGIN
SELECT * FROM BARRIOS
ORDER BY 2
END;
go

----------------------SP3: CONSULTAR PELICULAS----------------------
create procedure SP_OBTENER_PELICULAS
AS
SELECT * FROM PELICULAS
go
----------------------SP4: PRODUCTOS MÁS VENDIDOS----------------------
CREATE PROCEDURE SP_PRODUCTOS_MAS_VENDIDOS
AS
	SELECT p.id_producto 'id', p.descripcion 'Descripción', COUNT(id_detalle) 'Cantidad'
	FROM DETALLES_PRODUCTO dp
	JOIN productos p ON dp.id_producto = p.id_producto
	JOIN COMPROBANTES c ON c.id_comprobante = dp.id_comprobante
	WHERE year(c.fecha) = year(GETDATE())
	AND MONTH(c.fecha) = month(getdate())
	GROUP BY p.id_producto , p.descripcion
	ORDER BY 3;
go
---------------SP5:OBTENER BUTACAS DISPONIBLES----------------
CREATE PROCEDURE [dbo].[SP_OBTENER_BUTACAS_DISPONIBLES]
    @id_funcion int,
    @id_sala int
AS
    SELECT bs.asiento 'asiento', bs.fila 'fila', bs.id_butaca_sala 'id', 'OCUPADO' estado
    FROM BUTACAS_SALAS bs WHERE bs.nro_sala = @id_sala
    AND bs.id_butaca_sala in(SELECT bs1.id_butaca_sala FROM COMPROBANTES c1 
    JOIN TICKETS t1 ON c1.id_comprobante = t1.id_comprobante
    JOIN BUTACAS_SALAS bs1 ON bs1.id_butaca_sala = t1.id_butaca_sala
    WHERE c1.id_funcion = @id_funcion
    )
    UNION
    SELECT 
    bs.asiento , bs.fila , bs.id_butaca_sala, 'DESOCUPADO'
    FROM BUTACAS_SALAS bs WHERE bs.nro_sala = @id_sala
    AND bs.id_butaca_sala not in(SELECT bs1.id_butaca_sala FROM COMPROBANTES c1 
    JOIN TICKETS t1 ON c1.id_comprobante = t1.id_comprobante
    JOIN BUTACAS_SALAS bs1 ON bs1.id_butaca_sala = t1.id_butaca_sala
    WHERE c1.id_funcion = @id_funcion)
GO
------------SP6: OBTENER FUNCIONES POR PELÍCULA---------------
	CREATE PROC SP_OBTENER_FUNCIONES_BY_PELICULA
	@id_pelicula int,
	@id_tipo_sala int
	AS
	SELECT f.id_funcion 'id', f.fecha 'fecha', f.precio_gral 'precio_gral', s.nro_sala 'nro_sala',
	 s.id_tipo_sala 'id_tipo_sala', ts.tipo_sala 'tipo_sala', l.id_lenguaje 'id_lenguaje', l.lenguaje 'lenguaje'
	FROM funciones f
	JOIN LENGUAJES l ON l.id_lenguaje = f.id_lenguaje
	JOIN SALAS s ON s.nro_sala = f.nro_sala AND id_tipo_sala = @id_tipo_sala
	JOIN TIPOS_SALAS ts ON ts.id_tipo_sala = s.id_tipo_sala
	WHERE f.id_pelicula = @id_pelicula
	ORDER BY f.fecha;
go
----------------------SP7: TIPOS POR FUNCIÓN-----------------
	CREATE PROC sp_obtener_tipos_por_funcion
	@id_pelicula int 
	AS
	SELECT DISTINCT
		ts.id_tipo_sala 'id_tipo_sala',
		ts.tipo_sala 'tipo_sala'
	FROM peliculas p
	JOIN FUNCIONES f ON p.id_pelicula = f.id_funcion
	JOIN salas s ON s.nro_sala = f.nro_sala
	JOIN TIPOS_SALAS ts ON ts.id_tipo_sala = s.id_tipo_sala
	WHERE p.id_pelicula = @id_pelicula;
go
----------------------SP8: OBTENER CLIENTES----------------------
	CREATE PROC sp_obtener_clientes
	AS
	SELECT * FROM CLIENTES;
go
----------------------SP9: ID BUTACA----------------------
CREATE PROC OBTENER_BUTACA
@fila int,
@asiento int, 
@sala int,
@id int output

AS BEGIN
SET @id = 0
SELECT @id = B.id_butaca_sala 
FROM BUTACAS_SALAS B
WHERE B.fila = @fila
AND B.asiento = @asiento
AND B.nro_sala = @sala
END;
go
----------------------SP10: MOSTRAR VENDEDORES----------------------
CREATE PROC SP_MOSTRAR_VENDEDORES
AS 
BEGIN
SELECT *
FROM VENDEDORES
END;
go
----------------------SP11: MOSTRAR FORMAS DE PAGO----------------------
CREATE PROC SP_MOSTRAR_FORMAS_PAGO
AS
BEGIN
SELECT *
FROM FORMAS_PAGO
END;
go

----------SP12: INSERTAR DETALLES DE TICKET----------------
CREATE PROC [dbo].[SP_INSERTAR_COMPROBANTES]

	@vendedor int,
	@forma_pago int,
	@cliente int,
	@funcion int,
	@next int output
AS 
BEGIN

INSERT INTO COMPROBANTES
(fecha, id_vendedor, id_forma_pago, id_cliente, id_funcion)
VALUES
(
GETDATE(),
@vendedor,
@forma_pago,
@cliente,
@funcion
) 

SET @next = SCOPE_IDENTITY()
END;

go

----------------------SP13: MOSTRAR CLIENTES----------------------
CREATE PROC [dbo].sp_obtener_clientes_by_id @id int
 AS
BEGIN
 SELECT * FROM CLIENTES where id_cliente = @id;
END;
go
----------------------SP14: ACTUALIZAR CLIENTES----------------------
CREATE PROCEDURE ActualizarCliente
    @IDCliente INT,
    @NuevoNombre VARCHAR(50),
    @NuevoCorreo VARCHAR(50)
    -- Agrega más parámetros según sea necesario
AS
BEGIN
    UPDATE Clientes
    SET Nombre = @NuevoNombre,
        mail = @NuevoCorreo
    -- Actualiza más campos según sea necesario
    WHERE id_barrio = @IDCliente;
END;
go
----------------------SP15: BORRAR CLIENTES----------------------
CREATE PROCEDURE SP_BORRAR_CLIENTE
    @IdCliente INT
AS
BEGIN
    DELETE FROM Clientes
    WHERE id_cliente = @IdCliente;
END;
go
----------------------SP16: INICIAR SESIÓN---------------------- 
CREATE PROC [dbo].[SP_LOGIN]
@idusuario int,
@clave varchar (15),
@bool bit output
AS 
BEGIN
Set @bool = 0
declare @clave_real varchar(15)

SELECT @clave_real = constraseña FROM VENDEDORES
WHERE id_vendedor = @idusuario

If @clave_real = @clave
BEGIN

set @bool = 1
END 
END;
go
---------------------SP17: UPDATE_CLIENTE--------------------- 
CREATE PROCEDURE [dbo].[sp_Update_Cliente]
    @IdCliente INT,
    @NuevoNombre VARCHAR(50),
	@NuevoApellido VARCHAR (150),
    @NuevoCorreo VARCHAR(50),
	@NuevaFecha DATETIME,
	@NuevoTel VARCHAR(10)
AS
BEGIN
    UPDATE Clientes
    SET nombre = @NuevoNombre,
	    apellido = @NuevoApellido,
        mail = @NuevoCorreo,
		fecha_nacimiento = @NuevaFecha,
		telefono = @NuevoTel
    WHERE id_cliente = @IdCliente;
END;
GO
---------------------SP18: INSERTAR_TICKET--------------------
CREATE PROC [dbo].[SP_INSERTAR_TICKET]
@butaca_sala int,
@comprobante int,
@total money
AS 
BEGIN

INSERT INTO TICKETS (id_butaca_sala, id_comprobante, total)
VALUES
(@butaca_sala,
@comprobante,
@total
)
END;
GO
---------SP 18: REPORTE DE CLIENTES---------
create proc SP_RPT_CLIENTES
	@descripcion varchar(50) = '',
	@dni int = 0
	as
	begin
				SELECT C.NOMBRE+' '+C.APELLIDO 'NOMBRE COMPLETO',
					C.mail 'CONTACTO',
					SUM(T.total) 'MONTO GASTADO',
					COUNT(T.id_ticket) 'CANTIDAD DE ENTRADAS'
				FROM CLIENTES C
				JOIN COMPROBANTES COM ON C.id_cliente = COM.id_cliente
				JOIN TICKETS T ON COM.id_comprobante = T.id_ticket
				WHERE (@descripcion != '' and (C.NOMBRE LIKE '%'+@descripcion+'%' or C.Apellido LIKE '%'+@descripcion+'%' )) or
					(@dni != 0 and c.id_cliente = @dni) or
					(@dni = 0 and @descripcion = '')
				GROUP BY C.NOMBRE+' '+C.APELLIDO ,C.mail 
				order by 3 desc
END