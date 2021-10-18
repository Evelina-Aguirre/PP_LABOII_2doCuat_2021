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

namespace FrmPetShopUI
{
    public partial class FrmModificarUsuarioAppExistente : FrmCargarNuevoUsuarioApp
    {
        public int id;

        public int Id
        {
            set
            {
                this.id = value;
            }
        }
        public FrmModificarUsuarioAppExistente()
        {
            InitializeComponent();
        }

        private void FrmModificarUsuarioAppExistente_Load(object sender, EventArgs e)
        {
            Empleado auxEmp = new Empleado("","",0,0,"","");
            auxEmp = Tienda.BuscarEmpleadoPorId(Convert.ToInt32(lblId.Text));

            for (int i = 0; i < Tienda.Empleados.Count; i++)
            {
                if(Convert.ToInt32(lblId.Text) == Tienda.Empleados[i].Id)
                {
                    txtNombre.Text = Tienda.Empleados[i].Nombre;
                    txtApellito.Text = Tienda.Empleados[i].Apellido;
                    txtDni.Text = Tienda.Empleados[i].Dni.ToString();
                    txtSaldo.Text = Tienda.Empleados[i].Sueldo.ToString();
                    txtUsuario.Text = Tienda.Empleados[i].Usuario;
                    txtClave.Text = Tienda.Empleados[i].Clave;
                    break;

                }
            }

        }

        private void btnGuardarDatosNuevoCliente_Click(object sender, EventArgs e)
        {
            Empleado auxEmp = new Empleado("", "", 0, 0, "", "");
            auxEmp = Tienda.BuscarEmpleadoPorId(Convert.ToInt32(lblId.Text));
            Tienda.Empleados.Remove(auxEmp);

        }
    }
}
