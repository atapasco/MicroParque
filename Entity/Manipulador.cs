using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Manipulador
    {
        public string Identificacion { set; get; }
        public string PrimerNombre { set; get; }
        public string SegundoNombre { set; get; }
        public string PrimerApellido { set; get; }
        public string SegundoApellido { set; get; }
        public string Telefono { set; get; }
        public string hojaDeVida { set; get; }
        public string correo { set; get; }

        private Restaurante restaurante;

        public Manipulador(string identificacion, string primerNombre, string segundoNombre,
                           string primerApellido, string segundoApellido, string telefono,
                           string hojaDeVida, string correo){
            this.Identificacion = identificacion;
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.Telefono = telefono;
            this.hojaDeVida = hojaDeVida;
            this.correo = correo;
            restaurante.ConteoCantidadDeEmpleados();
        }

        public Manipulador()
        {

        }

        public void ActualizarHojaDeVida(string hojaDeVida)
        {
            this.hojaDeVida = hojaDeVida;
        }


    }
}
