using ProyectoFinalAplicada.BLL;
using ProyectoFinalAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicada.UI.Registros
{
    public partial class rCargo : Form
    {
        public rCargo()
        {
            InitializeComponent();
        }

        public Cargos LlenaClase()
        {
            Cargos cargos = new Cargos();


            cargos.Descripcion = DescripciontextBox.Text;
           


            return cargos;

        }
        private bool ValidarForm()
        {
            bool retorno = true;
            if (DescripciontextBox.Text.Length == 0)
            {
                retorno = false;
            }
           
            return retorno;

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cargos cargos = BLL.CargoBLL.Buscar((int)IdnumericUpDown.Value);

            if (ValidarForm())
            {
                if (cargos == null)
                {
                    if (CargoBLL.Guardar(LlenaClase()))
                        MessageBox.Show("Guardado Con Exito");
                    else
                        MessageBox.Show("El Cagos No Se Guardo");
                    limpiar();
                }
                else
                {
                    if (CargoBLL.Editar(LlenaClase()))
                        MessageBox.Show("Modificado Con Exito");
                    else
                        MessageBox.Show("El Cargos No Se Modifico");
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Cargos cargos = BLL.CargoBLL.Buscar(id);

            if (cargos != null)
            {

              
                DescripciontextBox.Text = cargos.Descripcion;
               
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void limpiar()
        {

            DescripciontextBox.Text = string.Empty;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdnumericUpDown.Value);


            if (BLL.CargoBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void RCargo_Load(object sender, EventArgs e)
        {

        }
    }

    }



