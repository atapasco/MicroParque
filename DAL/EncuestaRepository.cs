using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class EncuestaRepository
    {
        public void GuardarNombreEncuestas(AdjuntarEncuesta nombreEncuesta)
        {
            CodificacionYEncriptacionDeTexto codificacion = new CodificacionYEncriptacionDeTexto();

            TextWriter escribirArchivo;
            FileStream file = new FileStream("Encuestas", FileMode.Create);
            escribirArchivo = new StreamWriter(file);
            escribirArchivo.WriteLine(codificacion.CodificacionDeCadenas($"{nombreEncuesta.NombreDeArchivoEncuesta};" +
                                      $"{nombreEncuesta.Tipo}"));
            escribirArchivo.Close();
        }

        public void GuardarPreguntasYRespuestas(AdjuntarEncuesta adjuntarEncuesta)
        {
            CodificacionYEncriptacionDeTexto codificacion = new CodificacionYEncriptacionDeTexto();
            GuardarNombreEncuestas(adjuntarEncuesta);

            TextWriter escribirArchivo;
            FileStream file = new FileStream(adjuntarEncuesta.NombreDeArchivoEncuesta, FileMode.Create);
            escribirArchivo = new StreamWriter(file);
            escribirArchivo.WriteLine(codificacion.CodificacionDeCadenas($"{adjuntarEncuesta.NombreDeArchivoEncuesta};" +
                                      $"{adjuntarEncuesta.Tipo}"));
            foreach (var item in adjuntarEncuesta.preguntas)
            {
                escribirArchivo.Write(codificacion.CodificacionDeCadenas($"{adjuntarEncuesta.preguntas};"));
            }
            escribirArchivo.WriteLine("\n");
            foreach (var item in adjuntarEncuesta.respuestas)
            {
                escribirArchivo.Write(codificacion.CodificacionDeCadenas($"{adjuntarEncuesta.respuestas};"));
            }

            escribirArchivo.Close();
        }

        public List<AdjuntarEncuesta> ConsultarNombresDeLosArchivo()
        {
            CodificacionYEncriptacionDeTexto decodificacion = new CodificacionYEncriptacionDeTexto();
            List<AdjuntarEncuesta> nombreEncuestas = new List<AdjuntarEncuesta>();
            FileStream file = new FileStream("Encuestas", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                AdjuntarEncuesta nombreEncuesta = MapeadoDeNombreDeArchivo(linea);
                nombreEncuestas.Add(nombreEncuesta);
            }
            reader.Close();
            file.Close();
            return nombreEncuestas;
        }

        public AdjuntarEncuesta MapeadoDeNombreDeArchivo(string linea)
        {
            AdjuntarEncuesta nombreEncuesta = new AdjuntarEncuesta();
            string[] matrizPersona = linea.Split(';');
            nombreEncuesta.NombreDeArchivoEncuesta = matrizPersona[0];
            nombreEncuesta.Tipo = matrizPersona[1];

            return nombreEncuesta;
        }

        public AdjuntarEncuesta ConsultarPreguntasYRespuestas(string nombreDeArchivo)
        {
            CodificacionYEncriptacionDeTexto Decodificacion = new CodificacionYEncriptacionDeTexto();

            int i = 0;
            AdjuntarEncuesta adjuntarEncuesta = new AdjuntarEncuesta();
            FileStream file = new FileStream(nombreDeArchivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            String linea = String.Empty; 
            while ((linea = reader.ReadLine()) != null)
            {    
                i++;
                if (i == 1)
                {
                    adjuntarEncuesta.NombreDeArchivoEncuesta = MapeadoDePrimeraLinea(Decodificacion.DecodificacionDeCadenas(linea)).NombreDeArchivoEncuesta;
                    adjuntarEncuesta.Tipo = MapeadoDePrimeraLinea(linea).Tipo;
                }
                if (i == 2)
                {
                    adjuntarEncuesta.preguntas = MapeadoDePreguntas(Decodificacion.DecodificacionDeCadenas(linea));
                }
                if (i == 3)
                {
                    adjuntarEncuesta.respuestas = MapeadoDeRespuestas(Decodificacion.DecodificacionDeCadenas(linea));
                }
            }
            reader.Close();
            file.Close();
            return adjuntarEncuesta;
        }

        public AdjuntarEncuesta MapeadoDePrimeraLinea(string linea)
        {
            AdjuntarEncuesta adjuntarEncuesta = new AdjuntarEncuesta();
            string[] matrizEncuesta = linea.Split(';');
            adjuntarEncuesta.NombreDeArchivoEncuesta = matrizEncuesta[0];
            adjuntarEncuesta.Tipo = matrizEncuesta[1];

            return adjuntarEncuesta;
        }

        public List<string> MapeadoDePreguntas(String linea)
        {
            List<string> preguntas = new List<string>();
            string[] matrizPreguntas = linea.Split(';');
            foreach (var item in matrizPreguntas)
            {
                preguntas.Add(item);
            }
            return preguntas;
        }

        public List<string> MapeadoDeRespuestas(String linea)
        {
            List<string> respuestas = new List<string>();
            string[] matrizRespuestas = linea.Split(';');
            foreach (var item in matrizRespuestas)
            {
                respuestas.Add(item);
            }
            return respuestas;
        }
    }
}
