-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-09-2024 a las 15:47:50
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tienda_miguel_serbatic`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id`, `nombre`, `descripcion`) VALUES
(1, 'Cojines y almohadas', 'Productos decorativos y funcionales para agregar comodidad y estilo a sofÃ¡s, camas y otros muebles.'),
(2, 'Alfombras y tapetes', 'Una variedad de alfombras para diferentes áreas de la casa, desde el salón hasta el dormitorio y el baño.'),
(3, 'Iluminacion', 'Lámparas de mesa, de pie, de techo y otros accesorios de iluminación para agregar luz y ambiente a cualquier espacio.'),
(4, 'Textiles para el hogar', 'Productos textiles como cortinas, visillos, mantas, cojines y otros accesorios para decorar y mejorar la comodidad en el hogar.'),
(5, 'Decoracion de pared', 'Cuadros decorativos, espejos, relojes de pared y otros elementos para añadir personalidad y estilo a las paredes.'),
(6, 'Accesorios de cocina y comedor', 'Vajillas, cuberterías, utensilios de cocina, candelabros y otros accesorios para la cocina y el comedor.'),
(7, 'Organizacion y almacenamiento', 'Productos para organizar y almacenar diversos elementos del hogar, como cestas, cajas y organizadores.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `configuracion`
--

CREATE TABLE `configuracion` (
  `id` int(11) NOT NULL,
  `clave` varchar(255) DEFAULT NULL,
  `valor` varchar(255) DEFAULT NULL,
  `tipo` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `configuracion`
--

INSERT INTO `configuracion` (`id`, `clave`, `valor`, `tipo`) VALUES
(1, NULL, '56', NULL),
(2, 'nombre_empresa', 'CasaDecor', NULL),
(3, 'direccion', 'Calle falsa 123', NULL),
(4, 'cif', 'A1234567', NULL),
(5, 'logo_empresa', 'plugins/images/casaDecorFondo.png', NULL),
(6, 'localidad', 'Zamora', NULL),
(7, 'Provincia', 'Zamora', NULL),
(8, 'telefono', '924123456', NULL),
(9, 'email', 'casaDecor@gmail.com', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalles_pedido`
--

CREATE TABLE `detalles_pedido` (
  `id` int(11) NOT NULL,
  `id_pedido` int(11) DEFAULT NULL,
  `id_producto` int(11) DEFAULT NULL,
  `precio_unidad` float DEFAULT NULL,
  `unidades` int(11) DEFAULT NULL,
  `impuesto` float DEFAULT NULL,
  `total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `detalles_pedido`
--

INSERT INTO `detalles_pedido` (`id`, `id_pedido`, `id_producto`, `precio_unidad`, `unidades`, `impuesto`, `total`) VALUES
(105, 62, 24, 39.99, 3, 25.1937, 145.1637),
(106, 62, 8, 29.99, 1, 6.2979, 36.2879),
(107, 62, 15, 34.99, 5, 36.7395, 211.6895),
(108, 62, 18, 69.99, 6, 88.1874, 508.12739999999997),
(109, 63, 29, 64.99, 3, 40.9437, 235.91369999999995),
(111, 63, 27, 79.99, 5, 83.9895, 483.93949999999995),
(112, 63, 13, 89.99, 4, 75.5916, 435.5516),
(113, 64, 20, 39.99, 2, 16.7958, 96.7758),
(114, 64, 28, 89.99, 6, 113.387, 653.3273999999999),
(115, 64, 17, 19.99, 4, 16.7916, 96.7516),
(116, 64, 36, 24.99, 3, 15.7437, 90.7137),
(117, 65, 35, 129.99, 1, 27.2979, 157.2879),
(118, 65, 10, 79.99, 4, 67.1916, 387.1516),
(119, 65, 33, 99.99, 4, 83.9916, 483.9516),
(120, 65, 9, 149.99, 3, 94.4937, 544.4637),
(121, 65, 13, 89.99, 1, 18.8979, 108.8879),
(122, 65, 28, 89.99, 4, 75.5916, 435.5516),
(123, 66, 26, 19.99, 1, 4.1979, 24.1879),
(124, 66, 28, 89.99, 1, 18.8979, 108.8879),
(125, 66, 20, 39.99, 1, 8.3979, 48.3879),
(126, 67, 13, 89.99, 1, 18.8979, 108.8879),
(127, 67, 24, 39.99, 4, 33.5916, 193.5516);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `metodo_pago` varchar(255) DEFAULT NULL,
  `estado` varchar(255) DEFAULT NULL,
  `num_factura` varchar(255) DEFAULT NULL,
  `total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`id`, `id_usuario`, `fecha`, `metodo_pago`, `estado`, `num_factura`, `total`) VALUES
(62, 3, '2024-05-05 22:18:00', 'visa', 'enviado', 'FA0050', 901.2685),
(63, 3, '2024-05-08 22:18:01', 'paypal', 'enviado', 'FA0051', 1155.4047999999998),
(64, 3, '2024-05-07 22:18:03', 'visa', 'enviado', 'FA0052', 937.5684999999999),
(65, 55, '2024-05-06 22:18:04', 'paypal', 'enviado', 'FA0053', 2117.2942999999996),
(66, 55, '2024-05-05 22:18:05', 'visa', 'enviado', 'FA0054', 181.46370000000002),
(67, 55, '2024-05-04 22:18:08', 'paypal', 'enviado', 'FA0055', 302.4395);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `id_categoria` int(11) DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `fecha_alta` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `impuesto` float DEFAULT NULL,
  `imagen` varchar(500) DEFAULT NULL,
  `baja` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `id_categoria`, `nombre`, `descripcion`, `precio`, `stock`, `fecha_alta`, `impuesto`, `imagen`, `baja`) VALUES
(8, 1, 'Cojí­n Decorativo Geométrico', 'Cojín decorativo con diseño geométrico moderno. Ideal para agregar un toque de estilo a tu sofá o cama.', 29.99, 80, '2024-05-08 23:25:37', 0.21, 'https://media.wonderfulhomeshop.com/product/cojin-geometrico-45x45-gris-mayo-800x800.jpg', 0),
(9, 2, 'Alfombra de Lana Tejida a Mano', 'Alfombra de lana tejida a mano con patrón único. Perfecta para agregar calidez y textura a cualquier habitación.', 149.99, 26, '2024-05-08 22:58:46', 0.21, 'https://medias.maisonsdumonde.com/images/ar_1:1,c_pad,f_auto,q_auto,w_732/v1/mkp/M20020152_1/alfombra-de-lana-tejida-a-mano-arena-140x200-cm.jpg', 0),
(10, 3, 'Lámpara de Pie Moderna', 'Lámpara de pie con diseño moderno y elegante. Proporciona una iluminación suave y cálida para cualquier espacio.', 79.99, 6, '2024-05-08 22:53:08', 0.21, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTb9gWl0xLWwS55-eGBeQABOJ1Jjc7PvQaZdqQzDbcgLA&s', 0),
(11, 4, 'Cortinas Opacas de Terciopelo', 'Cortinas opacas de terciopelo con forro térmico. Bloquean la luz y mantienen la privacidad de tu hogar.', 59.99, 71, '2024-05-08 22:53:08', 0.21, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTI-YFXhPbDKFRagWI8e93f-zVRnvNr6rS670LBlUo3Ng&s', 0),
(12, 6, 'Jarrón de Cerámica Hecho a Mano', 'Jarrón de cerámica hecho a mano con esmalte brillante. Añade un toque de arte a tu espacio.', 39.99, 55, '2024-05-08 19:37:18', 0.21, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS37MHxqNq5mH9CjJpY-rdIO8BS3SXUZJHgF8IbfDJkMQ&s', 0),
(13, 5, 'Espejo de Pared Decorativo', 'Espejo de pared decorativo con marco de metal. Ideal para hacer que cualquier habitación se sienta más grande y luminosa.', 89.99, 31, '2024-05-08 22:17:52', 0.21, 'https://mirococo.com/wp-content/uploads/2019/11/50373AWS.jpg', 0),
(15, 7, 'Cesta de Almacenamiento de Mimbre', 'Cesta de almacenamiento tejida a mano con mimbre natural. Perfecta para organizar revistas, mantas o juguetes.', 34.99, 55, '2024-05-08 22:53:08', 0.21, 'https://m.media-amazon.com/images/I/91Gqx7GecxL.jpg', 0),
(16, 5, 'Cuadro Decorativo de Paisaje', 'Cuadro decorativo de paisaje impreso en lienzo. Agrega un toque de naturaleza a tus paredes.', 49.99, 47, '2024-05-07 17:18:40', 0.21, 'https://www.artgeist.es/mediacache/catalog/product/cache/3/4/34543/image/653x486/d234e7375740058a4fefba79c14245e3/34543_1.jpg', 0),
(17, 6, 'Set de Tazas de Cerámica', 'Set de tazas de cerámica pintadas a mano. Perfectas para disfrutar de una taza de té o café con estilo.', 19.99, 74, '2024-05-08 22:16:23', 0.21, 'https://m.media-amazon.com/images/I/71+85PW-FyL.jpg', 0),
(18, 4, 'Manta de Punto Grueso', 'Manta de punto grueso hecha de algodón suave. Ideal para acurrucarse en el sofá en las noches frías.', 69.99, 50, '2024-05-08 22:15:25', 0.21, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkkoulwRnM510HUkbpt7u9v7jD3RLA-fJQ-LIF1yUlkw&s', 0),
(19, 6, 'Set de Cuchillos de Cocina', 'Set de cuchillos de cocina de acero inoxidable con soporte de madera. Añade estilo y funcionalidad a tu cocina.', 79.99, 38, '2024-05-07 12:04:37', 0.21, 'https://m.media-amazon.com/images/I/71Bn-ok5+0S._AC_UF1000,1000_QL80_DpWeblab_.jpg', 0),
(20, 5, 'Reloj de Pared Moderno', 'Reloj de pared moderno con diseño minimalista. Un accesorio funcional y decorativo para cualquier habitación.', 39.99, 0, '2024-05-08 22:17:38', 0.21, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvWvOEkBjj0ZxdxgiSCge9YBvH0llGMpIySKYsRcgsqw&s', 0),
(24, 1, 'Cojí­n de Terciopelo Suave', 'Cojí­n suave de terciopelo en varios colores. Ideal para agregar un toque de lujo y comodidad a tu sofá.', 39.99, 36, '2024-05-08 23:41:22', 0.21, 'https://www.revitex.com/23720-large_default/cojin-terciopelo-dayara.jpg', 0),
(25, 1, 'Almohada Ergonómica de Espuma con Memoria', 'Almohada ergonómica con núcleo de espuma viscoelástica que se adapta a la forma de tu cabeza y cuello para un mejor descanso.', 49.99, 26, '2024-05-08 18:50:06', 0.21, 'https://bronmart.com/cdn/shop/files/almohadadebambudeespumaviscoelastica_comolavarunaalmohadadebambudeespumaviscoelastica_almohadadebambudeespumaviscoelasticatermosensible_a-SLT-PLM-070-Oreillers-de-luxe-en-bambou--25-m_c7f1850b-d0f6-4edf-8a54-d98980f84957_700x700.jpg?v=1695033721', 0),
(26, 2, 'Tapete Antideslizante para Baño', 'Tapete suave y absorbente para el baño con base antideslizante. Disponible en varios colores y tamaños.', 19.99, 59, '2024-05-08 22:17:38', 0.21, 'https://www.ortopediaflorencio.com/2623-large_default/tapete-antideslizante-dycem-rectangular-25x18cm.jpg', 0),
(27, 2, 'Alfombra Tejida a Mano con Diseño Bohemio', 'Alfombra tejida a mano con diseño bohemio. Aporta calidez y estilo a cualquier habitación de tu hogar.', 79.99, 10, '2024-05-08 22:15:49', 0.21, 'https://liderlamp.es/wp-content/uploads/2020/11/Alfombra-Salma-Madam-Stoltz-etnico-bohemio-Tejida-a-mano-Liderlamp-1.jpg', 0),
(28, 3, 'Lámpara de Techo Industrial', 'Lámpara colgante de estilo industrial con acabado metálico. Perfecta para iluminar tu cocina o comedor con un toque vintage.', 89.99, 1, '2024-05-08 22:17:38', 0.21, 'https://w4v8q6r3.rocketcdn.me/wp-content/uploads/2017/04/lampara-de-techo-industrial-marina-faro-barcelona-la-casa-de-la-lampara.jpg', 0),
(29, 3, 'Lámpara de Mesa de Madera', 'Lámpara de mesa con base de madera y pantalla de tela. Proporciona una luz suave y cálida para crear un ambiente acogedor en tu sala de estar.', 64.99, 32, '2024-05-08 22:15:49', 0.21, 'https://www.luzete.es/18426/lampara-de-mesa-sigrid-madera-natural-e14.jpg', 0),
(30, 4, 'Visillo Bordado de Estilo Vintage', 'Visillo bordado con patrón floral vintage. Agrega un toque elegante a tus ventanas mientras permite que entre la luz natural.', 29.99, 49, '2024-05-08 17:53:33', 0.21, 'https://ka-international.com/shop/373077-large_default/cur-0135262xx.jpg', 0),
(31, 4, 'Manta de Lana de Punto', 'Manta de lana tejida a mano con un diseño de punto clásico. Perfecta para abrigarte en las noches frías de invierno.', 79.99, 25, '2024-05-08 17:39:54', 0.21, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSF9o2Cyn5HnFVxLRwD-cxiWR8NG1ONGJCmbGfjnWbukg&s', 0),
(32, 5, 'Espejo Redondo de Pared', 'Espejo redondo con marco de metal negro. Agrega un toque moderno y minimalista a cualquier pared de tu hogar.', 49.99, 40, '2024-05-08 17:39:31', 0.21, 'https://www.bricomoraleja.com/wp-content/uploads/2021/08/Espejo-redondo-barbier.jpg', 0),
(33, 5, 'Cuadro Abstracto en Lienzo', 'Cuadro abstracto pintado a mano en lienzo. Aporta un toque de arte contemporáneo y color a tu sala de estar o dormitorio.', 99.99, 11, '2024-05-08 22:17:03', 0.21, 'https://ae01.alicdn.com/kf/H85cddf2f5a51430887bf1e1cb35ea162Z/Cuadro-abstracto-moderno-para-decoraci-n-del-hogar-pintura-al-leo-sobre-lienzo-p-ster-n.jpg', 0),
(34, 6, 'Candelabro de Hierro Forjado', 'Candelabro de hierro forjado con diseño elegante y vintage. Perfecto para decorar tu mesa en cenas especiales o eventos.', 34.99, 30, '2024-05-08 19:36:04', 0.21, 'https://i.etsystatic.com/16729708/r/il/828c79/2442297272/il_570xN.2442297272_rja4.jpg', 0),
(35, 6, 'Vajilla de Porcelana Estampada', 'Vajilla de porcelana con delicados estampados florales. Ideal para servir tus comidas con estilo.', 159.99, 9, '2024-05-08 23:25:39', 0.21, 'https://i.etsystatic.com/10950400/r/il/4f0f9d/4884853716/il_570xN.4884853716_1l23.jpg', 0),
(36, 7, 'Organizador de Escritorio de Bambú', 'Organizador de escritorio hecho de bambú natural. Ayuda a mantener tus útiles de oficina y papelería ordenados y accesibles.', 24.99, 47, '2024-05-08 22:16:23', 0.21, 'https://m.media-amazon.com/images/I/71DxELCyN5L.jpg', 0),
(37, 7, 'Caja de Almacenamiento de Tela', 'Caja de almacenamiento plegable de tela con diseño moderno. Perfecta para guardar ropa, juguetes u otros objetos en tu armario o estanterÃ­a.', 19.99, 33, '2024-05-08 19:35:55', 0.21, 'https://m.media-amazon.com/images/I/71OaF3YYbiL._AC_UF894,1000_QL80_.jpg', 0),
(40, 1, 'Cojín Decorativo de Pana', 'Cojí­n decorativo de pana suave en tonos neutros. Agrega textura y estilo a cualquier espacio de tu hogar.', 49.99, 30, '2024-05-08 22:08:42', 0.21, 'https://m.media-amazon.com/images/I/81UUx6a0CaL._AC_UF894,1000_QL80_DpWeblab_.jpg', 0),
(69, 2, 'Alfombra de Yute Tejida a Mano', 'Alfombra de yute natural tejida a mano. Aporta calidez y un toque orgÃ¡nico a cualquier ambiente de tu hogar.', 79.99, 25, '2024-05-08 17:39:41', 0.21, 'https://storage.googleapis.com/catalog-pictures-carrefour-es/catalog/pictures/hd_510x_/8718475733614_1.jpg', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `id` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `localidad` varchar(255) DEFAULT NULL,
  `provincia` varchar(255) DEFAULT NULL,
  `telefono` varchar(255) DEFAULT NULL,
  `cif` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `baja` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`id`, `nombre`, `direccion`, `localidad`, `provincia`, `telefono`, `cif`, `email`, `baja`) VALUES
(1, 'Distribuidora Alfa S.A.', 'Calle del Comercio 123', 'Madrid', 'Madrid', '123456789', 'A12345678', 'info@distribuidoraalfa.com', 0),
(2, 'Importadora Beta SL', 'Avenida del Progreso 456', 'Barcelona', 'Barcelona', '987654321', 'B87654321', 'contacto@importadorabeta.es', 0),
(3, 'Productos del Sur', 'Calle Andaluza 789', 'Sevilla', 'Sevilla', '654987321', 'C76543210', 'info@productossur.com', 0),
(4, 'Suministros del Norte', 'Avenida del Norte 456', 'Bilbao', 'Vizcaya', '369258147', 'D65432109', 'contacto@suministrosnorte.es', 1),
(5, 'Distribuidora Este-Oeste', 'Calle de la Unión 987', 'Valencia', 'Valencia', '741852963', 'E21098765', 'ventas@distribuidoraesteoeste.com', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `rol` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `roles`
--

INSERT INTO `roles` (`id`, `rol`) VALUES
(1, 'cliente'),
(2, 'empleado'),
(3, 'administrador'),
(4, 'superadministrador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `id_rol` int(11) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `clave` varchar(255) DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `apellido1` varchar(255) DEFAULT NULL,
  `apellido2` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `provincia` varchar(255) DEFAULT NULL,
  `localidad` varchar(255) DEFAULT NULL,
  `telefono` varchar(255) DEFAULT NULL,
  `dni` varchar(255) DEFAULT NULL,
  `baja` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `id_rol`, `email`, `clave`, `nombre`, `apellido1`, `apellido2`, `direccion`, `provincia`, `localidad`, `telefono`, `dni`, `baja`) VALUES
(3, 1, 'miguel@gmail.com', '0lAmt+PN/5+Zq6j/2qCkJzB4vQyhGWSNGazBEy+DZxmM6Hew5PV1mniHWFyfI0Cq', 'Miguel Ricardo', 'Silvestre', 'Bernardino', 'Calle falsa 123', 'Zamora', 'Toro', '673115333', '12345678A', 0),
(7, 2, 'juan@gmail.com', 'n8o2fZMftT5IgzNGxm2zOeppid5A2/wmhgHQnOhTjI1X6idRhMSzansGELg0QO/A', 'Juan', 'Perez', 'Gomez', 'Calle falsa 123', 'Zamora', 'Zamora', '924243455', '12345678B', 0),
(8, 3, 'ana@gmail.com', 'W9He7p68qyu31tu61VZ6eg6IgjRxR8LBCu0fI3ULrKTcF03KCiSoazNIK6V+b+d7', 'Ana', 'Martinez', 'Ruiz', 'Calle falsa 123', 'Zamora', 'Zamora', '924234455', '12345678D', 0),
(55, 1, 'maria@gmail.com', 'c/w5lqEzJgi6gi+WjmqYY+Cb3mPYoG32XJlvRWxEbpXSkWbhyAKNODYcFtArTm5q', 'Maria', 'Garcia', 'Gomez', 'Calle falsa 123', 'Zamora', 'Zamora', '875394124', '12345678C', 0),
(74, 4, 'admin@admin.es', 'EuwbdkOVY0BbooQCcBzkDrv2xZTBAE2a0BeXsH8AaGHkwqsnh84qjEVul5MVlNVz', 'admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `valoraciones`
--

CREATE TABLE `valoraciones` (
  `id` int(11) NOT NULL,
  `id_producto` int(11) DEFAULT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `valoracion` int(11) DEFAULT NULL,
  `comentario` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `valoraciones`
--

INSERT INTO `valoraciones` (`id`, `id_producto`, `id_usuario`, `valoracion`, `comentario`) VALUES
(6, 27, 3, 1, 'No me gusta'),
(7, 29, 3, 5, 'Muy buen producto'),
(8, 20, 3, 4, 'No se ven los números'),
(9, 26, 55, 5, 'Me gusta el azul'),
(10, 24, 55, 2, 'Muy incómodo');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `configuracion`
--
ALTER TABLE `configuracion`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `detalles_pedido`
--
ALTER TABLE `detalles_pedido`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_pedido` (`id_pedido`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_rol` (`id_rol`);

--
-- Indices de la tabla `valoraciones`
--
ALTER TABLE `valoraciones`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_producto` (`id_producto`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `configuracion`
--
ALTER TABLE `configuracion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `detalles_pedido`
--
ALTER TABLE `detalles_pedido`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=136;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=75;

--
-- AUTO_INCREMENT de la tabla `valoraciones`
--
ALTER TABLE `valoraciones`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalles_pedido`
--
ALTER TABLE `detalles_pedido`
  ADD CONSTRAINT `detalles_pedido_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `pedidos` (`id`),
  ADD CONSTRAINT `detalles_pedido_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id`);

--
-- Filtros para la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`id_rol`) REFERENCES `roles` (`id`);

--
-- Filtros para la tabla `valoraciones`
--
ALTER TABLE `valoraciones`
  ADD CONSTRAINT `valoraciones_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id`),
  ADD CONSTRAINT `valoraciones_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
