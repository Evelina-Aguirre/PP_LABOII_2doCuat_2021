
namespace FrmPetShopUI
{
    partial class FrmRenovarSrockProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenovarSrockProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.dgProductosDisponibles = new System.Windows.Forms.DataGridView();
            this.dgCarritoAdquirirStock = new System.Windows.Forms.DataGridView();
            this.btnAgregarACarro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lklblBucar = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldoDisponibleTienda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarritoAdquirirStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Productos";
            // 
            // dgProductosDisponibles
            // 
            this.dgProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosDisponibles.Location = new System.Drawing.Point(32, 93);
            this.dgProductosDisponibles.Name = "dgProductosDisponibles";
            this.dgProductosDisponibles.RowTemplate.Height = 25;
            this.dgProductosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductosDisponibles.Size = new System.Drawing.Size(721, 244);
            this.dgProductosDisponibles.TabIndex = 1;
            this.dgProductosDisponibles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductosDisponibles_CellContentDoubleClick);
            // 
            // dgCarritoAdquirirStock
            // 
            this.dgCarritoAdquirirStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarritoAdquirirStock.Location = new System.Drawing.Point(32, 407);
            this.dgCarritoAdquirirStock.Name = "dgCarritoAdquirirStock";
            this.dgCarritoAdquirirStock.RowTemplate.Height = 25;
            this.dgCarritoAdquirirStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarritoAdquirirStock.Size = new System.Drawing.Size(721, 236);
            this.dgCarritoAdquirirStock.TabIndex = 2;
            // 
            // btnAgregarACarro
            // 
            this.btnAgregarACarro.Location = new System.Drawing.Point(678, 343);
            this.btnAgregarACarro.Name = "btnAgregarACarro";
            this.btnAgregarACarro.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarACarro.TabIndex = 3;
            this.btnAgregarACarro.Text = "Agregar";
            this.btnAgregarACarro.UseVisualStyleBackColor = true;
            this.btnAgregarACarro.Click += new System.EventHandler(this.btnAgregarACarro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total:";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalCompra.Location = new System.Drawing.Point(75, 646);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(0, 15);
            this.lblTotalCompra.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(686, 23);
            this.textBox1.TabIndex = 6;
            // 
            // lklblBucar
            // 
            this.lklblBucar.AutoSize = true;
            this.lklblBucar.BackColor = System.Drawing.Color.Transparent;
            this.lklblBucar.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lklblBucar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lklblBucar.Image = ((System.Drawing.Image)(resources.GetObject("lklblBucar.Image")));
            this.lklblBucar.LinkColor = System.Drawing.Color.Transparent;
            this.lklblBucar.Location = new System.Drawing.Point(713, 61);
            this.lklblBucar.Name = "lklblBucar";
            this.lklblBucar.Size = new System.Drawing.Size(49, 32);
            this.lklblBucar.TabIndex = 7;
            this.lklblBucar.TabStop = true;
            this.lklblBucar.Text = "     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carrito";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(771, -8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 32);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "  ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(750, -6);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(28, 32);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "  ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(248, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Saldo disponible de Compra :";
            // 
            // lblSaldoDisponibleTienda
            // 
            this.lblSaldoDisponibleTienda.AutoSize = true;
            this.lblSaldoDisponibleTienda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldoDisponibleTienda.Location = new System.Drawing.Point(416, 13);
            this.lblSaldoDisponibleTienda.Name = "lblSaldoDisponibleTienda";
            this.lblSaldoDisponibleTienda.Size = new System.Drawing.Size(0, 15);
            this.lblSaldoDisponibleTienda.TabIndex = 14;
            // 
            // FrmRenovarSrockProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(798, 720);
            this.Controls.Add(this.lblSaldoDisponibleTienda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lklblBucar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarACarro);
            this.Controls.Add(this.dgCarritoAdquirirStock);
            this.Controls.Add(this.dgProductosDisponibles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRenovarSrockProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Stock";
            this.Load += new System.EventHandler(this.FrmRenovarSrockProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarritoAdquirirStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProductosDisponibles;
        private System.Windows.Forms.DataGridView dgCarritoAdquirirStock;
        private System.Windows.Forms.Button btnAgregarACarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel lklblBucar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldoDisponibleTienda;
    }
}