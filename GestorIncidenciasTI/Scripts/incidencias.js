function validarIncidencia() {

    var errores = [];

    // Obtener los valores mediante jQuery
    var titulo = $("#txtTitulo").val().trim();
    var categoria = $("#ddlCategoria").val();
    var impacto = $("#ddlImpacto").val();
    var urgencia = $("#ddlUrgencia").val();
    var descripcion = $("#txtDescripcion").val().trim();

    // Validación del título
    if (titulo === "") {
        errores.push("Debe ingresar el título de la incidencia.");
    }
    else if (titulo.length < 5) {
        errores.push("El título debe tener al menos 5 caracteres.");
    }

    // Validación de categoría
    if (categoria === "") {
        errores.push("Debe seleccionar una categoría.");
    }

    // Validación de impacto
    if (impacto === "") {
        errores.push("Debe seleccionar el impacto.");
    }

    // Validación de urgencia
    if (urgencia === "") {
        errores.push("Debe seleccionar la urgencia.");
    }

    // Validación de descripción
    if (descripcion === "") {
        errores.push("Debe ingresar una descripción.");
    }
    else if (descripcion.length < 10) {
        errores.push("La descripción debe tener al menos 10 caracteres.");
    }

    // Si existen errores se muestran y se detiene el envío
    if (errores.length > 0) {

        $("#mensajeValidacion")
            .html(errores.join("<br>"))
            .show();

        return false;
    }

    // Ocultar mensajes anteriores
    $("#mensajeValidacion").hide();

    return true;
}