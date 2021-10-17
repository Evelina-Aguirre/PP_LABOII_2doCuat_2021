using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace FrmCargarNuevoCliente
{
    public partial class FrmCrearModificarCliente : Form
    {
        public FrmCrearModificarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtSaldo.Text))
            {
                int auxDni = 0;
                int auxSaldo = 0;

                if (Tienda.ValidarCadenaNumerica(txtSaldo.Text) && txtSaldo.Text != null)
                {
                    auxSaldo = Convert.ToInt32(txtSaldo.Text);
                }
                if (Tienda.ValidarDni(txtDni.Text) && txtDni.Text != null)
                {
                    auxDni = Convert.ToInt32(txtDni.Text);
                }
                Cliente auxCliente = new Cliente(txtNombre.Text, txtApellito.Text, auxDni, auxSaldo);

                Tienda.Clientes.Add(auxCliente);
                this.Hide();
            }
            else
                MessageBox.Show("Debe completar el nombre y saldo del cliente para poder cargarlo","Error");
        }

        private void FrmCrearModificarCliente_Load(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
