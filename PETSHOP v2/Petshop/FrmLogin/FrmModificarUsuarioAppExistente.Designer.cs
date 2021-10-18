
namespace FrmPetShopUI
{
    partial class FrmModificarUsuarioAppExistente
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
            this.SuspendLayout();
            // 
            // btnGuardarDatosNuevoCliente
            // 
            this.btnGuardarDatosNuevoCliente.Click += new System.EventHandler(this.btnGuardarDatosNuevoCliente_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(150, 7);
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.Text = "Modificar Usuario Existente";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(19, 7);
            // 
            // FrmModificarUsuarioAppExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Name = "FrmModificarUsuarioAppExistente";
            this.Text = "FrmModificarUsuarioAppExistente";
            this.Load += new System.EventHandler(this.FrmModificarUsuarioAppExistente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}