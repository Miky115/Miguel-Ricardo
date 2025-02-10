DROP DATABASE IF EXISTS geopaxil;
CREATE DATABASE geopaxil;
USE geopaxil

CREATE TABLE ComunidadesAutonomas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    capital VARCHAR(100),
    poblacion INT,
    superficie_km2 DECIMAL(10,2)
);

CREATE TABLE Provincias (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    comunidad_id INT,
    capital VARCHAR(100),
    poblacion INT,
    superficie_km2 DECIMAL(10,2),
    FOREIGN KEY (comunidad_id) REFERENCES ComunidadesAutonomas(id)
);

CREATE TABLE Pueblos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    provincia_id INT,
    poblacion INT,
    codigo_postal VARCHAR(10),
    coordenadas_geograficas VARCHAR(50),
    FOREIGN KEY (provincia_id) REFERENCES Provincias(id)
);


INSERT INTO ComunidadesAutonomas (id, nombre, capital, poblacion, superficie_km2) VALUES
(1, 'Andalucía', 'Sevilla', 8414240, 87599.00),
(2, 'Aragón', 'Zaragoza', 1320794, 47720.00),
(3, 'Asturias', 'Oviedo', 1022800, 10603.00),
(4, 'Canarias', 'Las Palmas de Gran Canaria', 2221925, 7447.00),
(5, 'Cataluña', 'Barcelona', 7611107, 32114.00),
(6, 'Extremadura', 'Mérida', 1065374, 41733.00),
(7, 'Galicia', 'Santiago de Compostela', 2700330, 29574.00),
(8, 'Madrid', 'Madrid', 6640705, 8028.00),
(9, 'Murcia', 'Murcia', 1493898, 11314.00),
(10, 'Valencia', 'Valencia', 5003769, 23255.00),
(11,'Castilla y León', 'Valladolid', 2408081, 94409.00);

INSERT INTO Provincias (id, nombre, comunidad_id, capital, poblacion, superficie_km2) VALUES
(1, 'Almería', 1, 'Almería', 717820, 8776.00),
(2, 'Huesca', 2, 'Huesca', 219345, 15636.00),
(3, 'Asturias', 3, 'Oviedo', 1022800, 10603.00),
(4, 'Las Palmas', 4, 'Las Palmas de Gran Canaria', 1126738, 4065.00),
(5, 'Barcelona', 5, 'Barcelona', 5664579, 7722.00),
(6, 'Badajoz', 6, 'Badajoz', 691715, 21766.00),
(7, 'Lugo', 7, 'Lugo', 333663, 9856.00),
(8, 'Madrid', 8, 'Madrid', 6640705, 8028.00),
(9, 'Murcia', 9, 'Murcia', 1493898, 11314.00),
(10, 'Valencia', 10, 'Valencia', 2550298, 10807.00),
(11,'Málaga', 1, 'Málaga', 1661788, 7306.00),
(12,'Córdoba', 1, 'Córdoba', 791610, 13771.00),
(13,'Teruel', 2, 'Teruel', 138686, 14809.00),
(14,'Zamora', 11, 'Zamora', 172539, 10561.00),
(15,'León', 11, 'León', 470904, 15580.00),
(16,'Salamanca', 11, 'Salamanca', 331314, 12349.00);


INSERT INTO Pueblos (id, nombre, provincia_id, poblacion, codigo_postal, coordenadas_geograficas) VALUES
(1, 'Roquetas de Mar', 1, 198533, '04001', '36.8386° N, 2.4679° W'),
(2, 'Jaca', 2, 52342, '22001', '42.1395° N, 0.4087° W'),
(3, 'Oviedo', 3, 220567, '33001', '43.3624° N, 5.8448° W'),
(4, 'Telde', 4, 378517, '35001', '28.1235° N, 15.4363° W'),
(5, 'Sant Cugat del Vallès', 5, 90000, '08172', '41.4686° N, 2.0865° E'),
(6, 'Mérida', 6, 58000, '06800', '38.9161° N, 6.3437° W'),
(7, 'Monforte de Lemos', 7, 19564, '27400', '42.5253° N, 7.5139° W'),
(8, 'Alcalá de Henares', 8, 195943, '28801', '40.4819° N, 3.3642° W'),
(9, 'Caravaca de la Cruz', 9, 26000, '30400', '38.0962° N, 1.8593° W'),
(10, 'Xàtiva', 10, 29207, '46800', '38.9897° N, 0.5228° W'),
(11,'Aguadulce', 1, 37757, '04720', '36.7584° N, 2.5860° W'),
(12,'Vícar', 1, 26562, '04738', '36.7719° N, 2.6132° W'),
(13,'Sabiñánigo', 2, 10797, '22600', '42.5170° N, 0.3566° W'),
(14,'Canfranc', 2, 446, '22880', '42.7152° N, 0.5239° W'),
(15,'Benavente', 11, 18604, '49600', '42.0026° N, 5.6750° W'),
(16,'Toro', 11, 9162, '49800', '41.5225° N, 5.3969° W');

SELECT * FROM ComunidadesAutonomas;
SELECT * FROM Provincias;
SELECT * FROM Pueblos;

CREATE USER 'usu_paxil' IDENTIFIED BY '12345678';
GRANT ALL PRIVILEGES ON geopaxil.* TO 'usu_paxil'@'%';
