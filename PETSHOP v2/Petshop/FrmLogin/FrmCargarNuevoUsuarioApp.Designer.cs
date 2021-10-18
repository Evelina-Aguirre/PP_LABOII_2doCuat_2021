
namespace FrmPetShopUI
{
    partial class FrmCargarNuevoUsuarioApp
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEsAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.Text = "Sueldo:";
            // 
            // btnGuardarDatosNuevoCliente
            // 
            this.btnGuardarDatosNuevoCliente.Location = new System.Drawing.Point(276, 362);
            this.btnGuardarDatosNuevoCliente.Click += new System.EventHandler(this.btnGuardarDatosNuevoCliente_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(113, 216);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(281, 23);
            this.txtUsuario.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(19, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "Usuario:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(113, 262);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(281, 23);
            this.txtClave.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(19, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 61;
            this.label7.Text = "Clave Default:";
            // 
            // cbEsAdmin
            // 
            this.cbEsAdmin.AutoSize = true;
            this.cbEsAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbEsAdmin.Location = new System.Drawing.Point(113, 314);
            this.cbEsAdmin.Name = "cbEsAdmin";
            this.cbEsAdmin.Size = new System.Drawing.Size(79, 19);
            this.cbEsAdmin.TabIndex = 64;
            this.cbEsAdmin.Text = " Es Admin";
            this.cbEsAdmin.UseVisualStyleBackColor = true;
            // 
            // FrmCargarNuevoUsuarioApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 425);
            this.Controls.Add(this.cbEsAdmin);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label6);
            this.Name = "FrmCargarNuevoUsuarioApp";
            this.Text = "FrmCargarNuevoUsuarioApp";
            this.Load += new System.EventHandler(this.FrmCargarNuevoUsuarioApp_Load);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.cbEsAdmin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.txtApellito, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSaldo, 0);
            this.Controls.SetChildIndex(this.btnGuardarDatosNuevoCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.linkLabel2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtClave;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox cbEsAdmin;
    }
}