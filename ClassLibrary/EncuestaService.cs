using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace ClassLibrary
{
    public class EncuestaService
    {

        private EncuestaRepository encuestaRepository;
        public EncuestaService()
        {
            encuestaRepository = new EncuestaRepository();
        }

        public AdjuntarEncuestas ConsultarPreguntasYrespuestas(string nombreArchivo)
        {
            AdjuntarEncuestas encuestas;
            try
            {
                encuestas = new AdjuntarEncuestas(encuestaRepository.ConsultarPreguntasYRespuestas(nombreArchivo));
                return encuestas;
            }
            catch (Exception e)
            {
                encuestas = new AdjuntarEncuestas($"Error: {e}");
                return encuestas;
            }
        }

        public AdjuntarEncuestas ConsultarNombresDeLosArchivo()
        {
            AdjuntarEncuestas encuestas;
            try
            {
                encuestas = new AdjuntarEncuestas(encuestaRepository.ConsultarNombresDeLosArchivo());
                return encuestas;
            }
            catch (Exception e)
            {
                encuestas = new AdjuntarEncuestas($"Error: {e}");
                return encuestas;
            }
        }

        public class AdjuntarEncuestas
        {
            public AdjuntarEncuesta AdjuntarEncuesta { set; get; }
            public List<AdjuntarEncuesta> AdjuntarNombreEncuestas { set; get; }
            public string MensajeDeError { set; get; }

            public AdjuntarEncuestas(AdjuntarEncuesta adjuntarEncuesta)
            {
                this.AdjuntarEncuesta = adjuntarEncuesta;
                this.MensajeDeError = null;
                this.AdjuntarNombreEncuestas = null;
            }
            public AdjuntarEncuestas(string mensajeDeError)
            {
                this.MensajeDeError = mensajeDeError;
                this.AdjuntarEncuesta = null;
                this.AdjuntarNombreEncuestas = null;
            }
            public AdjuntarEncuestas(List<AdjuntarEncuesta> adjuntarNombreEncuesta)
            {
                this.AdjuntarNombreEncuestas = adjuntarNombreEncuesta;
                this.AdjuntarEncuesta = null;
                this.MensajeDeError = null;
            }
            public AdjuntarEncuestas()
            {

            }
        }
    }
}
