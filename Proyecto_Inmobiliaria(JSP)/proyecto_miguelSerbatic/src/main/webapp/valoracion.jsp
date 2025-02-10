<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>CasaDecor</title>
    <link rel="icon" type="image/png" sizes="16x16" href="plugins/images/casaDecorIcono.png">
    <link rel="stylesheet" href="css/valoracion.css">
</head>
<body>
<%@include file = "cabecera.jsp" %>
<div class="contenedor">
    <h1>Valoración</h1>
    <form id="valoracionForm" action="valorarProducto" method="post">
        <input type="hidden" name="id_Producto" value="<%=request.getParameter("idProducto")%>">
        <input type="hidden" name="id_Usuario" value="<%=request.getParameter("idUsuario")%>">
        <label for="valoracion">Valoración:</label>
        <div class="stars" id="stars">
            <span class="star" data-value="1">&#9733;</span>
            <span class="star" data-value="2">&#9733;</span>
            <span class="star" data-value="3">&#9733;</span>
            <span class="star" data-value="4">&#9733;</span>
            <span class="star" data-value="5">&#9733;</span>
        </div>
        <input type="hidden" id="valoracion" name="valoracion">
        <label for="comentario">Comentario:</label>
        <textarea id="comentario" name="comentario" rows="4" required></textarea>
        <button type="submit">Enviar</button>
    </form>
</div>
<%@include file = "piePagina.jsp" %>
<script>
document.addEventListener("DOMContentLoaded", function() {
    const stars = document.querySelectorAll(".star");
    const valoracionInput = document.getElementById("valoracion");
    const form = document.getElementById("valoracionForm"); // Cambiado aquí

    stars.forEach(star => {
        star.addEventListener("mouseover", function() {
            let value = parseInt(star.getAttribute("data-value"));
            highlightStars(value);
        });

        star.addEventListener("mouseout", function() {
            let value = parseInt(valoracionInput.value);
            highlightStars(value);
        });

        star.addEventListener("click", function() {
            let value = parseInt(star.getAttribute("data-value"));
            valoracionInput.value = value;
            highlightStars(value);
        });
    });

    function highlightStars(value) {
        stars.forEach(star => {
            if (parseInt(star.getAttribute("data-value")) <= value) {
                star.classList.add("active");
            } else {
                star.classList.remove("active");
            }
        });
    }

    form.addEventListener("submit", function(event) {
        let selectedValue = parseInt(valoracionInput.value);
        if (!selectedValue) { // Verificar si el valor no es un número o es cero
            alert("Por favor, valora el producto antes de enviar.");
            event.preventDefault(); // Evitar que el formulario se envíe si las estrellas están vacías
        }
    });
});
</script>
</body>
</html>
