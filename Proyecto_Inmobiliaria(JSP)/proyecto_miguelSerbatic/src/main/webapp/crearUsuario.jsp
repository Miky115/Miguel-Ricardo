<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"
    import = "model.VO.UsuarioVO"%>
<!DOCTYPE html>
<html dir="ltr" lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
   <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="keywords"
        content="wrappixel, admin dashboard, html css dashboard, web dashboard, bootstrap 5 admin, bootstrap 5, css3 dashboard, bootstrap 5 dashboard, Ample lite admin bootstrap 5 dashboard, frontend, responsive bootstrap 5 admin template, Ample admin lite dashboard bootstrap 5 dashboard template">
    <meta name="description"
        content="Ample Admin Lite is powerful and clean admin dashboard template, inpired from Bootstrap Framework">
    <meta name="robots" content="noindex,nofollow">
    <link rel="canonical" href="https://www.wrappixel.com/templates/ample-admin-lite/" />
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
    <!-- Custom CSS -->
   <link href="css/style.min.css" rel="stylesheet">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
<![endif]-->
</head>

<body>
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class="preloader">
        <div class="lds-ripple">
            <div class="lds-pos"></div>
            <div class="lds-pos"></div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- Main wrapper - style you can find in pages.scss -->
    <!-- ============================================================== -->
    <div id="main-wrapper" data-layout="vertical" data-navbarbg="skin5" data-sidebartype="full"
        data-sidebar-position="absolute" data-header-position="absolute" data-boxed-layout="full">
        <!-- ============================================================== -->
        <!-- Topbar header - style you can find in pages.scss -->
        <!-- ============================================================== -->
      <%@include file="headerAdmin.jsp"%>

        <%@include file = "barraLateralAdmin.jsp" %>
        <div class="page-wrapper">
            <!-- ============================================================== -->
            <!-- Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <div class="page-breadcrumb bg-white">
                <div class="row align-items-center">
                    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                        <h4 class="page-title">Crear usuario</h4>
                    </div>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class="container-fluid">
                <!-- ============================================================== -->
                <!-- Start Page Content -->
                <!-- ============================================================== -->
                <!-- Row -->
                    <!-- Column -->
                    <!-- Column -->
                    <!-- Column -->
                        <div class="card">
                            <div class="card-body">
                            <%if((boolean) request.getSession().getAttribute("cliente").equals("administrador")){ %>
                                <form class="form-horizontal form-material" action="mostrarAdministradores" method="post">
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Nombre</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="nombre" name="nombre" required> </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label for="example-email" class="col-md-12 p-0">Primer apellido</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="apellido1" name="apellido1" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Segundo apellido</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text" class="form-control p-0 border-0" id="apellido2" name="apellido2" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">DNI</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="dni" name="dni" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Email</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="email"
                                                class="form-control p-0 border-0" id="email" name="email"required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Direccion</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="direccion" name="direccion">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Provincia</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="provincia" name="provincia">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Localidad</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="localidad" name="localidad">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Telefono</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="tel"
                                                class="form-control p-0 border-0" id="telefono" name="telefono">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Contraseña</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="password"
                                                class="form-control p-0 border-0" id="clave" name="clave">
                                        </div>
                                    </div>
                                     <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Repetir contraseña</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="password"
                                                class="form-control p-0 border-0" id="claveRepetir" name="claveRepetir">
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <div class="col-sm-12">
                                            <button type="submit" class="btn btn-success">Crear usuario</button>
                                        </div>
                                    </div>
                                </form>
                                <%}else if((boolean) request.getSession().getAttribute("cliente").equals("empleado")){ %>
                                <form class="form-horizontal form-material" action="mostrarEmpleados" method="post">
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Nombre</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="nombre" name="nombre" required> </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label for="example-email" class="col-md-12 p-0">Primer apellido</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="apellido1" name="apellido1" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Segundo apellido</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text" class="form-control p-0 border-0" id="apellido2" name="apellido2" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">DNI</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="dni" name="dni" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Email</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="email"
                                                class="form-control p-0 border-0" id="email" name="email"required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Direccion</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="direccion" name="direccion">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Provincia</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="provincia" name="provincia">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Localidad</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="localidad" name="localidad">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Telefono</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="tel"
                                                class="form-control p-0 border-0" id="telefono" name="telefono">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Contraseña</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="password"
                                                class="form-control p-0 border-0" id="clave" name="clave">
                                        </div>
                                    </div>
                                     <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Repetir contraseña</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="password"
                                                class="form-control p-0 border-0" id="claveRepetir" name="claveRepetir">
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <div class="col-sm-12">
                                            <button type="submit" class="btn btn-success">Crear usuario</button>
                                        </div>
                                    </div>
                                </form>
                                <%}else if((boolean) request.getSession().getAttribute("cliente").equals("cliente")){ %>
<form class="form-horizontal form-material" action="mostrarUsuarios" method="post">
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Nombre</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="nombre" name="nombre" required> </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label for="example-email" class="col-md-12 p-0">Primer apellido</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="apellido1" name="apellido1" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Segundo apellido</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text" class="form-control p-0 border-0" id="apellido2" name="apellido2" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">DNI</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="dni" name="dni" required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Email</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="email"
                                                class="form-control p-0 border-0" id="email" name="email"required>
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Direccion</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="direccion" name="direccion">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Provincia</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="provincia" name="provincia">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Localidad</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="text"
                                                class="form-control p-0 border-0" id="localidad" name="localidad">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Telefono</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="tel"
                                                class="form-control p-0 border-0" id="telefono" name="telefono">
                                        </div>
                                    </div>
                                        <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Contraseña</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="password"
                                                class="form-control p-0 border-0" id="clave" name="clave">
                                        </div>
                                    </div>
                                     <div class="form-group mb-4">
                                        <label class="col-md-12 p-0">Repetir contraseña</label>
                                        <div class="col-md-12 border-bottom p-0">
                                            <input type="password"
                                                class="form-control p-0 border-0" id="claveRepetir" name="claveRepetir">
                                        </div>
                                    </div>
                                    <div class="form-group mb-4">
                                        <div class="col-sm-12">
                                            <button type="submit" class="btn btn-success">Crear usuario</button>
                                        </div>
                                    </div>
                                </form>
                                <%} %>
                            </div>
                        </div>
                    <!-- Column -->
                <!-- Row -->
                <!-- ============================================================== -->
                <!-- End PAge Content -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Right sidebar -->
                <!-- ============================================================== -->
                <!-- .right-sidebar -->
                <!-- ============================================================== -->
                <!-- End Right sidebar -->
                <!-- ============================================================== -->
            </div>
            <!-- ============================================================== -->
            <!-- End Container fluid  -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- footer -->
            <!-- ============================================================== -->
            <footer class="footer text-center"> 2021 Â© Ample Admin brought to you by <a
                    href="https://www.wrappixel.com/">wrappixel.com</a>
            </footer>
            <!-- ============================================================== -->
            <!-- End footer -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Page wrapper  -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <script src="plugins/bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src="bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <script src="js/app-style-switcher.js"></script>
    <!--Wave Effects -->
    <script src="js/waves.js"></script>
    <!--Menu sidebar -->
    <script src="js/sidebarmenu.js"></script>
    <!--Custom JavaScript -->
    <script src="js/custom.js"></script>
