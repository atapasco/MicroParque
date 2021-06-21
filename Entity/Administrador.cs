﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Entity
{
    public class Administrador
    {
        public string Usuario { set; get; }
        public string Contraseña { set; get; }
        public string Correo { set; get; }
        public List<DateTime> FechaDeIngreso{ set; get; }

     
        public Administrador()
        {
        }

        public bool ComprobacionDeExistenciaDeUsuario (List<Administrador> usuarios, string usuario)
        {
            foreach (Administrador item in usuarios)
            {
                if (usuario.Equals(item.Usuario))
                {
                    this.Usuario = usuario;
                    this.Contraseña = item.Contraseña;
                    return true;
                }
            }
            return false;
        }

        public bool CompararContraseñaExistente (string contraseña)
        {
            if (contraseña.Equals(this.Contraseña))
            {
                return true;
            }
            return false;
        }

        public void CrearCuenta(string usuario, string contraseña, string correo)
        {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
            this.Correo = correo;
        }

        public bool ValidarCreacionDeUsuario(string usuario)
        {
            int largoDeCadena = 0;
            char[] usuarioConvertidoEnCadena = {};

            largoDeCadena = usuario.Length;
            usuarioConvertidoEnCadena = usuario.ToCharArray();

            for (int i = 0; i <= largoDeCadena - 1; i++)
            {
                if ((usuarioConvertidoEnCadena[i] >= 48 && usuarioConvertidoEnCadena[i] <= 57) || (usuarioConvertidoEnCadena[i] >= 65 && usuarioConvertidoEnCadena[i] <= 90)
                    || (usuarioConvertidoEnCadena[i] >= 97 && usuarioConvertidoEnCadena[i] <= 122))
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidarCreacionDeContraseña(string contraseña)
        {
            int i = 0;
            bool validarMayuscula = false;
            bool validarMinuscula = false;
            bool validarNumero = false;

            for (i = 48; i <= 57; i++)
            {
                validarNumero = contraseña.Contains(Convert.ToChar(i));
            }
            for (i = 65; i <= 90; i++)
            {
                validarMayuscula = contraseña.Contains(Convert.ToChar(i));
            }
            for (i = 97; i <= 122; i++)
            {
                validarMinuscula = contraseña.Contains(Convert.ToChar(i));
            }

            if(validarMayuscula == true && validarMinuscula == true && validarNumero == true && contraseña.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string EnvioDeCorreo()
        {
            string mensaje = null;
            string correoDelMicroParque = "atapasco@unicesar.edu.co";
            string NombreDelCorreo = "MicroParque";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correoDelMicroParque, NombreDelCorreo);
                mail.To.Add(this.Correo);

                mail.Subject = "INTENTO DE INGRESO";
                mail.Body = $"Usuario {this.Usuario} Alguien esta intentando entrar a tu cuenta, direeccion ip: {SacarIp()}";
                mail.IsBodyHtml = false;


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                client.Credentials = new NetworkCredential(correoDelMicroParque, "lossauces123");
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false


                client.Send(mail);
                mensaje = "se ha enviado un correo por exceder los 10 intentos";

            }
            catch (Exception e)
            {
                return $"Error: {e}";
            }

            return mensaje;
        }

        static string SacarIp()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            return localIP;
        }
    }
}
