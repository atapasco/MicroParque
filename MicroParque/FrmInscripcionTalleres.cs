using BLL;
using Entity;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace MicroParque
{
    public partial class FrmInscripcionTalleres : Form
    {
        InscripcionTaller inscripcion;
        public FrmInscripcionTalleres()
        {
            InitializeComponent();
            inscripcion = new InscripcionTaller();
            LblValidarDatos.Hide();
        }

        private void FrmInscripcionTalleres_Load(object sender, EventArgs e)
        {

        }
        private void MapearTxtTalleres()
        {
            inscripcion.PrimerNombre = TxtPrimerNombre.Text;
            inscripcion.SegundoNombre = TxtSegundoNombre.Text;
            inscripcion.PrimerApellido = TxtPrimerApellido.Text;
            inscripcion.SegundoApellido = TxtSegundoApellido.Text;
            inscripcion.Telefono = TxtTelefono.Text;
            inscripcion.NivelAcademico = TxtNivelAcademico.Text;
            inscripcion.FormacionSuperior = TxtFormacionSuperior.Text;
            inscripcion.NombreTaller = TxtNombreTaller.Text;
            inscripcion.Correo = TxtCorreo.Text;
        }

        private void VaciarCampos()
        {
            TxtPrimerNombre.Text = string.Empty;
            TxtSegundoNombre.Text = string.Empty;
            TxtPrimerApellido.Text = string.Empty;
            TxtSegundoApellido.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtNivelAcademico.Text = string.Empty;
            TxtFormacionSuperior.Text = string.Empty;
            TxtNombreTaller.Text = string.Empty;
            TxtCorreo.Text = string.Empty;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ValidarNombresYApellidos();
            ValidarTelefono();
            ValidarCorreo();
            ValidarCamposVacio();
            MapearTxtTalleres();
            if (errorProviderValDatos.GetError(BtnGuardar).Equals(""))
            {
                TallerService tallerService = new TallerService();
                LblValidarDatos.Text = tallerService.GuardarInscripcionesTaller(inscripcion);
                LblValidarDatos.Show();
                VaciarCampos();

            }
            

        }

        private void ValidarCamposVacio()
        {
            if (TxtCorreo.Text == string.Empty || TxtFormacionSuperior.Text == string.Empty || TxtNivelAcademico.Text == string.Empty ||
                TxtNombreTaller.Text == string.Empty || TxtPrimerApellido.Text == string.Empty || TxtPrimerNombre.Text == string.Empty ||
                TxtSegundoApellido.Text == string.Empty || TxtTelefono.Text == string.Empty)
            {
                errorProviderValDatos.SetError(BtnGuardar, "Error, Verifique que: no existan campos vacios");
            }
            else errorProviderValDatos.Clear();
        }

        private bool ValidarCampos(string campos)
        {
            bool validarLetras = false;

            for (int i = 33; i <= 255; i++)
            {
                validarLetras = campos.Contains(Convert.ToString(Convert.ToChar(i)));
                if (validarLetras == true)
                {
                    break;
                }
                if (i == 64)
                {
                    i = 90;
                }
                if (i == 96)
                {
                    i = 122;
                }
            }
            return validarLetras;
        }
        private bool ValidarTelefono()
        {
            bool validarNumeros = false;

            for (int i = 32; i <= 255; i++)
            {
                validarNumeros = TxtTelefono.Text.Contains(Convert.ToString(Convert.ToChar(i)));
                if (validarNumeros == true)
                {
                    break;
                }
                if (i == 47)
                {
                    i = 57;
                }

            }
            if (validarNumeros == true)
            {
                errorProviderValDatos.SetError(BtnGuardar, "Error, Verifique que: no existan Letras en Numero de telefono");
            }
            else errorProviderValDatos.Clear();
            return validarNumeros;
        }


        private void ValidarNombresYApellidos()
        {
            if (ValidarCampos(TxtPrimerApellido.Text) == true || ValidarCampos(TxtSegundoApellido.Text) == true ||
                ValidarCampos(TxtPrimerNombre.Text) == true || ValidarCampos(TxtSegundoNombre.Text) == true)
            {
                errorProviderValDatos.SetError(BtnGuardar, "Error, Verifique que: no existan numeros en nombres y apellidos");

            }
            else errorProviderValDatos.Clear();
        }

        private Boolean ValidarEscrituraCorreo()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(TxtCorreo.Text, expresion))
            {
                if (Regex.Replace(TxtCorreo.Text, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ValidarCorreo()
        {
            if (ValidarEscrituraCorreo() == false)
            {
                errorProviderValDatos.SetError(BtnGuardar, "Error, Verifique que: El correo este bien escrito");
            }
            else errorProviderValDatos.Clear();
        }

        private void TxtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrimerNombre.Text != string.Empty)
            {
                LblValidarDatos.Hide();
            }
        }
    }
}
