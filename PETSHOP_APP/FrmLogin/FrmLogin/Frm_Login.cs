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
using FrmEmpleado;
using FrmOlvidasteClave_PruebaSinLogueo;



namespace FrmLogin
{
    public partial class Frm_Login : Form
    {
       
        int m, mx, my;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Limpiar()
        {
            this.lblErrorMsj.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtClave.Text = string.Empty;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void pictureBoxFondo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void pictureBoxFondo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBoxFondo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Persona auxPersona = Tienda.LogIn(txtUsuario.Text, txtClave.Text);

            if(auxPersona != null)
            {
              
                    Frm_Empleado interfazEmpleado = new Frm_Empleado();
                    interfazEmpleado.Show();
              
                this.Hide();
            }
            else
            {
                lblErrorMsj.Text = "Usuario o contraseña incorrectos.";
            } 
            
        }

  
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmOlvidasteClavePruebaSinLogueo frmOlvidasteClave = new FrmOlvidasteClavePruebaSinLogueo();
            frmOlvidasteClave.ShowDialog();
            if (frmOlvidasteClave.SeCerroVentana)
            {
                this.Hide();
            }
        }

        
    }
}
