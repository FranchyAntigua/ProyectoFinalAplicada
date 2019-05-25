using ProyectoFinalAplicada.BLL;
using ProyectoFinalAplicada.DAL;
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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        private void LlenarComboBox()
        {
            BLL.CargoBLL ArtRepositorio = new BLL.CargoBLL();

            CargocomboBox.DataSource = CargoBLL.GetList(c => true);
            CargocomboBox.ValueMember = "CargoId";
            CargocomboBox.DisplayMember = "Descripcion";
        }
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Usuarios usuarios = BLL.UsuariosBLL.Buscar(id);

            if (usuarios != null)
            {

                FechaIngresoDateTimePicker.Value = usuarios.FechaIngreso;
                NombrestextBox.Text = usuarios.Nombres;
                UsuariotextBox.Text = usuarios.Usuario;
                EmailtextBox.Text = usuarios.Email;
                ClavetextBox.Text = usuarios.Clave;
                NivelUsuarioComboBox.Text = usuarios.NivelUsuario.ToString();
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void limpiar()
        {

            NombrestextBox.Text = string.Empty;
            UsuariotextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            NivelUsuarioComboBox.SelectedIndex = 0;
        }

        public Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();

            int nivelusu = 0;

            usuarios.Nombres = NombrestextBox.Text;
            usuarios.Email = EmailtextBox.Text;

            if (NivelUsuarioComboBox.SelectedIndex == 0)
                nivelusu = 1;
            else
                nivelusu = 2;


            usuarios.NivelUsuario = nivelusu;
            usuarios.Usuario = UsuariotextBox.Text;
            usuarios.Clave = ClavetextBox.Text;
            usuarios.FechaIngreso = FechaIngresoDateTimePicker.Value ;


            return usuarios;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {


            Usuarios usuarios = BLL.UsuariosBLL.Buscar((int)IdnumericUpDown.Value);

            if (ValidarForm())
            {
                if (usuarios == null)
                {
                    if (UsuariosBLL.Guardar(LlenaClase()))
                    {
                        MessageBox.Show("Guardado Con Exito");
                        limpiar();
                    }
                    else
                        MessageBox.Show("El Usuario No Se Guardo");
                }
                else
                {
                    if (UsuariosBLL.Editar(LlenaClase()))
                        MessageBox.Show("Modificado Con Exito");
                
                    else
                        MessageBox.Show("El Usuario No Se Modifico");
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }
        //else

        //LimpiarProvider();


        // }x
        private bool ValidarForm()
        {
            bool retorno = true;
            if (NombrestextBox.Text.Length == 0)
            {
                retorno = false;
            }
            else if (UsuariotextBox.TextLength == 0)
            {
                retorno = false;
            }
            else if (EmailtextBox.TextLength == 0)
            {
                retorno = false;
            }
            else if (ClavetextBox.TextLength == 0)
            {
                retorno = false;
            }
            //else if (NivelUsuarioComboBox.SelectedIndex <= 0)
            //{
            //    retorno = false;
            //}
            return retorno;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdnumericUpDown.Value);


            if (BLL.UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            limpiar();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }

}
