﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBase
{
    public partial class Frm_Base : Form
    {
        public Frm_Base()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        private void lnklblMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

      
    }
}
