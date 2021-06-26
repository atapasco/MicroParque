using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroParque
{
    public partial class FrmTalleres : Form
    {
        public FrmTalleres()
        {
            InitializeComponent();
        }

        private void FrmTalleres_Load(object sender, EventArgs e)
        {
            CargarTalleresControl();
            ClientSize = new Size(1000, 505);
        }

        private void CargarTalleresControl()
        {
            ListTalleres[] listTalleres = new ListTalleres[50];
            for (int i = 0; i < listTalleres.Length; i++)
            {
                listTalleres[i] = new ListTalleres();
                listTalleres[i].nombreTaller = "get data";
                listTalleres[i].personasAceptadas = "get data";
                listTalleres[i].personasPendientes = "get data";
                listTalleres[i].fechayHora = "get data";
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(listTalleres[i]);

            }
        }

    }
}
