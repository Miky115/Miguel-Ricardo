<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
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
                <form action="DatosUsuarioServlet" method="POST" id="register">
                    <h1>Mis datos</h1>
					<input type="text" name="nombre" placeholder="Nombre" <% if(usuario.getNombre() != null) { %> value="<%=usuario.getNombre()%>" <% } %> required><br/>
					<input type="text" name="primer_apellido" placeholder="Primer Apellido" <% if(usuario.getApellido1() != null) { %> value="<%=usuario.getApellido1()%>" <% } %> required><br/>
					<input type="text" name="segundo_apellido" placeholder="Segundo Apellido" <% if(usuario.getApellido2() != null) { %> value="<%=usuario.getApellido2()%>" <% } %> required><br/>
					<input type="text" name="dni" placeholder="DNI" <% if(usuario.getDni() != null) { %> value="<%=usuario.getDni()%>" <% } %> required><br/>
					<input type="email" name="email" placeholder="Correo electr&oacute;nico" <% if(usuario.getEmail() != null) { %> value="<%=usuario.getEmail()%>" <% } %> required><br/>
					<input type="password" name="clave" id="clave" placeholder="Contrase&ntilde;a"><br/>
					<input type="password" name="Confirmarclave" id="Confirmarclave" placeholder="Repite la Contrase&ntilde;a"><br/>
					<input type="text" name="provincia" placeholder="Provincia" <% if(usuario.getProvincia() != null) { %> value="<%=usuario.getProvincia()%>" <% } %>><br/>
					<input type="text" name="localidad" placeholder="Localidad" <% if(usuario.getLocalidad() != null) { %> value="<%=usuario.getLocalidad()%>" <% } %>><br/>
					<input type="text" name="direccion" placeholder="Dirección" <% if(usuario.getDireccion() != null) { %> value="<%=usuario.getDireccion()%>" <% } %>><br/>
					<input type="tel" name="telefono" placeholder="Teléfono" <% if(usuario.getTelefono() != null) { %> value="<%=usuario.getTelefono()%>" <% } %>><br/>
                    <button type="submit">Actualizar datos</button>
                </form>
                    <script>
                 // Obtener los elementos del formulario
                    var telefonoField = document.getElementsByName("telefono")[0];
                    var dniField = document.getElementsByName("dni")[0];
                    var nombreField = document.getElementsByName("nombre")[0];
                    var primerApellidoField = document.getElementsByName("primer_apellido")[0];
                    var segundoApellidoField = document.getElementsByName("segundo_apellido")[0];
                    var passwordField = document.getElementById("clave");
                    var confirmPasswordField = document.getElementById("Confirmarclave");

                    function validatePasswordFields() {
                        if (passwordField.value !== "" && confirmPasswordField.value === "") {
                            confirmPasswordField.setCustomValidity("Por favor, rellena el campo 'Confirmar cambio de clave'");
                        } else if (passwordField.value === "" && confirmPasswordField.value !== "") {
                            passwordField.setCustomValidity("Por favor, rellena el campo 'Cambiar clave'");
                        }else if(passwordField.value != confirmPasswordField.value){
                        	passwordField.setCustomValidity("Las contraseñas no son iguales");
                        }else {
                            passwordField.setCustomValidity("");
                            confirmPasswordField.setCustomValidity("");
                        }
                    }

                    function validateTelefono() {
                        // Obtener el valor del campo de teléfono
                        var telefonoValue = telefonoField.value.trim(); // Eliminar espacios en blanco al inicio y al final

                        // Verificar si el campo está vacío o tiene exactamente 9 dígitos
                        if (telefonoValue === '' || telefonoValue.length === 9) {
                            telefonoField.setCustomValidity(""); // El campo es válido
                        } else {
                            telefonoField.setCustomValidity("El número de teléfono debe tener 9 dígitos o dejarlo vacío"); // El campo no cumple con la validación
                        }
                    }

                    // Agregar el evento de entrada al campo de teléfono
                    telefonoField.addEventListener("input", validateTelefono);

                    // Función para validar el DNI
                    function validateDNI() {
                        var dniValue = dniField.value;
                        if (!/^\d{8}[a-zA-Z]$/.test(dniValue)) {
                            dniField.setCustomValidity("El DNI debe tener 8 dígitos seguidos de una letra");
                        } else {
                            dniField.setCustomValidity("");
                        }
                    }
                    dniField.addEventListener("input", validateDNI);

                    // Función para validar nombre, primer apellido y segundo apellido
                    function validateTextFields(field) {
                        if (!/^[a-zA-Z\s]*$/.test(field.value)) {
                            field.setCustomValidity("Solo se permiten letras y espacios en blanco");
                        } else {
                            field.setCustomValidity("");
                        }
                    }
                    nombreField.addEventListener("input", function() { validateTextFields(nombreField); });
                    primerApellidoField.addEventListener("input", function() { validateTextFields(primerApellidoField); });
                    segundoApellidoField.addEventListener("input", function() { validateTextFields(segundoApellidoField); });
                    passwordField.addEventListener("blur", validatePasswordFields);
                    confirmPasswordField.addEventListener("blur", validatePasswordFields);
                    </script>
            </section>
        </article>
    </main>
        <%@include file="piePagina.jsp"%>
</body>
</html>