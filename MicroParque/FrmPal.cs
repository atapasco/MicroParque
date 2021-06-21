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
    
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panelMain_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Frm_Main_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //20 minutos
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void Frm_Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Stop();
            //20 minutos
            timer1.Interval = 1200000;
            timer1.Start();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
