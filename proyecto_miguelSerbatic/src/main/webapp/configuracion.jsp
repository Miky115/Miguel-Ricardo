<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"
    import = "model.VO.UsuarioVO, model.VO.ProveedorVO"%>
<!DOCTYPE html>
<html dir="ltr" lang="en">

<head>
    <meta charset="utf-8">
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
                        <h4 class="page-title">Configuración</h4>
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
                      <div class="row">
                    <!-- Column -->
                    <!-- Column -->
                    <div class="col-lg-4 col-xlg-3 col-md-12">
                        <div class="white-box">
                            <div class="user-bg"> <img width="100%" alt="user" src="plugins/images/muebles.jpeg">
                                <div class="overlay-box">
                                    <div class="user-content">
                                        <a href="javascript:void(0)"><img src="<%=logo %>"
                                                class="thumb-lg img-circle" alt="img"></a>
                                        <h4 class="text-white mt-2"><%=nombre %></h4>
                                        <h5 class="text-white mt-2"><%=email %></h5>
                                    </div>
                                </div>
                            </div>
                            <div class="user-btm-box mt-5 d-md-flex">
                                <div class="col-md-4 col-sm-4 text-center">
        <h1><%= telefono.substring(0, 3) %></h1>
    </div>
    <div class="col-md-4 col-sm-4 text-center">
        <h1><%= telefono.substring(3, 6) %></h1>
    </div>
    <div class="col-md-4 col-sm-4 text-center">
        <h1><%= telefono.substring(telefono.length() - 3) %></h1>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Column -->
                    <!-- Column -->
                    <div class="col-lg-8 col-xlg-9 col-md-12">
                        <div class="card">
                            <div class="card-body">
                              <form class="form-horizontal form-material" action="editarConfiguracion" method="post">
    <div class="form-group mb-4">
        <label class="col-md-12 p-0">Nombre</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="text" class="form-control p-0 border-0" id="nombre" name="nombre" value="<%=nombre%>" required>
        </div>
    </div>
    <div class="form-group mb-4">
        <label class="col-md-12 p-0">Dirección</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="text" class="form-control p-0 border-0" id="direccion" name="direccion" value="<%=direccion%>">
        </div>
    </div>
    <div class="form-group mb-4">
        <label class="col-md-12 p-0">Localidad</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="text" class="form-control p-0 border-0" id="localidad" name="localidad" value="<%=localidad%>">
        </div>
    </div>
    <div class="form-group mb-4">
        <label class="col-md-12 p-0">Provincia</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="text" class="form-control p-0 border-0" id="provincia" name="provincia" value="<%=provincia%>">
        </div>
    </div>
    <div class="form-group mb-4">
        <label class="col-md-12 p-0">Teléfono</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="tel" class="form-control p-0 border-0" id="telefono" name="telefono" value="<%=telefono%>" onblur="validarTelefono()">
        </div>
    </div>
    <div class="form-group mb-4">
        <label class="col-md-12 p-0">CIF</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="text" class="form-control p-0 border-0" id="cif" name="cif" value="<%=cif%>" onblur="validarCIF()">
        </div>
    </div>
    <div class="form-group mb-4">
        <label class="col-md-12 p-0">Email</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="email" class="form-control p-0 border-0" id="email" name="email" value="<%=email%>" required>
        </div>
    </div>
        <div class="form-group mb-4">
        <label class="col-md-12 p-0">Logo (insertar URL)</label>
        <div class="col-md-12 border-bottom p-0">
            <input type="text" class="form-control p-0 border-0" id="logo" name="logo" value="<%=logo%>">
        </div>
    </div>
    <div class="form-group mb-4">
        <div class="col-sm-12">
            <button type="submit" class="btn btn-success">Actualizar empresa</button>
        </div>
    </div>
</form>
<script>
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

    // Función para validar que el CIF empiece por una letra y tenga 7 números
    function validarCIF() {
        var cifInput = document.getElementById('cif');
        var cif = cifInput.value;

        var regex = /^[A-Za-z]\d{7}$/;

        if (!regex.test(cif)) {
            cifInput.setCustomValidity("El CIF debe empezar por una letra y tener 7 números.");
        } else {
            cifInput.setCustomValidity("");
        }
    }
</script>


                            </div>
                        </div>
                        </div>
                    <!-- Column -->
                    </div>
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
            <footer class="footer text-center"> 2024 © CasaDecor
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
</body>

</html>