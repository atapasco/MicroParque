using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
using ClassLibrary;

namespace MicroParque
{
    public partial class FrmAgregarTaller : Form
    {
        private Taller taller;
        private TallerService tallerService;

        public FrmAgregarTaller()
        {
            InitializeComponent();
            taller = new Taller();
            tallerService = new TallerService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] matrizTaller = txthora.Text.Split(':');
            TimeSpan hora = new TimeSpan(Convert.ToInt32(matrizTaller[0]),Convert.ToInt32(matrizTaller[1]),0);
            taller.Nombre = txtnombreTaller.Text;
            taller.CantidadAsistentes = 0;
            taller.Disponibilidad = true;
            taller.Fecha = dtpfecha.Value.Date + hora;
            tallerService.GuardarTaller(taller);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("una perra");
        }
    }
}
