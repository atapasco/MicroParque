
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

namespace MicroParque
{
    public partial class FrmEncuestas : Form
    {
        EncuestaService encuesta;
        public FrmEncuestas()
        {
            InitializeComponent();
            encuesta = new EncuestaService();
        }

        private void FrmEncuestas_Load(object sender, EventArgs e)
        {
            encuesta.ConsultarNombresDeLosArchivo();
            dataGridView1.DataSource = (encuesta.ConsultarNombresDeLosArchivo().AdjuntarNombreEncuestas);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Humanst521 BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}
