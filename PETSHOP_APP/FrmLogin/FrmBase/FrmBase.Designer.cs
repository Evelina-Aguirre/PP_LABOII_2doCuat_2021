
namespace FrmBase
{
    partial class Frm_Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Base));
            this.lnklblMinimizar = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnklblMinimizar
            // 
            this.lnklblMinimizar.ActiveLinkColor = System.Drawing.Color.White;
            this.lnklblMinimizar.AutoSize = true;
            this.lnklblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lnklblMinimizar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnklblMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("lnklblMinimizar.Image")));
            this.lnklblMinimizar.LinkColor = System.Drawing.Color.Transparent;
            this.lnklblMinimizar.Location = new System.Drawing.Point(647, 38);
            this.lnklblMinimizar.Name = "lnklblMinimizar";
            this.lnklblMinimizar.Size = new System.Drawing.Size(37, 30);
            this.lnklblMinimizar.TabIndex = 0;
            this.lnklblMinimizar.TabStop = true;
            this.lnklblMinimizar.Text = "    ";
            this.lnklblMinimizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblMinimizar_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(690, 36);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(42, 32);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "    ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Frm_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lnklblMinimizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Base";
            this.Text = "Form Base";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.LinkLabel lnklblMinimizar;
        public System.Windows.Forms.LinkLabel linkLabel2;
    }
}

