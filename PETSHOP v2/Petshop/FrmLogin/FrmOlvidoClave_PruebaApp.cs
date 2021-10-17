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
using Frm_Petshop_UI;

namespace FrmPetShopUI
{
    public partial class FrmOlvidoClave_PruebaApp : Form
    {
        private bool seCerroVentana = false;
        int m, mx, my;

        public bool SeCerroVentana
        {
            get { return this.seCerroVentana; }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void FrmOlvidoClave_PruebaApp_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void FrmOlvidoClave_PruebaApp_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void FrmOlvidoClave_PruebaApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void FrmOlvidoClave_PruebaApp_Load(object sender, EventArgs e)
        {

        }

        public FrmOlvidoClave_PruebaApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Emplead_ frmempleado = new Frm_Emplead_();
            frmempleado.Show();
            this.Hide();
            this.seCerroVentana = true;
        }
    }
}
