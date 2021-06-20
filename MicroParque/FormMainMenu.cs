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
    public partial class FrmPal : Form
    {
        Form formulario;
        public FrmPal()
        {
            InitializeComponent();
            formulario = new Form();
            BtnBack.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


  /*  private void AbrirFrm()
        {
            Frm_Main pal = new Frm_Main();
            FrmLogin login = new FrmLogin();
            pal.openFormChild(login);
        }
 */
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            openFormChild(new FrmLogin());
            
        }

        private void EsconderMenu()
        {
            PbHome.Hide();
            BtnLogin.Hide();
            PbTallres.Hide();
            PbEncuestas.Hide();
            BtnBack.Show();
        }

        private void MostrarMenu()
        {
            PbHome.Show();
            BtnLogin.Show();
            PbTallres.Show();
            PbEncuestas.Show();
            BtnBack.Hide();
        }

        public void openFormChild(object formChild)
        {
            if (this.PanelChild.Controls.Count > 0)
            {
                this.PanelChild.Controls.RemoveAt(0);
            }

            Form child = formChild as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.PanelChild.Controls.Add(child);
            this.PanelChild.Tag = child;
            child.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.PanelChild.Controls.RemoveAt(0);
            MostrarMenu();
        }
    }
}
