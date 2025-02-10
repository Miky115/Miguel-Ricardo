<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"
	import="java.util.List, model.VO.ProductoVO, java.util.HashMap, java.text.DecimalFormat"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
<link rel="stylesheet" type="text/css" href="css\comprar.css">
</head>
<body>
	<%@include file="cabecera.jsp"%>
<form action="CompraRealizada" class="contenedor" method="post" onsubmit="return validarStock();">
		<h1>PRODUCTOS LISTOS PARA LA COMPRA</h1>
			<table>
		<thead>
			<tr>
				<th colspan="2">Producto</th>
				<th>Precio</th>
				<th>Cantidad</th>
			</tr>
		</thead>
		<tbody>
		<%
		    double total = 0;
	    	double totalIva = 0;
	    	double iva = 0;
	        DecimalFormat df = new DecimalFormat("#.##");
			for (HashMap.Entry<ProductoVO, Integer> entry : carrito.entrySet()) {
				ProductoVO producto = entry.getKey();
				int cantidad = entry.getValue();
				total += producto.getPrecio()*cantidad;
				iva = total*producto.getImpuestos();
		%>
			 <tr class ="productos">
			 	<td><img src="<%=producto.getImagen()%>" alt="Imagen del producto"></td>
				<td><%=producto.getNombre()%></td>
				<td><%=producto.getPrecio()%></td>
				<td><%=cantidad%></td>
				
			</tr>
		<%
			}%>
			</tbody>
	</table>
	<%
			totalIva = total+iva;
			String numeroFormateado = df.format(total);
			String numeroFormateadoIva = df.format(totalIva);
			%>
<p><strong>Total sin IVA: <%= numeroFormateado%>€</strong></p>
<p><strong style="font-size: 2em;">Total: <%= numeroFormateadoIva%>€</strong></p>

		<h1>Información de Dirección</h1>
<label for="provincia">Provincia:</label><br>
<input type="text" name="provincia" placeholder="Provincia" <% if(usuario.getProvincia() != null) { %> value="<%=usuario.getProvincia()%>" <% } %>><br/>

<label for="localidad">Localidad:</label><br>
<input type="text" name="localidad" placeholder="Localidad" <% if(usuario.getLocalidad() != null) { %> value="<%=usuario.getLocalidad()%>" <% } %>><br/>

<label for="direccion">Dirección:</label><br>
<input type="text" name="direccion" placeholder="Dirección" <% if(usuario.getDireccion() != null) { %> value="<%=usuario.getDireccion()%>" <% } %>><br/>

<label for="telefono">Teléfono:</label><br>
<input type="tel" name="telefono" placeholder="Teléfono" <% if(usuario.getTelefono() != null) { %> value="<%=usuario.getTelefono()%>" <% } %>><br/>

<h1>Información de pago</h1>
<label for="metodo_pago">Método de Pago:</label><br>
<select id="metodo_pago" name="metodo_pago" required onchange="mostrarFormularioPago()">
    <option value="" disabled selected>Selecciona un método de pago</option>
    <option value="visa">Visa</option>
    <option value="paypal">PayPal</option>
</select><br>

<!-- Formulario para PayPal -->
<div id="paypal_form" style="display: none;">
    <label for="correo_paypal">Correo Electrónico:</label><br>
    <input type="email" id="correo_paypal" name="correo_paypal"><br>
    
    <label for="contraseña_paypal">Contraseña:</label><br>
    <input type="password" id="contraseña_paypal" name="contraseña_paypal"><br>
</div>

<!-- Resto del formulario de pago -->
<div id="otros_formularios">
<label for="numero_tarjeta">Número de Tarjeta:</label><br>
<input type="text" id="numero_tarjeta" name="numero_tarjeta" maxlength="16" onblur="validarNumeroTarjeta()"><br>

<label for="fecha_caducidad">Fecha de Caducidad:</label><br>
<input type="text" id="fecha_caducidad" name="fecha_caducidad" placeholder="MM/AA" onblur="validarFechaCaducidad()"><br>

<label for="cvv">CVV:</label><br>
<input type="text" id="cvv" name="cvv" maxlength="3" onblur="validarCVV()"><br>
</div>

<%
    boolean hayStockSuficiente = true;
    for (HashMap.Entry<ProductoVO, Integer> entry : carrito.entrySet()) {
        ProductoVO producto = entry.getKey();
        int cantidad = entry.getValue();
        if (cantidad > producto.getStock()) {
            hayStockSuficiente = false;
%>
            <p class="mensaje-error">Lo sentimos, no hay suficiente stock para <%=producto.getNombre()%>. Por favor, ajusta la cantidad.</p>
<%
        }
    }
    if (hayStockSuficiente) {
%>
        <button type="submit">Comprar</button>
<%
    }
%>

    </form>
<script>
function validarCVV() {
    var cvvInput = document.getElementById('cvv');
    var cvv = cvvInput.value;

    // Expresión regular para validar que el CVV contenga solo números
    var regex = /^[0-9]{3}$/;

    if (!regex.test(cvv)) {
        cvvInput.setCustomValidity("El CVV debe contener solo números y tener una longitud de 3 dígitos");
    } else {
        cvvInput.setCustomValidity("");
    }
}

    function validarNumeroTarjeta() {
        var numeroTarjetaInput = document.getElementById('numero_tarjeta');
        var numeroTarjeta = numeroTarjetaInput.value;

        var regex = /^[0-9]{16}$/;

        if (!regex.test(numeroTarjeta)) {
            numeroTarjetaInput.setCustomValidity("El número de tarjeta debe contener solo números y tener 16 dígitos");
        } else {
            numeroTarjetaInput.setCustomValidity("");
        }
    }

    function validarFechaCaducidad() {
        var fechaCaducidadInput = document.getElementById('fecha_caducidad');
        var fechaCaducidad = fechaCaducidadInput.value;

        var regex = /^(0[1-9]|1[0-2])\/\d{2}$/;

        if (!regex.test(fechaCaducidad)) {
            fechaCaducidadInput.setCustomValidity("El formato de la fecha de caducidad debe ser MM/AA");
        } else {
            fechaCaducidadInput.setCustomValidity("");
        }
    }

    function mostrarFormularioPago() {
        var metodoPago = document.getElementById("metodo_pago").value;
        var paypalForm = document.getElementById("paypal_form");
        var otrosFormularios = document.getElementById("otros_formularios");

        if (metodoPago === "paypal") {
            paypalForm.style.display = "block";
            otrosFormularios.style.display = "none";
        } else {
            paypalForm.style.display = "none";
            otrosFormularios.style.display = "block";
        }

        // Restaurar la validez personalizada
        document.getElementById("numero_tarjeta").setCustomValidity("");
        document.getElementById("fecha_caducidad").setCustomValidity("");
    }
</script>

        <%@include file="piePagina.jsp"%>
</body>
</html>