using Entidades;
using FrmCargarNuevoCliente;
using System;
using System.Windows.Forms;

namespace FrmPetShopUI
{
    public partial class FrmCargarNuevoUsuarioApp : FrmCrearModificarCliente
    {
        public FrmCargarNuevoUsuarioApp()
        {
            InitializeComponent();
        }

        private void FrmCargarNuevoUsuarioApp_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarDatosNuevoCliente_Click(object sender, EventArgs e)
        {
            string msjError="";
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellito.Text) && !string.IsNullOrEmpty(txtSaldo.Text)
                && !string.IsNullOrEmpty(txtDni.Text)
                && !string.IsNullOrEmpty(txtUsuario.Text)
                && !string.IsNullOrEmpty(txtClave.Text))
            {
                int auxDni = 0;
                int auxSueldo = 0;

                if (Tienda.ValidarCadenaNumerica(txtSaldo.Text) && txtSaldo.Text != null)
                {
                    auxSueldo = Convert.ToInt32(txtSaldo.Text);
                }
                else
                {
                    msjError="El valor ingresado en el campo 'Sueldo'no es válido.";
                }
                if (Tienda.ValidarDni(txtDni.Text) && txtDni.Text != null)
                {
                    auxDni = Convert.ToInt32(txtDni.Text);
                }
                else
                {
                    msjError = "El valor ingresado en el campo 'DNI' no es válido."; 
                }

                if (cbEsAdmin.Checked)
                {
                    Administrador auxAdmin_ = new Administrador(txtNombre.Text, txtApellito.Text, auxDni, auxSueldo, txtUsuario.Text, txtClave.Text);
                    Tienda.Empleados.Add(auxAdmin_);
                   
                }
                else
                {
                    Empleado auxEmplead_ = new Empleado(txtNombre.Text, txtApellito.Text, auxDni, auxSueldo, txtUsuario.Text, txtClave.Text);
                    Tienda.Empleados.Add(auxEmplead_);
                }

                MessageBox.Show("Se dió de alta al usuario correctamente.");
                this.Close();
            }
            else
                MessageBox.Show($"Debe completar todos los campos para poder dar de alta al nuevo usuario en la apicación\n {msjError}", "Error");
        }
    }
}
