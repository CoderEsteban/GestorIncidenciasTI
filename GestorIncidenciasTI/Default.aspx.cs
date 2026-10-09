using System;
using System.Collections.Generic;
using System.Web.UI;
using GestorIncidenciasTI.Models;

namespace GestorIncidenciasTI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // La tabla se carga al abrir la página.
            if (!IsPostBack)
            {
                CargarIncidencias();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación adicional en el servidor.
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(ddlCategoria.SelectedValue) ||
                string.IsNullOrWhiteSpace(ddlImpacto.SelectedValue) ||
                string.IsNullOrWhiteSpace(ddlUrgencia.SelectedValue) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                lblMensaje.Text = "Debe completar todos los campos.";
                lblMensaje.CssClass = "alert alert-danger d-block";
                return;
            }

            // Obtener la lista de incidencias de la sesión.
            List<Incidencia> incidencias = ObtenerIncidencias();

            // Crear la nueva incidencia.
            Incidencia nuevaIncidencia = new Incidencia
            {
                Id = incidencias.Count + 1,
                Titulo = txtTitulo.Text.Trim(),
                Categoria = ddlCategoria.SelectedValue,
                Impacto = ddlImpacto.SelectedValue,
                Urgencia = ddlUrgencia.SelectedValue,
                Descripcion = txtDescripcion.Text.Trim(),
                FechaRegistro = DateTime.Now
            };

            // Agregar la incidencia a la lista.
            incidencias.Add(nuevaIncidencia);

            // Guardar nuevamente la lista en Session.
            Session["Incidencias"] = incidencias;

            // Mostrar mensaje de confirmación.
            lblMensaje.Text = "La incidencia fue registrada correctamente.";
            lblMensaje.CssClass = "alert alert-success d-block";

            // Limpiar formulario.
            LimpiarFormulario();

            // Actualizar la tabla.
            CargarIncidencias();

            // Actualización parcial del UpdatePanel.
            upIncidencias.Update();
        }

        private List<Incidencia> ObtenerIncidencias()
        {
            // Si no existe una lista en Session se crea una nueva.
            if (Session["Incidencias"] == null)
            {
                Session["Incidencias"] = new List<Incidencia>();
            }

            return (List<Incidencia>)Session["Incidencias"];
        }

        private void CargarIncidencias()
        {
            List<Incidencia> incidencias = ObtenerIncidencias();

            gvIncidencias.DataSource = incidencias;
            gvIncidencias.DataBind();
        }

        private void LimpiarFormulario()
        {
            txtTitulo.Text = "";
            ddlCategoria.SelectedIndex = 0;
            ddlImpacto.SelectedIndex = 0;
            ddlUrgencia.SelectedIndex = 0;
            txtDescripcion.Text = "";
        }
    }
}