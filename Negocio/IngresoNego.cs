using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class IngresoNego
    {
        IngresoRepo ingresoRepo = new IngresoRepo();
        public void GuardarIngreso(Ingreso ingreso)
        {
            ingresoRepo.GuardarIngreso(ingreso);
        }

        public DataTable ListarIngresos()
        {
            return ingresoRepo.ListarIngreso();
        }

        public DataTable ListarIngresoId(int idIngreso)
        {
            return ingresoRepo.ListarIngresoId(idIngreso);
        }

        public void UpdateIngreso(int idIngreso, Ingreso ingreso)
        {
            ingresoRepo.UpdateIngreso(idIngreso, ingreso);
        }
    }
}
