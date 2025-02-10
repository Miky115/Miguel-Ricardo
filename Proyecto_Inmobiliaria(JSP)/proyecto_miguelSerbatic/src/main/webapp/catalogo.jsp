<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"
	import="java.util.List, model.VO.ProductoVO, java.util.HashMap"%>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8" />
<meta name="viewport"
	content="width=device-width, initial-scale=1, shrink-to-fit=no" />
<meta name="description" content="" />
<meta name="author" content="" />
<title>Shop Homepage - Start Bootstrap Template</title>
<!-- Favicon-->
<link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
<!-- Bootstrap icons-->
<link
	href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css"
	rel="stylesheet" />
<!-- Core theme CSS (includes Bootstrap)-->
<link href="css/styles.css" rel="stylesheet" />
</head>
<body>
    <!-- Header -->
    <%@include file="cabecera.jsp"%>
	<!-- Header-->
	<header class="bg-dark py-5">
		<div class="container px-4 px-lg-5 my-5">
			<div class="text-center text-white">
				<h1 class="display-4 fw-bolder">CasaDecor</h1>
				<p class="lead fw-normal text-white-50 mb-0">Tu hogar, tu estilo</p>
				<p class="lead fw-normal text-white-50 mb-0">CasaDecor, donde los detalles hacen la diferencia</p>
			</div>
		</div>
	</header>
	<!-- Section-->
	<section class="py-5">

		<div class="container px-4 px-lg-5 mt-5">

			<div
				class="row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center">
				<%
				List<ProductoVO> catalogo = (List<ProductoVO>) request.getAttribute("catalogo");
				for (ProductoVO producto : catalogo) {
				%>
				<div class="col mb-5">
					<div class="card h-100">
						<!-- Product image-->
						<img class="card-img-top" src="<%=producto.getImagen()%>"
							alt="..." />
						<!-- Product details-->
						<div class="card-body p-4">
							<div class="text-center">
								<!-- Product name-->
								<h5 class="fw-bolder"><%=producto.getNombre()%></h5>
								<!-- Product price-->
								<%=producto.getPrecio()%>
							</div>
						</div>
						<!-- Product actions-->
						<div class="card-footer p-4 pt-0 border-top-0 bg-transparent">
							<div class="text-center">
								<a class="btn btn-outline-dark mt-auto"
									href="DetalleProductoServlet?id=<%=producto.getId()%>">Ver
									producto</a> <a class="btn btn-outline-dark mt-auto"
									href="AniadirCarritoServlet?id=<%=producto.getId()%>">Comprar
									producto</a>
							</div>
						</div>
					</div>
				</div>
				<%
				}
				%>
			</div>
		</div>
	</section>
    <!-- Footer -->
    <%@include file="piePagina.jsp"%>
</body>
</html>
