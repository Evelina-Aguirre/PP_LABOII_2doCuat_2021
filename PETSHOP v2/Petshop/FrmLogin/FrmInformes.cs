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
using System.IO;

namespace FrmPetShopUI
{
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            Producto auxProducto = new Producto();
            for (int i = 0; i < Venta.ventasRealizadas.Count; i++)
            {
                auxProducto = Venta.ventasRealizadas[i];
                
                dgInforme.ColumnCount = 9;
                this.dgInforme.Columns[0].Name = "Nombre";
                this.dgInforme.Columns[1].Name = "Marca";
                this.dgInforme.Columns[2].Name = "Precio";
                this.dgInforme.Columns[3].Name = "Medida";
                this.dgInforme.Columns[4].Name = "ID";
                this.dgInforme.Columns[5].Name = "Cantidad";
                this.dgInforme.Columns[6].Name = "Categoría";
                this.dgInforme.Columns[7].Name = "Descripción";
                this.dgInforme.Columns[8].Name = "Animal";

                dgInforme.Rows.Add(auxProducto.Nombre, auxProducto.Marca, auxProducto.Categoria, 1, auxProducto.Precio);
            }
            lblTotalVentas.Text = Tienda.SumarPrecioArticulosAgregados(Venta.ventasRealizadas).ToString();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter sw = new StreamWriter(@"C:\Users\Usuario\source\repos\PP_LABOII_Evelina_Aguirre_2E\PP_LABOII_2doCuat_2021\PETSHOP v2\Petshop\Archivo csv\Archivo.txt");
            int rowcount = dgInforme.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                sw.WriteLine(dgInforme.Rows[i].Cells[0].Value.ToString() + "\t"
                             + dgInforme.Rows[i].Cells[1].Value.ToString() + "\t"
                              + dgInforme.Rows[i].Cells[2].Value.ToString() + "\t"
                               + dgInforme.Rows[i].Cells[3].Value.ToString() + "\t");
            }
            sw.Close();
            MessageBox.Show("Datos Exportados correctamente");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
