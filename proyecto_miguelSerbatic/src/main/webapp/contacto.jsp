<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
<link rel="stylesheet" type="text/css" href="css\contacto.css">
</head>
<body>
	<div class="container">
		<%
		String correo = (String) request.getSession().getAttribute("correoGuardado");
		String nombre = (String) request.getSession().getAttribute("nombreUsuario");
		%>
		<h2>Formulario de Contacto</h2>
		<form action="enviarCorreo" method="post">

			<input type="text" name="nombre" placeholder="Nombre"
				<%if (nombre != null) {%> value="<%=nombre%>" <%}%> required>

			<textarea name="mensaje" rows="5" placeholder="Mensaje" required></textarea>
			<input type="submit" value="Enviar mensaje">
		</form>
	</div>
</body>
</html>