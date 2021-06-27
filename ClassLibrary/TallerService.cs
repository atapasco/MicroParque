using DAL;
using Entity;
using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;

namespace BLL
{
    public class TallerService
    {
        private TallerRepository tallerRepository;
        private TallerTryCach tallerTryCach;
        private InscripcionTalleresTryCach inscripcionTalleresTryCach;
        public TallerService()
        {
            tallerRepository = new TallerRepository();
        }

        public string GuardarInscripcionesTaller(InscripcionTaller inscripcionTaller)
        {
            try
            {
                tallerRepository.GuardarInscripcionesTaller(inscripcionTaller);
                return "se guardo correctamente";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        public TallerTryCach SeleccionarTaller(string nombreTaller)
        {

            try
            {
                tallerTryCach = new TallerTryCach(tallerRepository.SeleccionTaller(nombreTaller));

                return tallerTryCach;
            }
            catch (Exception e)
            {
                tallerTryCach = new TallerTryCach($"Error: {e.Message}");

                return tallerTryCach;
            }
        }

        public string GuardarTaller(Taller taller)
        {
            try
            {
                tallerRepository.GuardarTaller(taller);
                return "se guardo correctamente";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        public TallerTryCach ConsultaGeneralDeTalleres()
        {
            try
            {
                tallerTryCach = new TallerTryCach(tallerRepository.ConsultaGeneralDeTalleres());

                return tallerTryCach;
            }
            catch (Exception e)
            {
                tallerTryCach = new TallerTryCach($"Error: {e.Message}");

                return tallerTryCach;
            }

        }

        public InscripcionTalleresTryCach ConsultaGeneralInscripcionTalleres()
        {
            try
            {
                inscripcionTalleresTryCach = new InscripcionTalleresTryCach(tallerRepository.ConsultaGeneralInscripcionTalleres());

                return inscripcionTalleresTryCach;
            }
            catch (Exception e)
            {
                inscripcionTalleresTryCach = new InscripcionTalleresTryCach($"Error: {e.Message}");

                return inscripcionTalleresTryCach;
            }

        }

        public InscripcionTalleresTryCach ConsultaPorTallerInscripcionTalleres(string nombreTaller)
        {
            try
            {
                inscripcionTalleresTryCach = new InscripcionTalleresTryCach(tallerRepository.ConsultaPorTallerInscripcionTalleres(nombreTaller));

                return inscripcionTalleresTryCach;
            }
            catch (Exception e)
            {
                inscripcionTalleresTryCach = new InscripcionTalleresTryCach($"Error: {e.Message}");

                return inscripcionTalleresTryCach;
            }
        }

        public string ActualizarEstadoInscripciones(string nombreTaller, string primerNombre, string segundoNombre,
                                                  string primerApellido, string segundoApellido, string estado)
        {
            try
            {
                tallerRepository.ActualizarEstadoInscripciones(nombreTaller, primerNombre, segundoNombre, primerApellido,
                                                               segundoApellido, estado);
                return "se actualizo el estado";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        public string EliminarTaller(string nombreTaller)
        {
            try
            {
                tallerRepository.EliminarTaller(nombreTaller);
                
                return "El taller se elimino exitosamente";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        public string ModificarFechaTaller(string nombreTaller, DateTime fechaNueva)
        {
            try
            {
                if (tallerRepository.ModificarFechaTaller(nombreTaller, fechaNueva))
                {
                    return "Se actualizo la fecha o hora";
                }
                else
                {
                    return "No se pudo actualizar";
                }
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        public string VerificacionDeExistenciaNombreTaller(string nombreTaller)
        {
            try
            {
                if (tallerRepository.VerificacionDeExistenciaNombreTaller(nombreTaller))
                {
                    return "Este taller ya existe";
                }
                else
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        public string ActualizarConteoDeParticipantesTaller()
        {
            try
            {
                tallerRepository.ActualizarConteoDeParticipantesTaller();
                return "contenido actualizado";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }

        public InscripcionTalleresTryCach FiltroPorEstadoYTaller(string estado, string nombreTaller)
        {
            try
            {
                inscripcionTalleresTryCach = new InscripcionTalleresTryCach(tallerRepository.FiltroPorEstadoYTaller(estado, nombreTaller));

                return inscripcionTalleresTryCach;
            }
            catch (Exception e)
            {
                inscripcionTalleresTryCach = new InscripcionTalleresTryCach($"Error: {e.Message}");

                return inscripcionTalleresTryCach;
            }
        }

        public string EnvioDeCorreo(string correo, string mensaje, string tituloMensaje)
        {
            string correoDelMicroParque = "atapasco@unicesar.edu.co";
            string NombreDelCorreo = "MicroParque";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correoDelMicroParque, NombreDelCorreo);
                mail.To.Add(correo);

                mail.Subject = tituloMensaje;
                mail.Body = mensaje;
                mail.IsBodyHtml = false;


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                client.Credentials = new NetworkCredential(correoDelMicroParque, "lossauces123");
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false


                client.Send(mail);
                return "";
            }
            catch (Exception e)
            {
                return $"Error: {e}";
            }
        }

        public class InscripcionTalleresTryCach
        {
            public InscripcionTaller Taller { get; set; }
            public List<InscripcionTaller> Talleres { get; set; }
            public string MensajeError { get; set; }

            public InscripcionTalleresTryCach(InscripcionTaller taller)
            {
                this.Taller = taller;
                this.Talleres = null;
                this.MensajeError = null;
            }
            public InscripcionTalleresTryCach(List<InscripcionTaller> talleres)
            {
                this.Taller = null;
                this.Talleres = talleres;
                this.MensajeError = null;
            }
            public InscripcionTalleresTryCach(string MensajeError)
            {
                this.Taller = null;
                this.Talleres = null;
                this.MensajeError = MensajeError;
            }
        }

        public class TallerTryCach
        {
            public Taller Taller { set; get; }
            public List<Taller> Talleres { set; get; }
            public string MensajeError { set; get; }

            public TallerTryCach(Taller taller)
            {
                this.Taller = taller;
                this.MensajeError = null;
                this.Talleres = null;
            }

            public TallerTryCach(string mensajeError)
            {
                this.Taller = null;
                this.MensajeError = mensajeError;
                this.Talleres = null;
            }

            public TallerTryCach(List<Taller> talleres)
            {
                this.Talleres = talleres;
                this.Taller = null;
                this.MensajeError = null;
            }
        }
    }
}
