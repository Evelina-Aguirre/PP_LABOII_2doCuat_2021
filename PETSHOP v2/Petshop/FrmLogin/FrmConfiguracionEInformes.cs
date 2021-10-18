using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrmPetShopUI
{
    public partial class FrmConfiguracionEInformes : Form
    {
        public FrmConfiguracionEInformes()
        {
            InitializeComponent();
        }

        private void FrmConfiguracionEInformes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRenovarSrockProductos frmComprar = new FrmRenovarSrockProductos();
            frmComprar.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmABMUsuariosTienda frmabmUsuarios = new FrmABMUsuariosTienda();
            frmabmUsuarios.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInformes frmInformes = new FrmInformes();
            frmInformes.ShowDialog();
        }
    }
}
