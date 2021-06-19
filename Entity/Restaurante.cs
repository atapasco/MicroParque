using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Restaurante
    {
        public string Nombre { set; get; }
        public string NombreDelAdministrador { set; get; }
        public string Ubicacion { set; get; }
        public int CantidadDeEmpleados { set; get; }
        public string Gatronomia { set; get; }
        public string HorarioDeAtencion { set; get; }
        public string Telefono { set; get; }
        public string Correo { set; get; }

        public Restaurante(string nombre, string administrador, string ubicacion, 
                           string gastronomia, string horarioDeAtencion, string Telefono, string correo)
        {
            this.Nombre = nombre;
            this.NombreDelAdministrador = administrador;
            this.Ubicacion = ubicacion;
            this.Gatronomia = gastronomia;
            this.HorarioDeAtencion = horarioDeAtencion;
            this.Telefono = Telefono;
            this.Correo = correo;
        }

        public Restaurante()
        {

        }

        public void ConteoCantidadDeEmpleados()
        {
            this.CantidadDeEmpleados++;
        }
    }
}
