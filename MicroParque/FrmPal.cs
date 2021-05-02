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
        }

        private void panelMain_Load(object sender, EventArgs e)
        {
            openFormChild(new FrmPal());
        }

        private void openFormChild(object formChild)
        {
            if (this.panelMenu.Controls.Count > 0)
            {
                this.panelMenu.Controls.RemoveAt(0);
            }

            Form child = formChild as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(child);
            this.panelMenu.Tag = child;
            child.Show();
        }
    }
}
