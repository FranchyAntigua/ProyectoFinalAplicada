﻿using ProyectoFinalAplicada.UI.Consualtas;
using ProyectoFinalAplicada.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicada
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroUsuario().ShowDialog();
        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new cUSuarios().ShowDialog();
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rCargo().ShowDialog();
        }

        private void CargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new cCargos().ShowDialog();

        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rProductos().ShowDialog();

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rClientes().ShowDialog();
        }

        private void EntradaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rEntradaProductos().ShowDialog();
        }
    }
}
