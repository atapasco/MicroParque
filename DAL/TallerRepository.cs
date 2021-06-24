using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class TallerRepository
    {
        public void GuardarInscripcionesTaller(InscripcionTaller inscripcionTaller)
        {
            CodificacionYEncriptacionDeTexto codificacion = new CodificacionYEncriptacionDeTexto();

            TextWriter escribirArchivo;
            FileStream file = new FileStream("InscripcionTaller", FileMode.Create);
            escribirArchivo = new StreamWriter(file);
            escribirArchivo.WriteLine(codificacion.CodificacionDeCadenas($"{inscripcionTaller.PrimerNombre};{inscripcionTaller.SegundoNombre};{inscripcionTaller.PrimerApellido}" +
                                      $"{inscripcionTaller.SegundoApellido};{inscripcionTaller.Telefono};{inscripcionTaller.NivelAcademico}" +
                                      $"{inscripcionTaller.FormacionSuperior};{inscripcionTaller.NombreTaller};{inscripcionTaller.Correo}" +
                                      $"{inscripcionTaller.Estado}"));
            escribirArchivo.Close();
        }
    }
}
