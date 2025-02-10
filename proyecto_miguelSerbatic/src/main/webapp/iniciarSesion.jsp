<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8" import="model.VO.UsuarioVO" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Lato&display=swap" rel="stylesheet">
    <!-- Estilos CSS -->
    <link rel="stylesheet" href="css/estiloInicio.css">
</head>
<body>
<%@include file = "cabecera.jsp" %>
    <main class ="inicio">
        <article>
            <section>
                <form action="InicioSesion" method="POST">
                    <h1>Inicia Sesion</h1>

                    <input type="email" name="email" placeholder="Correo electr&oacute;nico" required><br/>
                    <input type="password" name="password" placeholder="Contrase&ntilde;a" required><br/>
                                        <% 
        String errorMessage = (String) request.getAttribute("errorMessage");
        if (errorMessage != null && !errorMessage.isEmpty()) {%>
           <p class="error-message"><%= errorMessage %></p>
  	    <%
        }
        %>
                    <button type="reset">Limpiar</button>
                    <button type="submit">Entrar</button>

                    <p>Aun no tienes cuenta ?</p>
                    <p>
                        <a href="registro.jsp">Registrate</a>
                    </p>
                </form>
            </section>
        </article>
    </main>
    
</body>
</html>