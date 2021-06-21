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
    public partial class FrmLogin : Form
    {
        Frm_Main pal = new Frm_Main();
        public FrmLogin()
        {
            InitializeComponent();
            PanelChildLog.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            EsconderLog();
            PanelChildLog.Show();
            openFormChild(new Frm_Main());
            timer1.Start();
        }

        public void ValidarCierreSesion()
        {
            
        }

        private void MostrarLog()
        {
            panel1.Show();
            button1.Show();
            textBox1.Show();
            textBox2.Show();
            pictureBox1.Show();
            PanelChildLog.Hide();
        }

        private void EsconderLog()
        {
            panel1.Hide();
            button1.Hide();
            textBox1.Hide();
            textBox2.Hide();
            pictureBox1.Hide();
            PanelChildLog.Show();
        }

        public void openFormChild(object formChild)
        {
            if (this.PanelChildLog.Controls.Count > 0)
            {
                this.PanelChildLog.Controls.RemoveAt(0);
            }

            Form child = formChild as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.PanelChildLog.Controls.Add(child);
            this.PanelChildLog.Tag = child;
            child.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.PanelChildLog.Controls.Count == 0)
            {
                MostrarLog();
            }
        }




        /*  private async void ValLog()
          {
             await Task.Run(() => { ValidarCierreSesion(); });

          }
        */
    }
}
