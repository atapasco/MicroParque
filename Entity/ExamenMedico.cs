using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entity
{
    public class ExamenMedico
    {
        public FileStream Resultado { set; get; }
        public string Aprovacion { set; get; }
        
        public ExamenMedico(FileStream resultado, string aprovacion)
        {
            this.Resultado = resultado;
            this.Aprovacion = aprovacion;
        }
    }
}
