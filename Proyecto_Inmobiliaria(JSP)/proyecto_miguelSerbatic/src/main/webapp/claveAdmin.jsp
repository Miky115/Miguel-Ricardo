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
    <main class ="inicio">
        <article>
            <section>
                <form action="cambiarClave" method="POST">
                    <h1>Cambia la clave</h1>

            <input type="email" id="emailInput" name="email" placeholder="Correo electrónico" value = "<%=request.getAttribute("email") %>" required>
            <input type="password" id="clave" name="clave" placeholder="Nueva contraseña" required>
            <input type="password" id="confirmarClave" name="confirmarClave" placeholder="Confirmar contraseña" required>
                    
                    <button type="reset">Limpiar</button>
                    <button type="submit">Entrar</button>
                </form>
            </section>
        </article>
    </main>
    <script>
    var passwordField = document.getElementById("clave");
    var confirmPasswordField = document.getElementById("confirmarClave");

    function validatePasswordFields() {
        if (passwordField.value !== confirmPasswordField.value) {
            passwordField.setCustomValidity("Las contraseñas no coinciden");
            confirmPasswordField.setCustomValidity("Las contraseñas no coinciden");
        } else if (passwordField.value !== "" && confirmPasswordField.value === "") {
            confirmPasswordField.setCustomValidity("Por favor, rellena el campo 'Confirmar cambio de clave'");
        } else if (passwordField.value === "" && confirmPasswordField.value !== "") {
            passwordField.setCustomValidity("Por favor, rellena el campo 'Cambiar clave'");
        } else {
            passwordField.setCustomValidity("");
            confirmPasswordField.setCustomValidity("");
        }
    }

    passwordField.addEventListener("blur", validatePasswordFields);
    confirmPasswordField.addEventListener("blur", validatePasswordFields);
</script>
</body>
</html>