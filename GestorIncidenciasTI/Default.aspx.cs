using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestorIncidenciasTI.Models;

namespace GestorIncidenciasTI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            List<Incidencia> incidencias;

            if (Session["Incidencias"] == null)
            {
                incidencias = new List<Incidencia>();
            }
            else
            {
                incidencias = (List<Incidencia>)Session["Incidencias"];
            }

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

            incidencias.Add(nuevaIncidencia);

            Session["Incidencias"] = incidencias;

            lblMensaje.Text = "La incidencia fue registrada correctamente.";
            lblMensaje.CssClass = "alert alert-success d-block";

            LimpiarFormulario();
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