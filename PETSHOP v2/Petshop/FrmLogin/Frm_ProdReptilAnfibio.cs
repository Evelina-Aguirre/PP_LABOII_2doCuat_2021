using FrmProducto;
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


namespace FrmPetShopUI
{
    public partial class Frm_ProdReptilAnfibio : Frm_Producto_
    {
        public Frm_ProdReptilAnfibio()
        {
            InitializeComponent();
        }

        private void Frm_ProdReptilAnfibio_Load(object sender, EventArgs e)
        {

        }

        private void BtnComida_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.Alimentos);
        }

        private void btnComederosBebederos_Click(object sender, EventArgs e)
        {
            CargarDataPerroPorCategoria(Producto.EAnimal.ReptilesYAnfibios, Producto.ECategoria.BebederosYComederos);
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
    }
}
