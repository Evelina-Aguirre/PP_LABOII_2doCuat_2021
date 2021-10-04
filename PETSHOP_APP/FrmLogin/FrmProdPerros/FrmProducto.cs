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
using Entidades;

namespace FrmProducto
{
    public partial  class Frm_Producto : Form
    {
        Cliente auxCliente = new Cliente("", "", 0);
        static List<Producto> listaCarrito;
        int m, mx, my;
        public float total;
        public Frm_Producto()
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
            if(lbNumCliente.Text == string.Empty)
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
        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void btnHigieneEstetica_Click(object sender, EventArgs e)
        {
           
        }


        private void btnAccesorios_Click(object sender, EventArgs e)
        {
           
        }

        private void btnJuguetes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHogarCamas_Click(object sender, EventArgs e)
        {

        }
        private void btnPaseoViaje_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTerrariosTortugueros_Click(object sender, EventArgs e)
        {
           
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
            
            total = Convert.ToInt32(lblTotal.Text);
            MessageBox.Show($"Total = {lblTotal.Text}");
            this.Hide();
            
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Producto auxProducto = new Producto();
            auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductos.CurrentRow.Cells[3].Value));
            Controls.Add(this.dgCarrito);
            dgCarrito.ColumnCount = 5;
            this.dgCarrito.Columns[0].Name = "Nombre";
            this.dgCarrito.Columns[1].Name = "Marca";
            this.dgCarrito.Columns[2].Name = "Categoría";
            this.dgCarrito.Columns[3].Name = "Cantidad";
            this.dgCarrito.Columns[4].Name = "Precio";

            dgCarrito.Rows.Add(auxProducto.Nombre, auxProducto.Marca,auxProducto.Categoria,1,auxProducto.Precio);
            listaCarrito.Add(auxProducto);
            lblTotal.Text = Tienda.SumarPrecioArticulosAgregados(listaCarrito).ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Producto auxProducto = new Producto();
            auxProducto = Tienda.BuscarProductoPorId(Convert.ToInt32(dgProductos.CurrentRow.Cells[3].Value));
            dgCarrito.Rows.Remove(dgCarrito.CurrentRow);
            listaCarrito.Remove(auxProducto);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Frm_Producto_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Frm_Producto_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }
    }
}
