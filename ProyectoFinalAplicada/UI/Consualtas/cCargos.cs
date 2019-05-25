using ProyectoFinalAplicada.BLL;
using ProyectoFinalAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicada.UI.Consualtas
{
    public partial class cCargos : Form
    {
        public cCargos()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Cargos, bool>> filtro = a => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID 
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.CargoId == id;
                    break;

            }

            CargosConsultaDataGridView.DataSource = CargoBLL.GetList(filtro);
        }

        private void CCargos_Load(object sender, EventArgs e)
        {

        }

        private void CargosConsultaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
