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

namespace FrmProductosReptil
{
    public partial class Drm_ProdRptilAnfibio : Frm_Producto
    {
        public Drm_ProdRptilAnfibio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnComida_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Alimentos);
        }

        private void btnComederosBebederos_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.HogarYCamas);
        }

        private void btnHigieneEstetica_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.EstéticaEHigiene);
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Accesorios);
        }

        private void btnJuguetes_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Juguetes);
        }

        private void btnHogarCamas_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.HogarYCamas);
        }

        private void btnPaseoViaje_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.ViajesYPaseo);
        }

        private void btnTerrariosTortugueros_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.TortuguerosYTerrarios);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
