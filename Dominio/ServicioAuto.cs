using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ServicioAuto
    {
        private int idServicioAuto;
        private int idIngreso;
        private bool cambioAceite;
        private bool cambioFiltro;
        private String reparaciones;
        private String observaciones;

        public int IdIngreso
        {
            get
            {
                return idIngreso;
            }

            set
            {
                idIngreso = value;
            }
        }

        public bool CambioAceite
        {
            get
            {
                return cambioAceite;
            }

            set
            {
                cambioAceite = value;
            }
        }

        public bool CambioFiltro
        {
            get
            {
                return cambioFiltro;
            }

            set
            {
                cambioFiltro = value;
            }
        }

        public string Reparaciones
        {
            get
            {
                return reparaciones;
            }

            set
            {
                reparaciones = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }

            set
            {
                observaciones = value;
            }
        }

        public ServicioAuto()
        {
        }

        public ServicioAuto(int idServicioAuto, int idIngreso, bool cambioAceite, bool cambioFiltro, string reparaciones, string observaciones)
        {
            this.idServicioAuto = idServicioAuto;
            this.idIngreso = idIngreso;
            this.cambioAceite = cambioAceite;
            this.cambioFiltro = cambioFiltro;
            this.reparaciones = reparaciones;
            this.observaciones = observaciones;
        }
    }
}
