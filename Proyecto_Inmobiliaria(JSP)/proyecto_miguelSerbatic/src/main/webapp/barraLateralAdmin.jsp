<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"
    import = "model.VO.UsuarioVO"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
</head>
<body>
                        <%UsuarioVO admin = (UsuarioVO) request.getSession().getAttribute("usuarioGuardado");%>
        <aside class="left-sidebar" data-sidebarbg="skin6">
            <!-- Sidebar scroll-->
            <div class="scroll-sidebar">
                <!-- Sidebar navigation-->
                <nav class="sidebar-nav">
                    <ul id="sidebarnav">
                        <!-- User Profile-->
                        <%if(admin.getRolId() == 3 || admin.getRolId() == 4){ %>
                        <li class="sidebar-item pt-2">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="inicioAdmin"
                                aria-expanded="false">
                                <i class="far fa-clock" aria-hidden="true"></i>
                                <span class="hide-menu">Inicio</span>
                            </a>
                        </li>
                        <%} %>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="mostrarUsuarios"
                                aria-expanded="false">
                                <i class="fas fa-users" aria-hidden="true"></i>
                                <span class="hide-menu">Clientes</span>
                            </a>
                        </li>
                        <%if(admin.getRolId() == 3 || admin.getRolId() == 4){ %>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="mostrarEmpleados"
                                aria-expanded="false">
                                <i class="far fa-address-book" aria-hidden="true"></i>
                                <span class="hide-menu">Empleados</span>
                            </a>
                        </li>
                        <%} %>
                        <%if(admin.getRolId() == 4){ %>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="mostrarAdministradores"
                                aria-expanded="false">
                                <i class="fas fa-user-secret" aria-hidden="true"></i>
                                <span class="hide-menu">Administradores</span>
                            </a>
                        </li>
                        <%} %>
                          <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="mostrarProveedores"
                                aria-expanded="false">
                                <i class="fas fa-dolly" aria-hidden="true"></i>
                                <span class="hide-menu">Proveedores</span>
                            </a>
                        </li>
                         <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="mostrarProductos"
                                aria-expanded="false">
                                <i class="fas fa-dolly-flatbed" aria-hidden="true"></i>
                                <span class="hide-menu">Productos</span>
                            </a>
                        </li>

                         <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="mostrarPedidos"
                                aria-expanded="false">
                                <i class="fas fa-cart-plus" aria-hidden="true"></i>
                                <span class="hide-menu">Pedidos</span>
                            </a>
                        </li>
                         <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="mostrarCategorias"
                                aria-expanded="false">
                                <i class="fas fa-gift" aria-hidden="true"></i>
                                <span class="hide-menu">Categorias</span>
                            </a>
                        </li>
                          <%if(admin.getRolId() == 3 || admin.getRolId() == 4){ %>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="editarConfiguracion"
                                aria-expanded="false">
                                <i class="fas fa-cog" aria-hidden="true"></i>
                                <span class="hide-menu">Configuración</span>
                            </a>
                        </li>
                        <%} %>
                        <li class="text-center p-20 upgrade-btn">
                            <a href="cerrar"
                                class="btn d-grid btn-danger text-white">
                                Cerrar Sesion</a>
                        </li>
                    </ul>

                </nav>
                <!-- End Sidebar navigation -->
            </div>
            <!-- End Sidebar scroll-->
        </aside>
</body>
</html>