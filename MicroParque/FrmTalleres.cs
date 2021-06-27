using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MicroParque
{
    public partial class FrmTalleres : Form
    {
        private string opcion;
        private int cantidadTalleres;
        public string nombreTallerSeleccionado = string.Empty;
        private ListTalleres[] listTalleres;
        private TallerService tallerService;
        public FrmTalleres()
        {
            InitializeComponent();
            tallerService = new TallerService();
            timer1.Start();
        }

        private void FrmTalleres_Load(object sender, EventArgs e)
        {
            CargarTalleresControl();
            ClientSize = new Size(1011, 373);
            flowLayoutPanel1.Size = new Size(686, 373);
        }

        private void CargarTalleresControl()
        {
            List<Taller> talleres = new List<Taller>();
            List<InscripcionTaller> inscripcionTalleres = new List<InscripcionTaller>();
            talleres = tallerService.ConsultaGeneralDeTalleres().Talleres;
            cantidadTalleres = talleres.Count;
            listTalleres = new ListTalleres[100];
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < cantidadTalleres; i++)
            {
                inscripcionTalleres = tallerService.FiltroPorEstadoYTaller("PENDIENTE", talleres[i].Nombre).Talleres;
                listTalleres[i] = new ListTalleres();
                listTalleres[i].NombreTaller(talleres[i].Nombre);
                listTalleres[i].PersonasAceptadas(talleres[i].CantidadAsistentes);
                listTalleres[i].PersonasPendientes(inscripcionTalleres.Count);
                listTalleres[i].FechayHora(talleres[i].Fecha);
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(listTalleres[i]);

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cantidadTalleres; i++)
            {
                if (listTalleres[i].opcion == "Seleccionar")
                {
                    nombreTallerSeleccionado = listTalleres[i].nombreTaller;
                }

                listTalleres[i].opcion = string.Empty;
            }

            opcion = string.Empty;
            timer1.Stop();
            timer1.Interval = 1;
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            tallerService.EliminarTaller(nombreTallerSeleccionado);
            CargarTalleresControl();

        }

        public void MostrarModicar()
        {
            BtnAceptar.Show();
            dateTimePicker1.Show();
            BtnEliminar.Hide();
            BtnAgregar.Hide();
            BtnModificar.Hide();
        }

        public void OcultarModicar()
        {
            BtnAceptar.Hide();
            dateTimePicker1.Hide();
            BtnEliminar.Show();
            BtnAgregar.Show();
            BtnModificar.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (nombreTallerSeleccionado != string.Empty)
            {
                MostrarModicar();
            }            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            tallerService.ModificarFechaTaller(nombreTallerSeleccionado, dateTimePicker1.Value);
            CargarTalleresControl();
            OcultarModicar();
        }
    }
}
