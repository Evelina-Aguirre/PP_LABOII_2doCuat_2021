using Entidades;
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
    public partial class FrmRenovarSrockProductos : Form
    {
        List<Producto> listaauxProducto = new List<Producto>();
        public FrmRenovarSrockProductos()
        {
            InitializeComponent();
        }

        private void FrmRenovarSrockProductos_Load(object sender, EventArgs e)
        {
            dgProductosDisponibles.DataSource = Tienda.ProductosDisponibles;
            lblSaldoDisponibleTienda.Text = Tienda.saldoTienda.ToString();
        }

        private void dgProductosDisponibles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto auxProducto = new Producto();
            auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductosDisponibles.CurrentRow.Cells[4].Value));

            dgCarritoAdquirirStock.ColumnCount = 7;
            this.dgCarritoAdquirirStock.Columns[0].Name = "Nombre";
            this.dgCarritoAdquirirStock.Columns[1].Name = "Marca";
            this.dgCarritoAdquirirStock.Columns[2].Name = "Precio";
            this.dgCarritoAdquirirStock.Columns[3].Name = "Medida";
            this.dgCarritoAdquirirStock.Columns[4].Name = "Id";
            this.dgCarritoAdquirirStock.Columns[5].Name = "Cantidad";
            this.dgCarritoAdquirirStock.Columns[6].Name = "Categoría";


            dgCarritoAdquirirStock.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Precio, auxProducto.Medida,auxProducto.Id,1,auxProducto.Categoria);
            listaauxProducto.Add(auxProducto);
            lblTotalCompra.Text = Tienda.SumarPrecioArticulosAgregados(Tienda.Stock).ToString();

        }

        private void btnAgregarACarro_Click(object sender, EventArgs e)
        {
            Producto auxProducto = new Producto();
            auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductosDisponibles.CurrentRow.Cells[4].Value));

            dgCarritoAdquirirStock.ColumnCount = 7;
            this.dgCarritoAdquirirStock.Columns[0].Name = "Nombre";
            this.dgCarritoAdquirirStock.Columns[1].Name = "Marca";
            this.dgCarritoAdquirirStock.Columns[2].Name = "Precio";
            this.dgCarritoAdquirirStock.Columns[3].Name = "Medida";
            this.dgCarritoAdquirirStock.Columns[4].Name = "Id";
            this.dgCarritoAdquirirStock.Columns[5].Name = "Cantidad";
            this.dgCarritoAdquirirStock.Columns[6].Name = "Categoría";


            dgCarritoAdquirirStock.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Precio, auxProducto.Medida, auxProducto.Id, 1, auxProducto.Categoria);
            listaauxProducto.Add(auxProducto);
            lblTotalCompra.Text = Tienda.SumarPrecioArticulosAgregados(Tienda.Stock).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto auxProducto = new Producto();
            auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductosDisponibles.CurrentRow.Cells[4].Value));
            if (dgProductosDisponibles.RowCount > 1 && dgProductosDisponibles.SelectedRows != null && dgProductosDisponibles.CurrentRow.Cells[1].Value != null)
            {
                lblTotalCompra.Text = Tienda.RestarPrecioArticuloBorrado(float.Parse(lblTotalCompra.Text), Convert.ToInt32(dgCarritoAdquirirStock.CurrentRow.Cells[2].Value)).ToString();
                listaauxProducto.Remove(auxProducto);
                dgCarritoAdquirirStock.Rows.Remove(dataGridViewRow: dgCarritoAdquirirStock.CurrentRow);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalCompra =Convert.ToInt32(lblTotalCompra.Text);
            if (Tienda.saldoTienda >= totalCompra)
            {
                Tienda.ComprarStock(listaauxProducto);
                MessageBox.Show($"Compra realizada con Éxito.\nTotal:{lblTotalCompra.Text}\nSaldo restante :{Tienda.saldoTienda}");
                this.Close();
            }
            else
                MessageBox.Show("El saldo de la tienda no es suficiente para realizar la compra.\nPuede remover ítems con el botón 'Quitar'.");
        }
    }
}
