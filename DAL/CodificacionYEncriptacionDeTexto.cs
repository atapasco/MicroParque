using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL
{
    public class CodificacionYEncriptacionDeTexto
    {
        public String CodificacionDeCadenas(string cadena)
        {
            String mensajeCodificado = null;
            byte[] cadenaCodificada = System.Text.Encoding.Unicode.GetBytes(cadena);
            mensajeCodificado = Convert.ToBase64String(cadenaCodificada);

            return mensajeCodificado;
        }

        public String DecodificacionDeCadenas(string cadena)
        {
            String mensajeDecodificado = null;
            byte[] cadenaDecodificada = Convert.FromBase64String(cadena);
            mensajeDecodificado = System.Text.Encoding.Unicode.GetString(cadenaDecodificada);

            return mensajeDecodificado;
        }

        public string EncriptarContraseña(string contraseña)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(contraseña));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("(0:x2)", stream[i]);
            }

            return sb.ToString();
        }
    }
}
