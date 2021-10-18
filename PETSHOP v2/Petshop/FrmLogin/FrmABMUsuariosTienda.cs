using Entidades;
using System;
using System.Windows.Forms;

namespace FrmPetShopUI
{
    public partial class FrmABMUsuariosTienda : Form
    {
        private string idRowSeleccionada;

        public string IdRowSeleccionada
        {
            get
            {
                return this.idRowSeleccionada;
            }
        }
        public FrmABMUsuariosTienda()
        {
            InitializeComponent();
        }

        private void FrmABMUsuariosTienda_Load(object sender, EventArgs e)
        {
            Empleado auxEmplead_ = new Empleado("", "", 0, 0, "", "");
            dgEmpleadActuales.Rows.Clear();

            for (int i = 0; i < Tienda.Empleados.Count; i++)
            {
                auxEmplead_ = Tienda.Empleados[i];
                dgEmpleadActuales.ColumnCount = 7;
                this.dgEmpleadActuales.Columns[0].Name = "Nombre";
                this.dgEmpleadActuales.Columns[1].Name = "Apellido";
                this.dgEmpleadActuales.Columns[2].Name = "DNI";
                this.dgEmpleadActuales.Columns[3].Name = "Sueldo";
                this.dgEmpleadActuales.Columns[4].Name = "Usuario";
                this.dgEmpleadActuales.Columns[5].Name = "Clave";
                this.dgEmpleadActuales.Columns[6].Name = "ID";
                dgEmpleadActuales.Rows.Add(auxEmplead_.Nombre, auxEmplead_.Apellido, auxEmplead_.Dni, auxEmplead_.Sueldo, auxEmplead_.Usuario, auxEmplead_.Clave,auxEmplead_.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FrmModificarUsuarioAppExistente frmNuevoUsuario = new FrmModificarUsuarioAppExistente();
            frmNuevoUsuario.lblId.Text = dgEmpleadActuales.CurrentRow.Cells[6].Value.ToString();
            frmNuevoUsuario.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Empleado auxEmplead_ = new Empleado("", "", 0, 0, "", "");
            dgEmpleadActuales.Rows.Clear();

            for (int i = 0; i < Tienda.Empleados.Count; i++)
            {
                auxEmplead_ = Tienda.Empleados[i];
                dgEmpleadActuales.ColumnCount = 7;
                this.dgEmpleadActuales.Columns[0].Name = "Nombre";
                this.dgEmpleadActuales.Columns[1].Name = "Apellido";
                this.dgEmpleadActuales.Columns[2].Name = "DNI";
                this.dgEmpleadActuales.Columns[3].Name = "Sueldo";
                this.dgEmpleadActuales.Columns[4].Name = "Usuario";
                this.dgEmpleadActuales.Columns[5].Name = "Clave";
                this.dgEmpleadActuales.Columns[6].Name = "ID";

                dgEmpleadActuales.Rows.Add(auxEmplead_.Nombre, auxEmplead_.Apellido, auxEmplead_.Dni, auxEmplead_.Sueldo, auxEmplead_.Usuario, auxEmplead_.Clave,auxEmplead_.Id);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCargarNuevoUsuarioApp frmNuevoUsuario = new FrmCargarNuevoUsuarioApp();
            frmNuevoUsuario.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
