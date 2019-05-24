using ProyectoFinalAplicada.UI.Consualtas;
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
    }
}