<script>
    // Función para validar que el nombre contenga solo letras
    function validarNombre() {
        var nombreInput = document.getElementById('nombre');
        var nombre = nombreInput.value;

        var regex = /^[a-zA-Z]+$/;

        if (!regex.test(nombre)) {
            nombreInput.setCustomValidity("El nombre debe contener solo letras.");
        } else {
            nombreInput.setCustomValidity("");
        }
    }

    // Función para validar que el primer apellido contenga solo letras
    function validarPrimerApellido() {
        var apellido1Input = document.getElementById('apellido1');
        var apellido1 = apellido1Input.value;

        var regex = /^[a-zA-Z]+$/;

        if (!regex.test(apellido1)) {
            apellido1Input.setCustomValidity("El primer apellido debe contener solo letras.");
        } else {
            apellido1Input.setCustomValidity("");
        }
    }

    // Función para validar que el segundo apellido contenga solo letras
    function validarSegundoApellido() {
        var apellido2Input = document.getElementById('apellido2');
        var apellido2 = apellido2Input.value;

        var regex = /^[a-zA-Z]+$/;

        if (!regex.test(apellido2)) {
            apellido2Input.setCustomValidity("El segundo apellido debe contener solo letras.");
        } else {
            apellido2Input.setCustomValidity("");
        }
    }

    // Función para validar que el DNI tenga 8 dígitos y una letra
    function validarDNI() {
        var dniInput = document.getElementById('dni');
        var dni = dniInput.value;

        var regex = /^\d{8}[a-zA-Z]$/;

        if (!regex.test(dni)) {
            dniInput.setCustomValidity("El DNI debe tener 8 dígitos seguidos de una letra.");
        } else {
            dniInput.setCustomValidity("");
        }
    }

    // Función para validar que el teléfono sea numérico
    function validarTelefono() {
        var telefonoInput = document.getElementById('telefono');
        var telefono = telefonoInput.value;

        var regex = /^\d+$/;

        if (!regex.test(telefono)) {
            telefonoInput.setCustomValidity("El teléfono debe contener solo números.");
        } else {
            telefonoInput.setCustomValidity("");
        }
    }
    
    // Función para validar que las contraseñas coincidan
    var passwordField = document.getElementById("clave");
    var confirmPasswordField = document.getElementById("claveRepetir");

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

    // Vincular las funciones de validación a los eventos blur de los campos respectivos
    document.getElementById('nombre').addEventListener("blur", validarNombre);
    document.getElementById('apellido1').addEventListener("blur", validarPrimerApellido);
    document.getElementById('apellido2').addEventListener("blur", validarSegundoApellido);
    document.getElementById('dni').addEventListener("blur", validarDNI);
    document.getElementById('telefono').addEventListener("blur", validarTelefono);

    // Vincular las funciones de validación de contraseñas a los eventos blur de los campos respectivos
    passwordField.addEventListener("blur", validatePasswordFields);
    confirmPasswordField.addEventListener("blur", validatePasswordFields);
</script>
</body>

</html>