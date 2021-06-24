using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entity
{
    public class AdjuntarEncuesta
    {
        public string NombreDeArchivoEncuesta { set; get; }
        public string Tipo { set; get; }
        public List<string> preguntas { set; get; }
        public List<string> respuestas { set; get; }

        
        public AdjuntarEncuesta(string encuesta, string tipo)
        {
            this.NombreDeArchivoEncuesta = encuesta;
            this.Tipo = tipo;
        }
        public AdjuntarEncuesta()
        {

        }

        public void FormulacionDePreguntas(string pregunta)
        {
            this.preguntas.Add(pregunta);
        }

        public void AñadirRespuestas(string respuesta)
        {
            this.respuestas.Add(respuesta);
        }
    }
}
