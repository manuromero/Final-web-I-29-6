using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class ServicioAutoPres : System.Web.UI.Page
    {
        IngresoNego ingresoNego = new IngresoNego();
        ServicioAutoNego servicioNego = new ServicioAutoNego();

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
            HdfIdIngreso.Value = idIngreso.ToString();
            dataTable = ingresoNego.ListarIngresoId(idIngreso);
            LblNomAp.Text = dataTable.Rows[0]["nombreApellido"].ToString();
            LblAutoCliente.Text = dataTable.Rows[0]["autoIngresado"].ToString();
        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarServicio();
        }

        public void GuardarServicio()
        {
            ServicioAuto servicioAuto = new ServicioAuto();
            servicioAuto.IdIngreso =int.Parse(HdfIdIngreso.Value);
            servicioAuto.CambioAceite = CbxAceite.Checked;
            servicioAuto.CambioFiltro = CbxFiltro.Checked;
            servicioAuto.Reparaciones = TxtReparaciones.Text;
            servicioAuto.Observaciones = TxtObsevaciones.Text;
            servicioNego.GuardarServicio(servicioAuto);
        }


        protected void BtnListar_Click(object sender, EventArgs e)
        {
            GdvServicio.DataSource = servicioNego.ListarServicios();
            GdvServicio.DataBind();
        }
    }
}