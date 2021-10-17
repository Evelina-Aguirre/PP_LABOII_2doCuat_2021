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
using FrmPetShopUI;

namespace FrmLogin
{
    public partial class Frm_Emplead_ : Form
    {
        List<Producto> auxlistProductoFrmEmpleado;
        
        int m, mx, my;
        private Producto listaCarrito;

        public Frm_Emplead_()
        {
            InitializeComponent();
            auxlistProductoFrmEmpleado = new List<Producto>();
           
        }


        private void Frm_Emplead__Load(object sender, EventArgs e)
        {
            dgClientesActuales.DataSource = Tienda.Clientes;
            
        }
        private void lklblBuscarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                dgClientesActuales.DataSource = Tienda.BuscarCliente(txtBuscar.Text.ToString().Trim().ToLower());
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtBuscar.Text = string.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgClientesActuales.DataSource = Tienda.Clientes;
            Limpiar();
        }

        private void dgClientesActuales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombreCliente.Text = dgClientesActuales.CurrentRow.Cells[0].Value.ToString();
            lblApellidoCiente.Text = dgClientesActuales.CurrentRow.Cells[1].Value.ToString();
            lblDniCliente.Text = dgClientesActuales.CurrentRow.Cells[2].Value.ToString();
            lblIdCliente.Text = dgClientesActuales.CurrentRow.Cells[3].Value.ToString();
            lblSaldo.Text = dgClientesActuales.CurrentRow.Cells[4].Value.ToString();
        }

        private void Frm_Emplead__MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnPerros_Click(object sender, EventArgs e)
        {
            FrmProd_Perros frmProducto = new FrmProd_Perros();
            frmProducto.Show();
        }

        private void btnGatos_Click(object sender, EventArgs e)
        {
            Frm_ProdGatos_ frmProducto = new Frm_ProdGatos_();
            frmProducto.Show();
        }

        private void btnAves_Click(object sender, EventArgs e)
        {
            Frm_ProdAves frmProducto = new Frm_ProdAves();
            frmProducto.Show();
        }

        private void btnPeces_Click(object sender, EventArgs e)
        {
            Frm_Prodpeces frmProducto = new Frm_Prodpeces();
            frmProducto.Show();
        }

        private void btnRoedores_Click(object sender, EventArgs e)
        {
            Frm_ProdRoedor frmProducto = new Frm_ProdRoedor();
            frmProducto.Show();
        }

        private void btnReptilesAnfibios_Click(object sender, EventArgs e)
        {
            Frm_ProdReptilAnfibio frmProducto = new Frm_ProdReptilAnfibio();
            frmProducto.Show();
        }

        private void dgCarritoFrmPriuncipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                Producto auxProducto = new Producto();
                dgCarritoFrmPriuncipal.Rows.Clear();
                for (int i = 0; i < Tienda.CompraActualDelClienteSeleccionado.Count; i++)
                {
                    auxProducto = Tienda.CompraActualDelClienteSeleccionado[i];

                    dgCarritoFrmPriuncipal.ColumnCount = 5;
                    this.dgCarritoFrmPriuncipal.Columns[0].Name = "Nombre";
                    this.dgCarritoFrmPriuncipal.Columns[1].Name = "Marca";
                    this.dgCarritoFrmPriuncipal.Columns[2].Name = "Categoría";
                    this.dgCarritoFrmPriuncipal.Columns[3].Name = "Cantidad";
                    this.dgCarritoFrmPriuncipal.Columns[4].Name = "Precio";

                    dgCarritoFrmPriuncipal.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Categoria, 1, auxProducto.Precio);

                }
                
          
            
        }

        private void Frm_Emplead__MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Frm_Emplead__MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }
    }
}
