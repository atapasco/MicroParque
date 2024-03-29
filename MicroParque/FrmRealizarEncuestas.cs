﻿
using ClassLibrary;
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

namespace MicroParque
{
    public partial class FrmRealizarEncuestas : Form
    {
        EncuestaService encuesta;
        public FrmRealizarEncuestas()
        {
            InitializeComponent();
            encuesta = new EncuestaService();
        }

        private void FrmEncuestas_Load(object sender, EventArgs e)
        {
            int i = 0;
            encuesta.ConsultarNombresDeLosArchivo();
            
            foreach (AdjuntarEncuesta item in encuesta.ConsultarNombresDeLosArchivo().AdjuntarNombreEncuestas)
            {
                dataGridView1.Rows.Add();

                dataGridView1[0, i].Value = (item.NombreDeArchivoEncuesta);
                dataGridView1[1, i].Value = (item.Tipo);
                i++;
            }
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Humanst521 BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
