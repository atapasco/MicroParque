using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace MicroParque
{
    public partial class ListTalleres : UserControl
    {
        public ListTalleres()
        {
            InitializeComponent();
            this.BackColor = Color.White;

        }

        #region Properties
        public string nombreTaller;
        public string personasAceptadas;
        public string personasPendientes;
        public string fechayHora;
        public string opcion;

        [Category("Custom Props")]
        public void NombreTaller(string nombre)
        {
            LblNombreTaller.Text = $"{nombre}";
            this.nombreTaller = nombre;
        }

        [Category("Custom Props")]
        public void PersonasAceptadas(int PersonasAceptadas)
        {
            LblPersonasAceptadas.Text = $"Personas Aceptadas: {Convert.ToString(PersonasAceptadas)}";
        }

        [Category("Custom Props")]
        public void PersonasPendientes(int PersonasPendientes)
        {
            LblPersonasPendientes.Text = $"Personas Pendientes: {Convert.ToString(PersonasPendientes)}";
        }

        [Category("Custom Props")]
        public void FechayHora(DateTime FechaYHora)
        {
            LblFechayHora.Text = $"Fecha y Hora: {Convert.ToString(FechaYHora)}";
        }

        #endregion

        private void ListTalleres_Load(object sender, System.EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ListTalleres_MouseLeave(object sender, EventArgs e)
        {
            //this.BackColor = Color.White;
        }

        private void ListTalleres_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListTalleres_MouseEnter(object sender, EventArgs e)
        {
            //this.BackColor = Color.Silver;
        }

        private void ListTalleres_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.BackColor == Color.Silver)
            {
                this.BackColor = Color.White;
            }
            else this.BackColor = Color.Silver;
        }

        private void ListTalleres_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.opcion = "Abrir";
        }
    }
}
