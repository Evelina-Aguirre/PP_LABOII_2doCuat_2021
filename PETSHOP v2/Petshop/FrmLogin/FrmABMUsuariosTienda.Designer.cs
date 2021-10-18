
namespace FrmPetShopUI
{
    partial class FrmABMUsuariosTienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMUsuariosTienda));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgEmpleadActuales = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadActuales)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(644, -8);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(28, 32);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "  ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(667, -10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 32);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "  ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dgEmpleadActuales
            // 
            this.dgEmpleadActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleadActuales.Location = new System.Drawing.Point(12, 33);
            this.dgEmpleadActuales.Name = "dgEmpleadActuales";
            this.dgEmpleadActuales.RowTemplate.Height = 25;
            this.dgEmpleadActuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmpleadActuales.Size = new System.Drawing.Size(666, 229);
            this.dgEmpleadActuales.TabIndex = 16;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(512, 268);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(603, 268);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 268);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(421, 268);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 21;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // FrmABMUsuariosTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(694, 323);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgEmpleadActuales);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMUsuariosTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMUsuariosTienda";
            this.Load += new System.EventHandler(this.FrmABMUsuariosTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadActuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.DataGridView dgEmpleadActuales;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnQuitar;
    }
}