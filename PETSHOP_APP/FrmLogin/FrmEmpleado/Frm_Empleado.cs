using Entidades;
using FrmBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrmProducto;
using Entidades;
using FrmProducto_Perros;
using Frm_ProdGato;
using FrmProdAve;
using FrmProductosPez;
using FrmProdRoedor;
using FrmProductosReptil;
using FrmCargarNuevoCliente;


namespace FrmEmpleado
{
    
    public partial class Frm_Empleado : Frm_Base
    {
        List<Cliente> clientesDataView;
        private string cliente;
        Cliente clienteAuxiliarNuevo = new Cliente("","",0);

        public string Cliente
        {
            get
            {
                return this.cliente;
            }
        }
               
        public Frm_Empleado()
        {
            clientesDataView = new List<Cliente>();
            InitializeComponent();
            dgClientesActuales.DataSource = Tienda.Clientes;
        
        }
        private void Limpiar()
        {
            txtBuscar.Text = string.Empty;
            lblApellido.Text = string.Empty;
            lblNombre.Text = string.Empty;
            lblDni.Text = string.Empty;
            lblSaldo.Text = string.Empty;
            lblNumCliente.Text = string.Empty;
            lblMsjConfAdmin.Text = string.Empty;
            btnVender.Enabled = false;
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void dgListaClientesActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgClientesActuales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblApellido.Text = dgClientesActuales.CurrentRow.Cells[2].Value.ToString();
            lblNombre.Text = dgClientesActuales.CurrentRow.Cells[1].Value.ToString();
            lblDni.Text = dgClientesActuales.CurrentRow.Cells[3].Value.ToString();
            lblSaldo.Text = dgClientesActuales.CurrentRow.Cells[0].Value.ToString();
            lblNumCliente.Text = dgClientesActuales.CurrentRow.Cells[4].Value.ToString();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int aux;

            if (int.TryParse(txtBuscar.Text.ToString(), out aux))
            {
                dgClientesActuales.DataSource = null;
                dgClientesActuales.DataSource = Tienda.BuscarCliente(aux);
            }
            else
            {
                dgClientesActuales.DataSource = null;
                dgClientesActuales.DataSource = Tienda.BuscarCliente(txtBuscar.Text.ToString());
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
            dgClientesActuales.DataSource = Tienda.Clientes;
            
        }

     
        private void btnConfAdmin_Click(object sender, EventArgs e)
        {
            
            lblMsjConfAdmin.Text = "Para ingresar a configuración loguearse con perfil de Administrador.";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMsjConfAdmin.Text = String.Empty;
            timer1.Stop();
        }

       
        private void btnProductosPerros_Click(object sender, EventArgs e)
        {
            FrmProdPerros_ frmProducto = new FrmProdPerros_();
            frmProducto.Show();
         
      
            
        }

        private void btnProductosGatos_Click(object sender, EventArgs e)
        {

            FrmProdGatos frmProductosGato = new FrmProdGatos();
            frmProductosGato.lbNumCliente.Text = this.lblNumCliente.Text;
            frmProductosGato.Show();
            
        }

        private void btnProductosAves_Click(object sender, EventArgs e)
        {
            FrmProductosAve frmProducto = new FrmProductosAve();
            frmProducto.lbNumCliente.Text = this.lblNumCliente.Text;
            frmProducto.Show();
          

        }

        private void btnProductosPeces_Click(object sender, EventArgs e)
        {
            
            FrmProdPez frmProducto = new FrmProdPez();
            frmProducto.lbNumCliente.Text = this.lblNumCliente.Text;
            
            frmProducto.Show();
            
        }

        private void btnProductosRoedores_Click(object sender, EventArgs e)
        {
            FrmProductos_Roedor frmProducto = new FrmProductos_Roedor();
            frmProducto.lbNumCliente.Text = this.lblNumCliente.Text;
            frmProducto.Show();
            
        }

        private void btnProductosReptilesAnfibios_Click(object sender, EventArgs e)
        {
            Drm_ProdRptilAnfibio frmProducto = new Drm_ProdRptilAnfibio();
            frmProducto.lbNumCliente.Text = this.lblNumCliente.Text;
            
            frmProducto.Show();
           
        }

        private void dgCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void Frm_Empleado_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float Total= Tienda.SumarPrecioArticulosAgregados(Frm_Producto.ListaCarrito);
            dgCarritoFrmPriuncipal.DataSource = Frm_Producto.ListaCarrito;
            lblTotalCompra.Text = Total.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int auxClienteId = Convert.ToInt32(lblNumCliente.Text);
            int saldo = Convert.ToInt32(lblSaldo.Text);
            float total = Tienda.SumarPrecioArticulosAgregados(Frm_Producto.ListaCarrito);
            float aux;


            if (total <= saldo)
            {
                for (int i = 0; i < Tienda.Clientes.Count; i++)
                {
                    if (Tienda.Clientes[i].Id == auxClienteId)
                    {
                        aux = Tienda.Clientes[i].Dinero - total;
                        Tienda.Clientes[i].Dinero = aux;
                    }
                    break;
                }
                MessageBox.Show("La venta se realizó de maner aexitosa");
            }   
            else
            {
                MessageBox.Show("El saldo del cliente no es suficiente para realizar la compra");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCrearModificarCliente frmNuevoCliente = new FrmCrearModificarCliente();
            frmNuevoCliente.ShowDialog();
            


        }
    }
}
