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
    public partial class frmBidimensional : Form
    {
        public frmBidimensional()
        {
            InitializeComponent();
        }

        private void frmBidimensional_Load(object sender, EventArgs e)
        {
            pnlCirculo.Visible = false;
            pnlCuadrado.Visible = false;
            pnlTriangulo.Visible = false;
            cmbTipoBidimensional.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoBidimensional.Items.Add("Círculo");
            cmbTipoBidimensional.Items.Add("Cuadrado");
            cmbTipoBidimensional.Items.Add("Triángulo");
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (cmbTipoBidimensional.SelectedIndex != -1)
            {
                switch (cmbTipoBidimensional.SelectedIndex)
                {
                    case 0:
                        pnlCirculo.Visible = true;
                        pnlCuadrado.Visible = false;
                        pnlTriangulo.Visible = false;
                        break;

                    case 1:
                        pnlCirculo.Visible = false;
                        pnlCuadrado.Visible = true;
                        pnlTriangulo.Visible = false;
                        break;

                    case 2:
                        pnlCirculo.Visible = false;
                        pnlCuadrado.Visible = false;
                        pnlTriangulo.Visible = true;
                        break;
                }
            }
            else
                MessageBox.Show("Tiene que seleccionar una opción antes de continuar");
        }

        private void btnCalcularCir_Click(object sender, EventArgs e)
        {

        }

        private void btncalcularTrian_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularCuadra_Click(object sender, EventArgs e)
        {

        }
    }
}
