using System.ComponentModel;
using System.Windows.Forms;

namespace MicroParque
{
    public partial class ListTalleres : UserControl
    {
        public ListTalleres()
        {
            InitializeComponent();

        }

        #region Properties
        public string nombreTaller;
        public string personasAceptadas;
        public string personasPendientes;
        public string fechayHora;

        [Category("Custom Props")]
        public string NombreTaller
        {
            get { return nombreTaller; }
            set { nombreTaller = value; LblNombreTaller.Text = value; }
        }

        [Category("Custom Props")]
        public string PersonasAceptadas
        {
            get { return personasAceptadas; }
            set { personasAceptadas = value; LblPersonasAceptadas.Text = value; }
        }

        [Category("Custom Props")]
        public string PersonasPendientes
        {
            get { return nombreTaller; }
            set { nombreTaller = value; LblPersonasPendientes.Text = value; }
        }

        [Category("Custom Props")]
        public string FechayHora
        {
            get { return fechayHora; }
            set { fechayHora = value; LblFechayHora.Text = value; }
        }

        #endregion

    }
}
