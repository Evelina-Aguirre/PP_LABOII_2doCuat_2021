using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace FrmProducto
{
    public partial class Frm_Producto_ : Form
    {
        Cliente auxCliente = new Cliente("", "", 0);
        static List<Producto> listaCarrito;
        int m, mx, my;
        public float total;
        public Frm_Producto_()
        {
            InitializeComponent();
            listaCarrito = new List<Producto>();
        }

        public static List<Producto> ListaCarrito
        {
            get
            {
                return listaCarrito;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ProductosPerros_Load(object sender, EventArgs e)
        {
            if (lbNumCliente.Text == string.Empty)
                lbNumCliente.Text = "";
        }

        protected void CargarDataPerroPorCategoria(Producto.EAnimal animal, Producto.ECategoria categoria)
        {
            List<Producto> auxProductos = new List<Producto>();

            for (int i = 0; i < Tienda.Stock.Count; i++)
            {
                if (Tienda.Stock[i].Categoria == categoria)
                {
                    if (Tienda.Stock[i].Animal == animal)
                    {
                        auxProductos.Add(Tienda.Stock[i]);
                    }

                }
            }
            dgProductos.DataSource = auxProductos;
        }
           

        private void Frm_Producto_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int.TryParse(this.lblTotal.Text, out int total);
            Tienda.SumarProductosDeEsteRubroAlCarrito(listaCarrito);
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (dgProductos.RowCount > 0)
            {
                Producto auxProducto = new Producto();
                auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductos.CurrentRow.Cells[4].Value));
                //Controls.Add(this.dgCarrito);
                dgCarrito.ColumnCount = 5;
                this.dgCarrito.Columns[0].Name = "Nombre";
                this.dgCarrito.Columns[1].Name = "Marca";
                this.dgCarrito.Columns[2].Name = "Categoría";
                this.dgCarrito.Columns[3].Name = "Cantidad";
                this.dgCarrito.Columns[4].Name = "Precio";

                dgCarrito.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Categoria, 1, auxProducto.Precio);
                listaCarrito.Add(auxProducto);
                lblTotal.Text = Tienda.SumarPrecioArticulosAgregados(listaCarrito).ToString();
            }
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Producto auxProducto = new Producto();
            auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductos.CurrentRow.Cells[3].Value));
            if (dgCarrito.RowCount > 1 && dgCarrito.SelectedRows != null && lblTotal.Text != null && dgCarrito.CurrentRow.Cells[1].Value != null)
            {
                lblTotal.Text = Tienda.RestarPrecioArticuloBorrado(float.Parse(lblTotal.Text), Convert.ToInt32(dgCarrito.CurrentRow.Cells[4].Value)).ToString();
                listaCarrito.Remove(auxProducto);
                dgCarrito.Rows.Remove(dataGridViewRow: dgCarrito.CurrentRow);
               
            }
         
        }


        private void button14_Click(object sender, EventArgs e)
        {
            List<Producto> listaAux = new List<Producto>();

            //Busca producto por Nombre/Marca y carga la lista
            listaAux = Tienda.BuscarProducto(txtBuscat.Text.ToString().Trim().ToLower());

            //En caso de buscar un entero intentará compararlo con id del Producto.
            if (int.TryParse(txtBuscat.Text, out int id))
            {
                listaAux.Add(Tienda.BuscarProductoPorId(id));
                dgProductos.DataSource = listaAux;
            }
            dgProductos.DataSource = listaAux;
       
        }

        private void txtBuscat_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscat.Text = string.Empty;
        }


        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDescricion.Text = dgProductos.CurrentRow.Cells[7].Value.ToString();
            lblPrecioProducto.Text = dgProductos.CurrentRow.Cells[2].Value.ToString();
            lblNombreProducto.Text = dgProductos.CurrentRow.Cells[0].Value.ToString();
            lblMarcaProducto.Text = dgProductos.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDescricion.Text = dgProductos.CurrentRow.Cells[7].Value.ToString();
            lblPrecioProducto.Text = dgProductos.CurrentRow.Cells[2].Value.ToString();
            lblNombreProducto.Text = dgProductos.CurrentRow.Cells[0].Value.ToString();
            lblMarcaProducto.Text = dgProductos.CurrentRow.Cells[1].Value.ToString();
            if (dgProductos.RowCount > 0)
            {
                Producto auxProducto = new Producto();
                auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductos.CurrentRow.Cells[4].Value));
                //Controls.Add(this.dgCarrito);
                dgCarrito.ColumnCount = 5;
                this.dgCarrito.Columns[0].Name = "Nombre";
                this.dgCarrito.Columns[1].Name = "Marca";
                this.dgCarrito.Columns[2].Name = "Categoría";
                this.dgCarrito.Columns[3].Name = "Cantidad";
                this.dgCarrito.Columns[4].Name = "Precio";

                dgCarrito.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Categoria, 1, auxProducto.Precio);
                listaCarrito.Add(auxProducto);
                lblTotal.Text = Tienda.SumarPrecioArticulosAgregados(listaCarrito).ToString();
            }

        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDescricion.Text = dgProductos.CurrentRow.Cells[7].Value.ToString();
            lblPrecioProducto.Text = dgProductos.CurrentRow.Cells[2].Value.ToString();
            lblNombreProducto.Text = dgProductos.CurrentRow.Cells[0].Value.ToString();
            lblMarcaProducto.Text = dgProductos.CurrentRow.Cells[1].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Frm_Producto_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Frm_Producto_MouseMove(object sender, MouseEventArgs e)
        {
            //if (m == 1)
            //{
            //    this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            //}

        }
    }
}
