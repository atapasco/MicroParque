using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace ClassLibrary
{
    public class TallerService
    {
        private TallerRepository tallerRepository;
        public TallerService()
        {
            tallerRepository = new TallerRepository();
        }

        public String Guardar(InscripcionTaller inscripcionTaller)
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
    }
}
