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
        public Administrador()
        {

        }

        public bool ValidacionDeUsuario (List<Administrador> usuarios, string usuario)
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

        public bool ValidacionDeContraseña(string contraseña)
        {
            if (contraseña.Equals(this.Contraseña))
            {
                return true;
            }
            return false;
        } 
    }
}
