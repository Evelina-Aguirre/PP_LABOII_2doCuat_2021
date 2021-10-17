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

namespace FrmProducto_Perros
{
    public partial class FrmProdPerros_ : Frm_Producto
    {
        public FrmProdPerros_()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnComida_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.Alimentos);
        }

        private void btnTerrariosTortugueros_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.TortuguerosYTerrarios);
        }

        private void btnComederosBebederos_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.BebederosYComederos);
        }

        private void btnHigieneEstetica_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.EstéticaEHigiene);
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.Accesorios);
        }

        private void btnJuguetes_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.Juguetes);
        }

        private void btnHogarCamas_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.HogarYCamas);
        }

        private void btnPaseoViaje_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Perros, Producto.ECategoria.ViajesYPaseo);
        }
    }
}
