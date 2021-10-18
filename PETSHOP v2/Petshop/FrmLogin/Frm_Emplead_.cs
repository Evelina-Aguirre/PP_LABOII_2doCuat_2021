﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FrmCargarNuevoCliente;
using FrmPetShopUI;

namespace Frm_Petshop_UI
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
            
            Cliente auxCliente = new Cliente("", "", 0);
            for (int i = 0; i < Tienda.Clientes.Count; i++)
            {
                auxCliente = Tienda.Clientes[i];

                dgClientesActuales.ColumnCount = 5;
                this.dgClientesActuales.Columns[0].Name = "Nombre";
                this.dgClientesActuales.Columns[1].Name = "Apellido";
                this.dgClientesActuales.Columns[2].Name = "Dni";
                this.dgClientesActuales.Columns[3].Name = "Saldo";
                this.dgClientesActuales.Columns[4].Name = "ID Cliente";


                dgClientesActuales.Rows.Add(auxCliente.Nombre, auxCliente.Apellido, auxCliente.Dni, auxCliente.Saldo, auxCliente.Id);

            }

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
            dgClientesActuales.Rows.Clear();
      
            Cliente auxCliente = new Cliente("", "", 0);
            for (int i = 0; i < Tienda.Clientes.Count; i++)
            {
                auxCliente = Tienda.Clientes[i];

                dgClientesActuales.ColumnCount = 5;
                this.dgClientesActuales.Columns[0].Name = "Nombre";
                this.dgClientesActuales.Columns[1].Name = "Apellido";
                this.dgClientesActuales.Columns[2].Name = "Dni";
                this.dgClientesActuales.Columns[3].Name = "Saldo";
                this.dgClientesActuales.Columns[4].Name = "ID Cliente";


                dgClientesActuales.Rows.Add(auxCliente.Nombre, auxCliente.Apellido, auxCliente.Dni, auxCliente.Saldo, auxCliente.Id);

            }
            Limpiar();
        }

        private void dgClientesActuales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombreCliente.Text = dgClientesActuales.CurrentRow.Cells[0].Value.ToString();
            lblApellidoCiente.Text = dgClientesActuales.CurrentRow.Cells[1].Value.ToString();
            lblDniCliente.Text = dgClientesActuales.CurrentRow.Cells[2].Value.ToString();
            lblIdCliente.Text = dgClientesActuales.CurrentRow.Cells[4].Value.ToString();
            lblSaldo.Text = dgClientesActuales.CurrentRow.Cells[3].Value.ToString();
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

                    dgCarritoFrmPriuncipal.ColumnCount = 6;
                    this.dgCarritoFrmPriuncipal.Columns[0].Name = "Nombre";
                    this.dgCarritoFrmPriuncipal.Columns[1].Name = "Marca";
                    this.dgCarritoFrmPriuncipal.Columns[2].Name = "Categoría";
                    this.dgCarritoFrmPriuncipal.Columns[3].Name = "Cantidad";
                    this.dgCarritoFrmPriuncipal.Columns[4].Name = "Precio";
                    this.dgCarritoFrmPriuncipal.Columns[5].Name = "ID Producto";

                dgCarritoFrmPriuncipal.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Categoria, 1, auxProducto.Precio, auxProducto.Id);

                }
            lblTotalCompra.Text = Tienda.SumarPrecioArticulosAgregados(Tienda.CompraActualDelClienteSeleccionado).ToString();

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int auxClienteId = 0;
            int saldo = 0;
            float total = 0;

            if (string.IsNullOrEmpty(lblNombreCliente.Text.ToString()))
            {
                MessageBox.Show("Para vender debe selecionar un cliente.");

            }
            else
            {
                if (dgCarritoFrmPriuncipal.RowCount > 0)
                {
                    auxClienteId = Convert.ToInt32(lblIdCliente.Text);
                    saldo = Convert.ToInt32(lblSaldo.Text);
                    total = Tienda.SumarPrecioArticulosAgregados(Tienda.CompraActualDelClienteSeleccionado);

                    if (total <= saldo)
                    {
                        float aux;

                        for (int i = 0; i < Tienda.Clientes.Count; i++)
                        {
                            if (Tienda.Clientes[i].Id == auxClienteId)
                            {
                                aux = Tienda.Clientes[i].Saldo - total;
                                Tienda.Clientes[i].Saldo = aux;
                                lblSaldo.Text = Tienda.Clientes[i].Saldo.ToString();
                                break;
                            }
                           
                        }
                        MessageBox.Show("La venta se realizó de manera exitosa");
                        Tienda.SumarADeSaldoTienda(total);

                    }
                    else
                    {
                        MessageBox.Show("El saldo del cliente no es suficiente para realizar la compra.", "Error");


                    }
                }
                else
                {
                    MessageBox.Show("Para vender debe selecionar almenos un producto.", "Error");
                }
            }


        }

        private void btnAgregarACarrito_Click(object sender, EventArgs e)
        {
            
            Producto auxProducto = new Producto();
            auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgCarritoFrmPriuncipal.CurrentRow.Cells[5].Value));
            if (dgCarritoFrmPriuncipal.RowCount > 1 && dgCarritoFrmPriuncipal.SelectedRows != null && lblTotalCompra.Text != null && dgCarritoFrmPriuncipal.CurrentRow.Cells[1].Value != null)
            {
                lblTotalCompra.Text = Tienda.RestarPrecioArticuloBorrado(float.Parse(lblTotalCompra.Text), Convert.ToInt32(dgCarritoFrmPriuncipal.CurrentRow.Cells[4].Value)).ToString();
                Tienda.CompraActualDelClienteSeleccionado.Remove(auxProducto);
                dgCarritoFrmPriuncipal.Rows.Remove(dataGridViewRow: dgCarritoFrmPriuncipal.CurrentRow);

            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            lblErrorNuevoCliente.Text = "Para cargar un nuevo cliente debe loguearse como Admin.";
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMsjErrorLogAdmin.Text = "Para ingresar a configuración loguearse con perfil de Administrador.";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMsjErrorLogAdmin.Text = String.Empty;
            lblErrorNuevoCliente.Text = String.Empty;
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea cambiar de usuario?", "Cambio Usuario",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmCambiarPerfil frmCambiaPerfil = new FrmCambiarPerfil();
                frmCambiaPerfil.Show();
                this.Hide();
            }
  
        }

        private void Frm_Emplead__FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Frm_Emplead__MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Frm_Emplead__MouseMove(object sender, MouseEventArgs e)
        {
            //if (m == 1)
            //{
            //    this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            //}

        }
    }
}
