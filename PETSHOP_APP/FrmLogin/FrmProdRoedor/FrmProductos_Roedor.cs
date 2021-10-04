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
using FrmProducto;

namespace FrmProdRoedor
{
    public partial class FrmProductos_Roedor : Frm_Producto
    {
        public FrmProductos_Roedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.Alimentos);
        }

        private void btnComederosBebederos_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.BebederosYComederos);
        }

        private void btnHigieneEstetica_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.EstéticaEHigiene);
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.Accesorios);
        }

        private void btnJuguetes_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.Juguetes);
        }

        private void btnHogarCamas_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.HogarYCamas);
        }

        private void btnPaseoViaje_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.ViajesYPaseo);
        }

        private void btnTerrariosTortugueros_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Roedores, Producto.ECategoria.TortuguerosYTerrarios);
        }
    }
}
