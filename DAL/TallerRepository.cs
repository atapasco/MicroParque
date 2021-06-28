using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class TallerRepository
    {

        public static CodificacionYEncriptacionDeTexto codificacion = new CodificacionYEncriptacionDeTexto();
        public void GuardarInscripcionesTaller(InscripcionTaller inscripcionTaller)
        {
            TextWriter escribirArchivo;
            FileStream file = new FileStream("InscripcionTaller", FileMode.Append);
            escribirArchivo = new StreamWriter(file);
            escribirArchivo.WriteLine($"{inscripcionTaller.PrimerNombre};{inscripcionTaller.SegundoNombre};{inscripcionTaller.PrimerApellido};" +
                                      $"{inscripcionTaller.SegundoApellido};{inscripcionTaller.Telefono};{inscripcionTaller.NivelAcademico};" +
                                      $"{inscripcionTaller.FormacionSuperior};{inscripcionTaller.NombreTaller};{inscripcionTaller.Correo};" +
                                      $"{inscripcionTaller.Estado}");
            escribirArchivo.Close();
        }

        public void GuardarTaller(Taller taller)
        {
            TextWriter escribirArchivo;
            FileStream file = new FileStream("Talleres", FileMode.Append);
            escribirArchivo = new StreamWriter(file);
            escribirArchivo.WriteLine($"{taller.Nombre};{taller.CantidadAsistentes};{taller.Fecha};" +
                                      $"{taller.Disponibilidad}");
            escribirArchivo.Close();
        }

        public List<Taller> ConsultaGeneralDeTalleres()
        {

            List<Taller> talleres = new List<Taller>();
            FileStream file = new FileStream("Talleres", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Taller taller = MapeadoDeTaller(linea);
                talleres.Add(taller);
            }
            reader.Close();
            file.Close();
            return talleres;
        }

        public Taller MapeadoDeTaller(String linea)
        {
            Taller taller = new Taller();
            string[] matrizTaller = linea.Split(';');
            taller.Nombre = matrizTaller[0];
            taller.CantidadAsistentes = Convert.ToInt32(matrizTaller[1]);
            taller.Fecha = Convert.ToDateTime(matrizTaller[2]);
            taller.Disponibilidad = Convert.ToBoolean(matrizTaller[3]);

            return taller;
        }

        public List<InscripcionTaller> ConsultaGeneralInscripcionTalleres()
        {
            List<InscripcionTaller> inscritos = new List<InscripcionTaller>();
            FileStream file = new FileStream("InscripcionTaller", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                InscripcionTaller inscrito = MapeadoDeInscripcionTaller(linea);
                inscritos.Add(inscrito);
            }
            reader.Close();
            file.Close();

            return inscritos;
        }

        public InscripcionTaller ConsultaPorTallerInscripcionTalleres(string nombreTaller)
        {
            List<InscripcionTaller> inscritos = new List<InscripcionTaller>();
            FileStream file = new FileStream("InscripcionTaller", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                InscripcionTaller inscrito = MapeadoDeInscripcionTaller(codificacion.DecodificacionDeCadenas(linea));
                inscritos.Add(inscrito);
            }
            reader.Close();
            file.Close();
            IEnumerable<InscripcionTaller> InscritosATalleres = from taller in inscritos where taller.NombreTaller == nombreTaller select taller;

            return InscritosATalleres.Single();
        }

        public InscripcionTaller MapeadoDeInscripcionTaller(String linea)
        {
            InscripcionTaller taller = new InscripcionTaller();
            string[] matrizTaller = linea.Split(';');
            taller.PrimerNombre = matrizTaller[0];
            taller.SegundoNombre = matrizTaller[1];
            taller.PrimerApellido = matrizTaller[2];
            taller.SegundoApellido = matrizTaller[3];
            taller.Telefono = matrizTaller[4];
            taller.NivelAcademico = matrizTaller[5];
            taller.FormacionSuperior = matrizTaller[6];
            taller.NombreTaller = matrizTaller[7];
            taller.Correo = matrizTaller[8];
            taller.Estado = matrizTaller[9];

            return taller;
        }

        public void ActualizarEstadoInscripciones(string nombreTaller, string primerNombre, string segundoNombre,
                                                  string primerApellido, string segundoApellido, string estado)
        {
            List<InscripcionTaller> inscripcionTalleres = new List<InscripcionTaller>();
            inscripcionTalleres = ConsultaGeneralInscripcionTalleres();
            FileStream file = new FileStream("InscripcionTaller", FileMode.Create);
            file.Close();
            foreach (var item in inscripcionTalleres)
            {
                if (primerNombre != item.PrimerNombre && segundoNombre != item.SegundoNombre && primerApellido != item.PrimerApellido
                    && segundoApellido != item.SegundoApellido && nombreTaller != item.NombreTaller)
                {
                    GuardarInscripcionesTaller(item);
                }
            }

            foreach (var item in inscripcionTalleres)
            {
                if (primerNombre == item.PrimerNombre && segundoNombre == item.SegundoNombre && primerApellido == item.PrimerApellido
                    && segundoApellido == item.SegundoApellido && nombreTaller == item.NombreTaller)
                {
                    item.Estado = estado;
                    GuardarInscripcionesTaller(item);
                }
            }
        }

        public bool EliminarTaller(string nombreTaller)
        {
            List<Taller> talleres = new List<Taller>();
            talleres = ConsultaGeneralDeTalleres();
            FileStream file = new FileStream("Talleres", FileMode.Create);
            file.Close();
            foreach (var item in talleres)
            {
                if (nombreTaller.Equals(item.Nombre) == false)
                {
                    GuardarTaller(item);
                }
            }

            foreach (var item in talleres)
            {
                if (nombreTaller.Equals(item.Nombre))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ModificarFechaTaller(string nombreTaller, DateTime fechaNueva)
        {
            List<Taller> talleres = new List<Taller>();
            talleres = ConsultaGeneralDeTalleres();
            FileStream file = new FileStream("Talleres", FileMode.Create);
            file.Close();
            foreach (var item in talleres)
            {
                if (nombreTaller != item.Nombre)
                {
                    GuardarTaller(item);
                }
                else if (nombreTaller == item.Nombre)
                {
                    item.Fecha = fechaNueva;
                    GuardarTaller(item);
                }
            }

            foreach (var item in talleres)
            {
                if (nombreTaller == item.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public bool VerificacionDeExistenciaNombreTaller(string nombreTaller)
        {
            List<Taller> talleres = new List<Taller>();
            talleres = ConsultaGeneralDeTalleres();
            FileStream file = new FileStream("Talleres", FileMode.Create);
            file.Close();
            foreach (var item in talleres)
            {
                if (item.Nombre.Equals(nombreTaller))
                {
                    return true;
                }
            }

            return false;
        }

        public Taller SeleccionTaller(string nombreTaller)
        {
            List<Taller> talleres = new List<Taller>();
            talleres = ConsultaGeneralDeTalleres();
            foreach (var item in talleres)
            {
                if (item.Nombre.Equals(nombreTaller))
                {
                    return item;
                }
            }

            return null;
        }

        public void ActualizarConteoDeParticipantesTaller()
        {
            List<Taller> talleres = new List<Taller>();
            talleres = ConsultaGeneralDeTalleres();
            List<InscripcionTaller> inscripcionTalleres = new List<InscripcionTaller>();
            inscripcionTalleres = ConsultaGeneralInscripcionTalleres();
            FileStream file = new FileStream("Talleres", FileMode.Create);
            file.Close();
            IEnumerable<InscripcionTaller> conteo;
            foreach (var item in talleres)
            {
                conteo = from inscripcionTaller in inscripcionTalleres where inscripcionTaller.Estado == "ACEPTADO" && item.Nombre == inscripcionTaller.NombreTaller select inscripcionTaller;
                item.CantidadAsistentes = conteo.Count();
                GuardarTaller(item);
            }
        }

        public List<InscripcionTaller> FiltroPorEstadoYTaller(string estado, string tallerNombre)
        {
            List<InscripcionTaller> inscripcionTalleresAux = new List<InscripcionTaller>();
            List<InscripcionTaller> inscripcionTalleres = new List<InscripcionTaller>();
            inscripcionTalleres = ConsultaGeneralInscripcionTalleres();
            foreach (var item in inscripcionTalleres)
            {
                if (item.Estado == estado && tallerNombre == item.NombreTaller)
                {
                    inscripcionTalleresAux.Add(item);
                }
            }

            return inscripcionTalleresAux;
        

        }
    }
}
