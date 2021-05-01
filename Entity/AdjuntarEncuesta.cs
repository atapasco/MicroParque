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
        public FileStream Encuesta { set; get; }
        public string Tipo { set; get; }
        public List<string> preguntas { set; get; }
        public List<string> respuestas { set; get; }

        
        public AdjuntarEncuesta(FileStream encuesta, string tipo)
        {
            this.Encuesta = encuesta;
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
