using Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ServicioAutoRepo
    {
        String cnn = ConfigurationManager.ConnectionStrings["ConeccionASQL"].ConnectionString;
        public void GuardarServicio(ServicioAuto servicio)
        {
            SqlConnection conn = new SqlConnection(cnn);
            String sql = "insert into servicioAuto(idIngreso,cambioAceite,cambioFiltro,reparaciones,observaciones) Values(@val1,@val2,@val3,@val4,@val5)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val1", servicio.IdIngreso);
                cmd.Parameters.AddWithValue("@val2", servicio.CambioAceite);
                cmd.Parameters.AddWithValue("@val3", servicio.CambioFiltro);
                cmd.Parameters.AddWithValue("@val4", servicio.Reparaciones);
                cmd.Parameters.AddWithValue("@val5", servicio.Observaciones);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "error ";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ListarServicios()
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(cnn);
            String sql = "select i.nombreApellido, i.autoIngresado,i.fechaIngreso,s.cambioFiltro,s.cambioAceite,s.reparaciones,s.observaciones from ingreso as i join servicioAuto as s on i.idIngreso=s.idIngreso";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
    }
}
