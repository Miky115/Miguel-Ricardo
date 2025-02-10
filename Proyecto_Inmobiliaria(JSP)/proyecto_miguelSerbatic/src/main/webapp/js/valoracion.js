document.addEventListener("DOMContentLoaded", function() {
    const stars = document.querySelectorAll(".star");
    const valoracionInput = document.getElementById("valoracion");
    const form = document.getElementById("formValoracion");

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
        if (parseInt(valoracionInput.value) === 0) {
            alert("Por favor, valora el producto antes de enviar.");
            event.preventDefault(); // Evitar que el formulario se envíe si las estrellas están vacías
        }
    });
});
