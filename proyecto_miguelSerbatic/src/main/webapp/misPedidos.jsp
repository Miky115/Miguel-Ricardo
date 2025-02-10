<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"
    import="java.util.ArrayList, model.VO.PedidoVO, java.text.DecimalFormat, model.VO.DetallesPedidoVO, model.VO.ProductoVO, model.DAO.ProductoDAO, model.DAO.DetallesPedidoDAO"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
<link rel="stylesheet" type="text/css" href="css/misPedidos.css">
</head>
<body>
<%@include file="cabecera.jsp"%>
<div class="contenedor">
    <div class="filtros">
        <a href="PedidosASC">Fecha ascendente</a>
        <a href="PedidosDESC">Fecha descendente</a>
    </div>
    <div class="pedidos">
        <%
        DecimalFormat df2 = new DecimalFormat("#.##");
        ArrayList<PedidoVO> pedidos = (ArrayList<PedidoVO>) request.getAttribute("pedidos");
        if (pedidos != null && !pedidos.isEmpty()) {
            for (PedidoVO pedido : pedidos) {
                String numeroFormateado = df2.format(pedido.getTotal());
        %>
        <div class="pedido">
            <div class="pedido-info">
                <div class="pedido-detalle">
                    Pedido: <%=pedido.getFecha()%>
                </div>
                <div class="pedido-estado">
                    Estado: <%=pedido.getEstado()%>
                </div>
                <div class="pedido-factura">
                    Número de Factura: <%=pedido.getNumFactura()%>
                </div>
                <div class="pedido-total">
                    Total: <%=numeroFormateado%>€
                </div>
                <div class="ver-factura-btn">
                  <%if(pedido.getEstado().equals("pendiente envío")){ %>
				<a href="peticionCancelacion?id=<%=pedido.getId()%>">Cancelar pedido</a>
				<%}else if(pedido.getEstado().equals("enviado")){ %>
                    <a href="verFactura?id=<%=pedido.getId()%>" target="_blank">Ver factura</a>
                    <%} %>
                </div>
                
            </div>
            <hr class="linea-separadora">
            <div class="detalles-pedido">
                <%
                DecimalFormat df3 = new DecimalFormat("#.##");
                DecimalFormat df = new DecimalFormat("#.##");
                ArrayList<DetallesPedidoVO> detalles = DetallesPedidoDAO.getDetallesPedido(pedido.getId());
                if (detalles != null && !detalles.isEmpty()) {
                    for (DetallesPedidoVO detalle : detalles) {
                        ProductoVO producto = ProductoDAO.obtenerPorId(detalle.getIdProducto());
                        String numeroFormateadoDetalle2 = df3.format(detalle.getImpuesto());
                        String numeroFormateadoDetalle = df.format(detalle.getTotal());
                %>
                <div class="detalle-producto">
                    <div class="imagen-producto">
                        <img src="<%=producto.getImagen()%>" alt="Imagen del producto">
                    </div>
                    <div class="info-producto">
                        <div class="nombre-producto">
                            <%=producto.getNombre()%>
                        </div>
                        <div class="precio-producto">
                            Precio Unidad: <%=detalle.getPrecioUnidad()%>€
                        </div>
                        <div class="impuesto-producto">
                            Impuesto: <%=numeroFormateadoDetalle2%>€
                        </div>
                        <div class="cantidad-producto">
                            Cantidad: <%=detalle.getUnidades()%>
                        </div>
                       
                         <div class="eliminar-producto">
                          <%if (pedido.getEstado().equals("enviado")){ %>
                        <a href="valoracion.jsp?idProducto=<%=producto.getId()%>&idUsuario=<%=usuario.getId()%>" class="eliminar-link">Valorar producto</a>
                         <%} %>
                                                  <%if (pedido.getEstado().equals("pendiente envío")){ %>
                        <a href="eliminarLinea?id=<%=detalle.getId()%>" class="eliminar-link">Eliminar</a>
                                            <%} %>
                    </div>

                    </div>
                    <div class="precio-total">
                        <%=numeroFormateadoDetalle%>€
                    </div>
                </div>
                 <hr class="linea-separadora">
                <% 
                    }
                } else {
                %>
                <div class="sin-detalles">No hay detalles de pedido registrados</div>
                <% 
                } 
                %>
            </div>
        </div>
        <% 
            }
        } else {
        %>
        <div class="sin-pedidos">No hay pedidos registrados</div>
        <% 
        } 
        %>
    </div>
</div>
<%@include file="piePagina.jsp"%>
</body>
</html>
