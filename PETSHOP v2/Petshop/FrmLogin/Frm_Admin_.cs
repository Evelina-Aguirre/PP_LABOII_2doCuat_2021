using Frm_Petshop_UI;
using FrmCargarNuevoCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPetShopUI
{
    public partial class Frm_Admin_ : Frm_Emplead_
    {
        public Frm_Admin_()
        {
            InitializeComponent();
        }

        private void Frm_Admin__Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmCrearModificarCliente frmCargarNuevoCliente = new FrmCrearModificarCliente();
            frmCargarNuevoCliente.ShowDialog();
            

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracionEInformes frmConfEInformes = new FrmConfiguracionEInformes();
            frmConfEInformes.Show();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FrmCrearModificarCliente frmModificarClienteExistente = new FrmCrearModificarCliente();
            frmModificarClienteExistente.lblId.Text = lblIdCliente.Text;
            frmModificarClienteExistente.ShowDialog();
        }
    }
}
