using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmBase;
using FrmEmpleado;

namespace FrmOlvidasteClave_PruebaSinLogueo
{
    public partial class FrmOlvidasteClavePruebaSinLogueo : Frm_Base
    {
        int m, mx, my;
        private bool seCerroVentana = false;

        public bool SeCerroVentana
        {
            get { return this.seCerroVentana; }
        }

        public FrmOlvidasteClavePruebaSinLogueo()
        {
            InitializeComponent();
        }

        private void FrmOlvidasteClave_PruebaSinLogueo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Empleado frmempleado = new Frm_Empleado();
            frmempleado.Show();
            this.Hide();
            this.seCerroVentana = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Empleado frmempleado = new Frm_Empleado();
            frmempleado.Show();
            this.Hide();
            this.seCerroVentana = true;
        }

        private void FrmOlvidasteClave_PruebaSinLogueo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void FrmOlvidasteClave_PruebaSinLogueo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

    }
}
