using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Taller
    {
        public string Nombre { set; get; }
        public int CantidadAsistentes { set; get; }
        public DateTime Fecha { set; get; }
        public DateTime Hora { set; get; }
        public bool Disponibilidad { set; get; }

        public Taller(string nombre, int cantidadAsistentes, DateTime fecha,
                      DateTime hora, bool disponibilidad)
        {
            this.Nombre = nombre;
            this.CantidadAsistentes = cantidadAsistentes;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Disponibilidad = disponibilidad;
        }
        public Taller()
        {

        }

        public void ActualizarCantidadAsistentes()
        {
            this.CantidadAsistentes = CantidadAsistentes + 1; 
        }
    }
}
