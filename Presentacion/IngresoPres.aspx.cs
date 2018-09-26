using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class IngresoPres : System.Web.UI.Page
    {
        IngresoNego ingresoNego = new IngresoNego();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarIngreso();
        }

        public void GuardarIngreso()
        {
            Ingreso ingreso = new Ingreso();
            ingreso.NombreApellido = TxtNomAp.Text;
            ingreso.Dni = int.Parse(TxtDocumento.Text);
            ingreso.AutoIngresado = TxtAutoIngresado.Text;
            ingreso.FechaIngreso = Convert.ToDateTime(TxtFechaIngreso.Text);
            ingresoNego.GuardarIngreso(ingreso);
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarIngresos();
        }

        public void ListarIngresos()
        {
            GdvIngresos.DataSource = ingresoNego.ListarIngresos();
            GdvIngresos.DataBind();
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            Button btnSelect = (sender as Button);
            string commandArgument = btnSelect.CommandArgument;
            GridViewRow row = (btnSelect.NamingContainer as GridViewRow);
            int rowIndex = row.RowIndex;
            Response.Redirect("~/EditarIngreso.aspx?idIngreso=" + commandArgument);
        }

        protected void BtnServicio_Click(object sender, EventArgs e)
        {
            Button btnSelect = (sender as Button);
            string commandArgument = btnSelect.CommandArgument;
            GridViewRow row = (btnSelect.NamingContainer as GridViewRow);
            int rowIndex = row.RowIndex;
            Response.Redirect("~/ServicioAutoPres.aspx?idIngreso=" + commandArgument);
        }
    }
}