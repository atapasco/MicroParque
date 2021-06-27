﻿using BLL;
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
        private string nombreTallerSeleccionado = string.Empty;
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
            talleres = tallerService.ConsultaGeneralDeTalleres().Talleres;
            cantidadTalleres = talleres.Count;
            listTalleres = new ListTalleres[100];
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < cantidadTalleres; i++)
            {
                listTalleres[i] = new ListTalleres();
                listTalleres[i].NombreTaller(talleres[i].Nombre);
                listTalleres[i].PersonasAceptadas(talleres[i].CantidadAsistentes);
                listTalleres[i].PersonasPendientes(1);
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
                if (listTalleres[i].opcion == "Abrir")
                {
                    nombreTallerSeleccionado = listTalleres[i].nombreTaller;
                }
                
                listTalleres[i].opcion = string.Empty;
            }
            
            opcion = string.Empty;
            label2.Text = nombreTallerSeleccionado;
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
    }
}
