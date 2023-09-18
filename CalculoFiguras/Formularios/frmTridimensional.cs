using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFiguras
{
    public partial class frmTridimensional : Form
    {
        public frmTridimensional()
        {
            InitializeComponent();
        }

        private void frmTridimensional_Load(object sender, EventArgs e)
        {
            pnlEsfera.Visible = false;
            pnlCubo.Visible = false;
            pnlTetraedro.Visible = false;
            cmbTipoTridimensional.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoTridimensional.Items.Add("Esfera");
            cmbTipoTridimensional.Items.Add("Cubo");
            cmbTipoTridimensional.Items.Add("Tetraedro");
        }

        private void btnSeleccionTrid_Click(object sender, EventArgs e)
        {
            if (cmbTipoTridimensional.SelectedIndex != -1)
            {
                switch (cmbTipoTridimensional.SelectedIndex)
                {
                    case 0:
                        pnlEsfera.Visible = true;
                        pnlCubo.Visible = false;
                        pnlTetraedro.Visible = false;
                        break;

                    case 1:
                        pnlEsfera.Visible = false;
                        pnlCubo.Visible = true;
                        pnlTetraedro.Visible = false;
                        break;

                    case 2:
                        pnlEsfera.Visible = false;
                        pnlCubo.Visible = false;
                        pnlTetraedro.Visible = true;
                        break;
                }
            }
            else
                MessageBox.Show("Tiene que seleccionar una opción antes de continuar");
        }
    }
}
