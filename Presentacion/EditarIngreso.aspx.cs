using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;

namespace Presentacion
{
    public partial class EditarIngreso : System.Web.UI.Page
    {
        IngresoNego ingresoNego = new IngresoNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["idIngreso"] != null)
                {
                    int idIngreso = int.Parse(Request.QueryString["idIngreso"]);
                    CargarDatosIngreso(idIngreso);

                }
            }
        }

        public void CargarDatosIngreso(int idIngreso)
        {
            DataTable dataTable = new DataTable();
            dataTable = ingresoNego.ListarIngresoId(idIngreso);
            HdfIdIngreso.Value = dataTable.Rows[0]["idIngreso"].ToString();
            TxtNomAp.Text = dataTable.Rows[0]["nombreApellido"].ToString();
            TxtDocumento.Text = dataTable.Rows[0]["dni"].ToString();
            TxtAutoIngresado.Text = dataTable.Rows[0]["autoIngresado"].ToString();
            TxtFechaIngreso.Text = dataTable.Rows[0]["fechaIngreso"].ToString();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        public void GuardarCambios()
        {
            int idIngreso = int.Parse(HdfIdIngreso.Value);
            Ingreso ingreso = new Ingreso();
            ingreso.NombreApellido = TxtNomAp.Text;
            ingreso.Dni = int.Parse(TxtDocumento.Text);
            ingreso.AutoIngresado = TxtAutoIngresado.Text;
            ingreso.FechaIngreso = Convert.ToDateTime(TxtFechaIngreso.Text);
            ingresoNego.UpdateIngreso(idIngreso, ingreso);
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/IngresoPres.aspx");
        }
    }
}