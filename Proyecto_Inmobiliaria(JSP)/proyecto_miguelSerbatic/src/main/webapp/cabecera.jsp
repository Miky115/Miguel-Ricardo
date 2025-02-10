<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"
	import="model.VO.UsuarioVO, model.VO.ProductoVO, java.util.HashMap, model.VO.CategoriaVO, java.util.List, java.util.ResourceBundle, java.util.Locale"%>
    <%
        ResourceBundle rb = (ResourceBundle) request.getAttribute("resourceBundle");
    if (rb == null){
    	rb = ResourceBundle.getBundle("i18n.Idioma", new Locale("es","ES"));
    }
    %>

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
<!-- Favicon-->
<link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
<!-- Bootstrap icons-->
<link
	href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css"
	rel="stylesheet" />
<!-- Core theme CSS (includes Bootstrap)-->
<link href="css/styles.css" rel="stylesheet" />
</head>
<body class = "cuerpo">
	<%
	String nombre = (String) request.getSession().getAttribute("nombre_empresa");
	String direccion = (String) request.getSession().getAttribute("direccion");
	String cif = (String) request.getSession().getAttribute("cif");
	String telefono = (String) request.getSession().getAttribute("telefono");
	String email = (String) request.getSession().getAttribute("email");
	String provincia = (String) request.getSession().getAttribute("provincia");
	String localidad = (String) request.getSession().getAttribute("localidad");
	String logo = (String) request.getSession().getAttribute("logo");
	%>
	<!-- Navigation-->
	<nav class="navbar navbar-expand-lg navbar-light bg-light">
		<div class="container px-4 px-lg-5">
			<a class="navbar-brand" href="Catalogo"><%=nombre%></a>
			<button class="navbar-toggler" type="button"
				data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent"
				aria-controls="navbarSupportedContent" aria-expanded="false"
				aria-label="Toggle navigation">
				<span class="navbar-toggler-icon"></span>
			</button>
			<div class="collapse navbar-collapse" id="navbarSupportedContent">
				<ul class="navbar-nav me-auto mb-2 mb-lg-0 ms-lg-4">
					<li class="nav-item"><a class="nav-link active"
						aria-current="page" href="Catalogo"><%=rb.getString("INICIO")%></a></li>
						
											<li class="nav-item dropdown"><a
						class="nav-link dropdown-toggle" id="navbarDropdown" href="#"
						role="button" data-bs-toggle="dropdown" aria-expanded="false"><%=rb.getString("PRODUCTOS")%></a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdown">
							<li>
								<form class="filter-form" action="categ" method="get">
									<ul style="list-style: none; padding-left: 0;">
										<li><a href="Catalogo" class="dropdown-item">Todos
												los productos</a></li>
										<li><hr class="dropdown-divider" /></li>
										<%
										List<CategoriaVO> categorias = (List<CategoriaVO>) request.getSession().getAttribute("categorias");
										if (categorias != null) {
											for (CategoriaVO categoria : categorias) {
										%>
										<li><a href="categ?categoria=<%=categoria.getNombre()%>"
											class="dropdown-item"><%=categoria.getNombre()%></a></li>
										<%
										}
										}
										%>
									</ul>
								</form>
							</li>
						</ul></li>
						
					<li class="nav-item dropdown"><a
						class="nav-link dropdown-toggle" id="navbarDropdown" href="#"
						role="button" data-bs-toggle="dropdown" aria-expanded="false"><%=rb.getString("IDIOMA")%></a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdown">
							<li>
									<ul style="list-style: none; padding-left: 0;">

										<li><a href="?lang=es" class="dropdown-item"><%=rb.getString("ESPANOL")%></a></li>
										<li><a href="?lang=en" class="dropdown-item"><%=rb.getString("INGLES")%></a></li>

									</ul>
							</li>
						</ul></li>
				</ul>
				<%
				UsuarioVO usuario = (UsuarioVO) request.getSession().getAttribute("usuarioGuardado");
				if (usuario == null) {
				%>

				<form class="d-flex" action="iniciarSesion.jsp">
					<button class="btn btn-outline-dark" type="submit">
						<%=rb.getString("LOG_IN")%>
						<span class="badge bg-dark text-white ms-1 rounded-pill"></span>
					</button>
				</form>

				<form class="d-flex" action="registro.jsp">
					<button class="btn btn-outline-dark" type="submit">
						<%=rb.getString("REGISTRO")%>
						<span class="badge bg-dark text-white ms-1 rounded-pill"></span>
					</button>
				</form>
				<%
				} else {
				%>
				<form class="d-flex" action="PedidosDESC">
					<button class="btn btn-outline-dark" type="submit">
						<%=rb.getString("MIS_PEDIDOS")%>
						<span class="badge bg-dark text-white ms-1 rounded-pill"></span>
					</button>
				</form>
				<form class="d-flex" action="misDatos.jsp">
					<button class="btn btn-outline-dark" type="submit">
						<%=rb.getString("MIS_DATOS")%>
						<span class="badge bg-dark text-white ms-1 rounded-pill"></span>
					</button>
				</form>
				<form class="d-flex" action="cerrar">
					<button class="btn btn-outline-dark" type="submit">
						<%=rb.getString("CERRAR_SESION")%>
						<span class="badge bg-dark text-white ms-1 rounded-pill"></span>
					</button>
				</form>
				<%
				}
				%>
				<form class="d-flex" action="carrito.jsp">
					<button class="btn btn-outline-dark" type="submit">
						<%
						HashMap<ProductoVO, Integer> carrito = (HashMap<ProductoVO, Integer>) request.getSession().getAttribute("carrito");
						int numProductos = 0;
						if (carrito != null) {
							numProductos = carrito.size();
						}
						%>
						<i class="bi-cart-fill me-1"></i>
						<%=rb.getString("CARRITO")%>
						<span class="badge bg-dark text-white ms-1 rounded-pill"><%=numProductos%></span>
					</button>
				</form>
			</div>
		</div>
	</nav>
	<!-- Bootstrap core JS-->
	<script
		src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
	<!-- Core theme JS-->
	<script src="js/scripts.js"></script>
</body>
</html>
