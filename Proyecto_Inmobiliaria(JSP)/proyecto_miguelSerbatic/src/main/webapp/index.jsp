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
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
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
<header style="position: relative; margin-bottom: -120px; margin-top: -20px;">
    <div class="container px-4 px-lg-5 my-5">
        <div class="text-center text-white" style="position: absolute; top: 50%; left: 50%; transform: translate(-50%, -50%);">
            <h1 class="display-4 fw-bolder"><%=nombre%></h1>
            <p class="lead fw-normal text-white mb-0"><%=rb.getString("ESLOGAN_1")%></p>
            <p class="lead fw-normal text-white mb-0"><%=nombre%><%=rb.getString("ESLOGAN_2")%></p>
        </div>
        <img src="plugins/images/muebles.jpeg" alt="Nombre de tu empresa" class="img-fluid" style="width: 100%; max-height: 500px;">
    </div>
</header>
	<!-- Section-->
	<section class="py-5">
		<div class="container px-4 px-lg-5 mt-5">
		<div style="margin-bottom: 10px">
				<a class="boton btn btn-outline-dark mt-auto" href="precioASC"><%=rb.getString("PRECIO_BAJO")%></a>
		<a class="btn btn-outline-dark mt-auto" href="precioDESC"><%=rb.getString("PRECIO_ALTO")%></a>
		<a class="btn btn-outline-dark mt-auto" href="productosNuevos"><%=rb.getString("NOVEDADES")%></a>
		<a class="btn btn-outline-dark mt-auto" href="productosMasVendidos"><%=rb.getString("MAS_VENDIDOS")%></a>
		</div>
			<div class="row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center">
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
								<%=producto.getPrecio()%>€
							</div>
						</div>
						<!-- Product actions-->
						<div class="card-footer p-4 pt-0 border-top-0 bg-transparent">
							<div class="text-center">
								<a class="btn btn-outline-dark mt-auto"
									href="verProducto?id=<%=producto.getId()%>"><%=rb.getString("VER_PRODUCTO")%></a>
									<%if(producto.getStock() <= 0){%>
					<p style="color:red;"><%=rb.getString("FUERA_STOCK")%></p>
						<%
					}else{ %>
									 <a class="btn btn-outline-dark mt-auto"
									href="AniadirCarritoServlet?id=<%=producto.getId()%>"><%=rb.getString("COMPRAR_PRODUCTO")%></a>
									<%} %>
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
