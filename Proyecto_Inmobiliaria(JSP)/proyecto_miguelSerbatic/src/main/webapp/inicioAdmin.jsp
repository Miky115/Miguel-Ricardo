<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"
    import="model.VO.PedidoVO, model.VO.MostrarValoracionVO , java.util.ArrayList, java.util.List, java.text.SimpleDateFormat" %>
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
        <link href="plugins/bower_components/chartist/dist/chartist.min.css" rel="stylesheet">
        <link rel="stylesheet"
            href="plugins/bower_components/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.css">
        <!-- Custom CSS -->
        <link href="css/style.min.css" rel="stylesheet">
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
            <%@include file="headerAdmin.jsp" %>
                <!-- ============================================================== -->
                <!-- End Topbar header -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Left Sidebar - style you can find in sidebar.scss  -->
                <!-- ============================================================== -->
                <%@include file="barraLateralAdmin.jsp" %>
                    <!-- ============================================================== -->
                    <!-- End Left Sidebar - style you can find in sidebar.scss  -->
                    <!-- ============================================================== -->
                    <!-- ============================================================== -->
                    <!-- Page wrapper  -->
                    <!-- ============================================================== -->
                    <div class="page-wrapper">
                        <!-- ============================================================== -->
                        <!-- Bread crumb and right sidebar toggle -->
                        <!-- ============================================================== -->
                        <div class="page-breadcrumb bg-white">
                            <div class="row align-items-center">
                                <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                                    <h4 class="page-title">Inicio</h4>
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
                            <!-- Three charts -->
                            <!-- ============================================================== -->
                            <div class="row justify-content-center">
                                <div class="col-lg-4 col-md-12">
                                    <div class="white-box analytics-info">
                                        <h3 class="box-title">Total pedidos</h3>
                                        <ul class="list-inline two-part d-flex align-items-center mb-0">
                                            <li>
                                                <div id="sparklinedash"><canvas width="67" height="30"
                                                        style="display: inline-block; width: 67px; height: 30px; vertical-align: top;"></canvas>
                                                </div>
                                            </li>
                                            <li class="ms-auto"><span class="counter text-success">
                                                    <%=request.getAttribute("numPedidos") %>
                                                </span></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-12">
                                    <div class="white-box analytics-info">
                                        <h3 class="box-title">Total clientes</h3>
                                        <ul class="list-inline two-part d-flex align-items-center mb-0">
                                            <li>
                                                <div id="sparklinedash2"><canvas width="67" height="30"
                                                        style="display: inline-block; width: 67px; height: 30px; vertical-align: top;"></canvas>
                                                </div>
                                            </li>
                                            <li class="ms-auto"><span class="counter text-purple">
                                                    <%=request.getAttribute("numUsuarios") %>
                                                </span></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-12">
                                    <div class="white-box analytics-info">
                                        <h3 class="box-title">Total productos</h3>
                                        <ul class="list-inline two-part d-flex align-items-center mb-0">
                                            <li>
                                                <div id="sparklinedash3"><canvas width="67" height="30"
                                                        style="display: inline-block; width: 67px; height: 30px; vertical-align: top;"></canvas>
                                                </div>
                                            </li>
                                            <li class="ms-auto"><span class="counter text-info">
                                                    <%=request.getAttribute("numProductos") %>
                                                </span>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <!-- ============================================================== -->
                            <!-- PRODUCTS YEARLY SALES -->
                            <!-- ============================================================== -->
                            <div class="row">
                                <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12">
                                    <div class="white-box">
                                        <h3 class="box-title">Ventas de los últimos 5 días</h3>
                                        <div class="d-md-flex">
                                        </div>
                                        <div id="ct-visits" style="height: 405px;">
                                            <div class="chartist-tooltip" style="top: -17px; left: -12px;"><span
                                                    class="chartist-tooltip-value">6</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="card white-box p-0">
                                <div class="card-body">
                                    <h3 class="box-title mb-0">Valoraciones recientes</h3>
                                </div>
                                  <% for (MostrarValoracionVO valoracion : (List<MostrarValoracionVO>)request.getAttribute("valoraciones")) { %>
    <div class="comment-widgets">
        <div class="d-flex flex-row comment-row p-3 mt-0">
            <div class="comment-text ps-2 ps-md-3 w-100">
                <h5 class="font-medium"><%=valoracion.getNombre() %> <%= valoracion.getApellido1() %> <%= valoracion.getApellido2() %> (<%=valoracion.getProducto()%>)</h5>
                <div class="comment-footer d-md-flex align-items-center">
                    <!-- Estrellas -->
                    <div class="d-inline-block">
                        <% int valoracionNum = valoracion.getValoracion(); %>
                        <%-- Estrellas amarillas --%>
                        <% for(int i = 0; i < valoracionNum; i++) { %>
                            <i class="fa fa-star text-warning"></i>
                        <% } %>
                        <%-- Estrellas grises (restantes) --%>
                        <% for(int i = valoracionNum; i < 5; i++) { %>
                            <i class="fa fa-star text-secondary"></i>
                        <% } %>
                    </div>
                </div>
                <span class="mb-3 d-block"><%=valoracion.getComentario() %></span>
            </div>
        </div>
    </div>
<% } %>

                                
                            </div>
                        </div>
                        <!-- ============================================================== -->
                        <!-- End Container fluid  -->
                        <!-- ============================================================== -->
                        <!-- ============================================================== -->
                        <!-- footer -->
                        <!-- ============================================================== -->
                        <footer class="footer text-center"> 2024 © CasaDecor</footer>
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
        <script src="plugins/bower_components/jquery-sparkline/jquery.sparkline.min.js"></script>
        <!--Wave Effects -->
        <script src="js/waves.js"></script>
        <!--Menu sidebar -->
        <script src="js/sidebarmenu.js"></script>
        <!--Custom JavaScript -->
        <script src="js/custom.js"></script>
        <!--This page JavaScript -->
        <!--chartis chart-->
        <script src="plugins/bower_components/chartist/dist/chartist.min.js"></script>
        <script src="plugins/bower_components/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.min.js"></script>
        <script>
            /*
            Template Name: Admin Pro Admin
            Author: Wrappixel
            Email: niravjoshi87@gmail.com
            File: js
            */
            $(function () {
                "use strict";
                // ============================================================== 
                // Newsletter
                // ============================================================== 

                // Obtener los datos de los últimos pedidos por día desde el servidor
                var fechas = [];
                var valores = [];
        <% SimpleDateFormat formatoFecha = new SimpleDateFormat("dd/MM/yyyy");
                for (PedidoVO pedido : (ArrayList < PedidoVO >)request.getAttribute("ultimosPedidos")) { %>
                    fechas.push('<%= formatoFecha.format(pedido.getFecha()) %>');
                valores.push(<%= pedido.getTotal() %>); // Aquí podrías realizar algún formateo adicional si es necesario
        <% } %>

                // Crear la gráfica Chartist con los datos de los últimos pedidos por día
                new Chartist.Line('#ct-visits', {
                    labels: fechas.reverse(), // Invertir las fechas para mostrarlas en orden descendente
                    series: [
                        valores.reverse() // Invertir los valores para que coincidan con las fechas
                    ]
                }, {
                    lineSmooth: Chartist.Interpolation.cardinal({
                        tension: 0
                    }),
                    chartPadding: {
                        right: 40
                    },
                    low: 0,
                    showArea: true, // Añadir showArea: true para mostrar el área debajo de la línea
                    fullWidth: true,
                    plugins: [
                        Chartist.plugins.tooltip()
                    ],
                    axisX: {
                        showGrid: false
                    },
                    axisY: {
                        labelInterpolationFnc: function (value) {
                            return (value / 500) * 500;
                        }
                    }
                }).on('draw', function (data) {
                    if (data.type === 'line' || data.type === 'point') {
                        data.element.attr({
                            style: 'stroke: #2cabe3'
                        });
                    } else if (data.type === 'area') {
                        data.element.attr({
                            style: 'fill: #2cabe3; opacity: 0.2'
                        });
                    }
                });

        // Código para sparklines omitido para mantener el enfoque en la gráfica Chartist
    });
        </script>
    </body>

    </html>