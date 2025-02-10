<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"
    import="model.VO.ProductoVO, java.util.HashMap, java.text.DecimalFormat"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
            <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
    <link rel="stylesheet" type="text/css" href="css\carro.css">
    <style>
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
        .wrapper {
            min-height: 100%;
            display: flex;
            flex-direction: column;
        }
        .content {
            flex: 1;
        }
        .footer {
            flex-shrink: 0;
        }
    </style>
</head>
<body>
    <%@include file="cabecera.jsp"%>
    
    <div class="wrapper">
        <div class="content">
            <form action="compra?inicio=compra">
                <h1 class="carrito">CARRITO</h1>
                <div class="contenedor">  
                    <% if (carrito != null && carrito.size() >= 1) {
                        double total = 0;
                        double totalIva = 0;
                        double iva = 0;
                        DecimalFormat df = new DecimalFormat("#.##");
                     
                        for (HashMap.Entry<ProductoVO, Integer> entry : carrito.entrySet()) {
                            ProductoVO producto = entry.getKey();
                            int cantidad = entry.getValue();
                            total += producto.getPrecio() * cantidad;
                            iva = total * producto.getImpuestos();
                    %>

                    <div class="product-container">
                        <img class="product-image" src="<%=producto.getImagen()%>">
                        <div class="product-details">
                            <p class="product-name"><%=producto.getNombre()%></p>
                            <div class="product-actions">
                                <a class="action restar" href="quitarCantidad?id=<%=producto.getId()%>">-</a>
                                <label class="product-quantity"><%=cantidad%></label>
                                <% if (cantidad == producto.getStock()) { %>
                                    <p style="color:red;">¡Lo sentimos! No puedes añadir más este producto, no tiene más stock.</p>
                                <% } else if (cantidad > producto.getStock()) { %>
                                    <p style="color:red;">¡Lo sentimos! No puedes añadir más este producto, reduzca la cantidad comprada ya que se ha pasado del stock</p>
                                <% } else { %>
                                    <a class="action aniadir" href="AniadirCarritoServlet?id=<%=producto.getId()%>">+</a>
                                <% } %>
                            </div>
                            <a class="action quitar" href="QuitarCarritoServlet?id=<%=producto.getId()%>">Eliminar</a>
                        </div>
                        <p class="product-price"><%=producto.getPrecio()%>€</p>
                    </div>

                    <% }
                        totalIva = total + iva;
                        String numeroFormateado = df.format(total);
                        String numeroFormateadoIva = df.format(totalIva);
                    %>
                    <div class="total-container">
<p><strong>Total sin IVA: <%= numeroFormateado%>€</strong></p>
<p><strong style="font-size: 2em;">Total: <%= numeroFormateadoIva%>€</strong></p>
                        <button class="buy-button" type="submit">Comprar</button>
                    </div>
                </div>
            <% } else if(carrito == null || carrito.isEmpty()){ %>
                <div class="carrito-vacio">
                    <h3>Tu carrito está vacío</h3>   
                    <p>Explora multitud de artículos a buen precio desde nuestra página principal</p>
                </div>
            <% } %>
            </form>
        </div>
        <!-- Footer -->
        <div class="footer">
            <%@include file="piePagina.jsp"%>
        </div>
    </div>
</body>
</html>
