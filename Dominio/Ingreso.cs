using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ingreso
    {
        private int idIngreso;
        private String nombreApellido;
        private int dni;
        private String autoIngresado;
        private DateTime fechaIngreso;

      

        public string NombreApellido
        {
            get
            {
                return nombreApellido;
            }

            set
            {
                nombreApellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string AutoIngresado
        {
            get
            {
                return autoIngresado;
            }

            set
            {
                autoIngresado = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        public Ingreso()
        {
        }
        public Ingreso(int idIngreso, string nombreApellido, int dni, string autoIngresado, DateTime fechaIngreso)
        {
            this.idIngreso = idIngreso;
            this.nombreApellido = nombreApellido;
            this.dni = dni;
            this.autoIngresado = autoIngresado;
            this.fechaIngreso = fechaIngreso;
        }
    }
}
