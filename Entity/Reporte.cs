using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reporte
    {
        public int CantidadEncuestados { set; get; }
        public int InscritosATalleres { set; get; }
        public int TalleresRealizadosMensualmente { set; get; }
        public int TalleresRealizadosAnualmente { set; get; }
        public int PersonasConExamnesActualizados { set; get; }
        public int NumeroDeRestaurantes { set; get; }
        public int NumeroDeEncuestas { set; get; }

        public Reporte()
        {
        }

        public void ConteoCantidadEncuestados()
        {
            this.CantidadEncuestados = CantidadEncuestados + 1;
        }

        public void ConteoInscritosATalleres()
        {
            this.InscritosATalleres = InscritosATalleres + 1;
        }

        public void ConteoTalleresRealizadosMensualmente()
        {
            this.TalleresRealizadosMensualmente = TalleresRealizadosMensualmente + 1;
        }

        public void ConteoTalleresRealizadosAnualmente()
        {
            this.TalleresRealizadosAnualmente = TalleresRealizadosAnualmente + 1;
        }

        public void ConteoPersonasConExamnesActualizados()
        {
            this.PersonasConExamnesActualizados = PersonasConExamnesActualizados + 1;
        }

        public void ConteoNumeroDeRestaurantes()
        {
            this.NumeroDeRestaurantes = NumeroDeRestaurantes + 1;
        }

        public void ConteoNumeroDeEncuestas()
        {
            this.NumeroDeEncuestas = NumeroDeEncuestas + 1;
        }
    }
}
