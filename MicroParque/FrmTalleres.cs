using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using BLL;
using Entity;

namespace MicroParque
{
    public partial class FrmTalleres : Form
    {
        private TallerService tallerService;
        public FrmTalleres()
        {
            InitializeComponent();
            tallerService = new TallerService();
        }

        private void FrmTalleres_Load(object sender, EventArgs e)
        {
            CargarTalleresControl();
            ClientSize = new Size(1000, 505);
            flowLayoutPanel1.Size = new Size(650, 515);
        }

        private void CargarTalleresControl()
        {
            int cantidadTalleres;
            List<Taller> talleres = new List<Taller>();
            talleres = tallerService.ConsultaGeneralDeTalleres().Talleres;
            cantidadTalleres = talleres.Count;
            ListTalleres[] listTalleres = new ListTalleres[100];
            for (int i = 0; i < cantidadTalleres; i++)
            {
                listTalleres[i] = new ListTalleres();
                listTalleres[i].nombreTaller = talleres[i].Nombre;
                listTalleres[i].personasAceptadas = Convert.ToString(talleres[i].CantidadAsistentes);
                listTalleres[i].personasPendientes = "get data";
                listTalleres[i].fechayHora = Convert.ToString(talleres[i].Fecha);
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
    }
}
