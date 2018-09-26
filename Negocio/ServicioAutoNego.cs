using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioAutoNego
    {
        ServicioAutoRepo servicioRepo = new ServicioAutoRepo();
        public void GuardarServicio(ServicioAuto servicio)
        {
            servicioRepo.GuardarServicio(servicio);
        }

        public DataTable ListarServicios()
        {
            return servicioRepo.ListarServicios();
        }
    }
}
