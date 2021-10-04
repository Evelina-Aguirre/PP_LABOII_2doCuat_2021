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

namespace FrmProdAve
{
    public partial class FrmProductosAve : Frm_Producto
    {
        public FrmProductosAve()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnComida_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.Alimentos);
        }

        private void btnComederosBebederos_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.BebederosYComederos);
        }

        private void btnHigieneEstetica_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.EstéticaEHigiene);
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.Accesorios);
        }

        private void btnJuguetes_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.Juguetes);
        }

        private void btnHogarCamas_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.HogarYCamas);
        }

        private void btnPaseoViaje_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.ViajesYPaseo);
        }

        private void btnTerrariosTortugueros_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.Aves, Producto.ECategoria.TortuguerosYTerrarios);
        }
    }
}
