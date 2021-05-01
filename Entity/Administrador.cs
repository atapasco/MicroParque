using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Administrador
    {
        public string Usuario { set; get; }
        public string Contraseña { set; get; }
        public int Fila { set; get; }
        public Administrador()
        {

        }

        public bool ValidacionDeUsuario (List<string> usuarios, string usuario)
        {
            foreach (string item in usuarios)
            {
                this.Fila++;
                if (usuario.Equals(item))
                {
                    this.Usuario = usuario;
                    return true;
                }
            }
            return false;
        }

        public bool ValidacionDeContraseña(List<string> contraseñas, string contraseña)
        {
            int i = 0;
            foreach (string item in contraseñas)
            {
                i++;
                if (contraseña.Equals(item) && i==Fila)
                {
                    return true;
                }
            }
            return false;
        } 
    }
}
