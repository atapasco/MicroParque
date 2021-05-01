using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InscripcionTaller
    {
        public string PrimerNombre { set; get; }
        public string SegundoNombre { set; get; }
        public string PrimerApellido { set; get; }
        public string SegundoApellido { set; get; }
        public string Telefono { set; get; }
        public string NivelAcademico { set; get; }
        public string FormacionSuperior { set; get; }
        public string NombreTaller { set; get; }
        public string Correo { set; get; }
        public string Estado { set; get; }

        
        public InscripcionTaller(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido,
                                 string telefono, string nivelAcademico, string formacionSuperior,
                                 string nombreTaller, string correo, string estado){
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.Telefono = telefono;
            this.NivelAcademico = nivelAcademico;
            this.FormacionSuperior = FormacionSuperior;
            this.NombreTaller = nombreTaller;
            this.Correo = correo;
            this.Estado = estado;

        }
        public InscripcionTaller()
        {

        }

    }
}
