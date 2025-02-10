<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
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
            <form action="CrearUsuario" method="POST" id="register" onsubmit="return validarFormulario()">
                <h1>Registrate</h1>

                <input type="text" name="nombre" id="nombre" placeholder="Nombre" required oninput="validarNombre()"><br/>

                <input type="text" name="primer_apellido" id="primer_apellido" placeholder="Primer Apellido" required oninput="validarPrimerApellido()"><br/>

                <input type="text" name="segundo_apellido" id="segundo_apellido" placeholder="Segundo Apellido" required oninput="validarSegundoApellido()"><br/>

                <input type="email" name="email" placeholder="Correo electr&oacute;nico" required><br/>

                <input type="password" name="clave" id="clave" placeholder="Contrase&ntilde;a" required><br/>

                <input type="password" name="confirm_password" id="confirm_password" placeholder="Repite la Contrase&ntilde;a" required oninput="validarContraseña()"><br/>

                <button type="reset">Limpiar</button>
                <button type="submit">Entrar</button>

                <p>Ya tienes cuenta ?</p>
                <p>
                    <a href="iniciarSesion.jsp">Inicia Sesion</a>
                </p>
            </form>
        </section>
    </article>
</main>

<script>
    function validarNombre() {
        var nombre = document.getElementById('nombre').value;
        var campoNombre = document.getElementById('nombre');
        if (/\d/.test(nombre)) {
            campoNombre.setCustomValidity('El nombre no puede contener números');
        } else {
            campoNombre.setCustomValidity('');
        }
    }

    function validarPrimerApellido() {
        var primerApellido = document.getElementById('primer_apellido').value;
        var campoPrimerApellido = document.getElementById('primer_apellido');
        if (/\d/.test(primerApellido)) {
            campoPrimerApellido.setCustomValidity('El primer apellido no puede contener números');
        } else {
            campoPrimerApellido.setCustomValidity('');
        }
    }

    function validarSegundoApellido() {
        var segundoApellido = document.getElementById('segundo_apellido').value;
        var campoSegundoApellido = document.getElementById('segundo_apellido');
        if (/\d/.test(segundoApellido)) {
            campoSegundoApellido.setCustomValidity('El segundo apellido no puede contener números');
        } else {
            campoSegundoApellido.setCustomValidity('');
        }
    }

    function validarContraseña() {
        var contraseña = document.getElementById('clave').value;
        var confirmarContraseña = document.getElementById('confirm_password').value;
        var campoContraseña = document.getElementById('confirm_password');
        if (contraseña !== confirmarContraseña) {
            campoContraseña.setCustomValidity('Las contraseñas no coinciden');
        } else {
            campoContraseña.setCustomValidity('');
        }
    }

    function validarFormulario() {
        validarNombre();
        validarPrimerApellido();
        validarSegundoApellido();
        validarContraseña();
        return true;
    }
</script>
</body>
</html>
