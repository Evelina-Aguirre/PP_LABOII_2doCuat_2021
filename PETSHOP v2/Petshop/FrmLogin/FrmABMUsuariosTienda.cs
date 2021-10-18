using Entidades;
using System;
using System.Windows.Forms;

namespace FrmPetShopUI
{
    public partial class FrmABMUsuariosTienda : Form
    {
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
                dgEmpleadActuales.ColumnCount = 6;
                this.dgEmpleadActuales.Columns[0].Name = "Nombre";
                this.dgEmpleadActuales.Columns[1].Name = "Apellido";
                this.dgEmpleadActuales.Columns[2].Name = "DNI";
                this.dgEmpleadActuales.Columns[3].Name = "Sueldo";
                this.dgEmpleadActuales.Columns[4].Name = "Usuario";
                this.dgEmpleadActuales.Columns[5].Name = "Clave";

                dgEmpleadActuales.Rows.Add(auxEmplead_.Nombre, auxEmplead_.Apellido, auxEmplead_.Dni, auxEmplead_.Sueldo, auxEmplead_.Usuario, auxEmplead_.Clave);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCargarNuevoUsuarioApp frmNuevoUsuario = new FrmCargarNuevoUsuarioApp();
            frmNuevoUsuario.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Empleado auxEmplead_ = new Empleado("", "", 0, 0, "", "");
            dgEmpleadActuales.Rows.Clear();

            for (int i = 0; i < Tienda.Empleados.Count; i++)
            {
                auxEmplead_ = Tienda.Empleados[i];
                dgEmpleadActuales.ColumnCount = 6;
                this.dgEmpleadActuales.Columns[0].Name = "Nombre";
                this.dgEmpleadActuales.Columns[1].Name = "Apellido";
                this.dgEmpleadActuales.Columns[2].Name = "DNI";
                this.dgEmpleadActuales.Columns[3].Name = "Sueldo";
                this.dgEmpleadActuales.Columns[4].Name = "Usuario";
                this.dgEmpleadActuales.Columns[5].Name = "Clave";

                dgEmpleadActuales.Rows.Add(auxEmplead_.Nombre, auxEmplead_.Apellido, auxEmplead_.Dni, auxEmplead_.Sueldo, auxEmplead_.Usuario, auxEmplead_.Clave);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCargarNuevoUsuarioApp frmNuevoUsuario = new FrmCargarNuevoUsuarioApp();
            frmNuevoUsuario.ShowDialog();
        }
    }
}
