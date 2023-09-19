using Modelo.Bidimensional;
using Modelo.Tridimensional;
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
        string tipofig;
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

        private void btnCalcularBidi_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                if (cmbTipoBidimensional.Text == "Círculo")
                {
                    Circulo circulo = new(tipofig,
                    cmbTipoBidimensional.Text,
                    double.Parse(txtRadioCirculo.Text));
                    MessageBox.Show($"La figura geométrica círculo tiene como área: {circulo.Area()} unidades cuadradas" +
                        $" y su perímetro es de: {circulo.Perimetro()} unidades.");
                }
                else if (cmbTipoBidimensional.Text == "Cuadrado")
                {
                    Cuadrado cuadrado = new(tipofig,
                    cmbTipoBidimensional.Text,
                    double.Parse(txtLadoCuadrado.Text));
                    MessageBox.Show($"La figura geométrica cuadrado tiene como área: {cuadrado.Area()} unidades cuadradas" +
                        $" y su perímetro es de: {cuadrado.Perimetro()} unidades.");
                }
                else if (cmbTipoBidimensional.Text == "Triángulo")
                {
                    Triangulo triangulo = new(tipofig,
                    cmbTipoBidimensional.Text,
                    double.Parse(txtBaseTriangulo.Text),
                    double.Parse(txtAlturaTriangulo.Text),
                    double.Parse(txtAristaTriangulo.Text));
                    MessageBox.Show($"La figura geométrica triángulo tiene como área: {triangulo.Area()} unidades cuadradas" +
                        $" y su perímetro es de: {triangulo.Perimetro()} unidades.");
                }
            }
            else
                MessageBox.Show($"Por favor ingrese {Valida()}");
        }

        private void LimpiarPnlCirculo()
        {
            txtRadioCirculo.Clear();
        }

        private void LimpiarPnlTriagulo()
        {
            txtBaseTriangulo.Clear();
            txtAlturaTriangulo.Clear();
            txtAristaTriangulo.Clear();
        }

        private void LimpiarPnlCuadro()
        {
            txtLadoCuadrado.Clear();
        }

        private string Valida()
        {
            if (pnlCirculo.Visible == true && txtRadioCirculo.Text.Trim().Length == 0)
            {
                txtRadioCirculo.Focus();
                return "radio del cículo.";
            }
            else if (pnlCuadrado.Visible == true && txtLadoCuadrado.Text.Trim().Length == 0)
            {
                txtLadoCuadrado.Focus();
                return "lado del cuadrado.";
            }
            else if (pnlTriangulo.Visible == true && txtBaseTriangulo.Text.Trim().Length == 0)
            {
                txtBaseTriangulo.Focus();
                return "base del triangulo.";
            }
            else if (pnlTriangulo.Visible == true && txtAlturaTriangulo.Text.Trim().Length == 0)
            {
                txtAlturaTriangulo.Focus();
                return "altura del triangulo.";
            }
            else if (pnlTriangulo.Visible == true && txtAristaTriangulo.Text.Trim().Length == 0)
            {
                txtAristaTriangulo.Focus();
                return "arista del triangulo.";
            }

            return "";
        }

        private void cmbTipoBidimensional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoBidimensional.SelectedIndex != -1)
            {
                switch (cmbTipoBidimensional.SelectedIndex)
                {
                    case 0:
                        pnlCirculo.Visible = true;
                        pnlCuadrado.Visible = false;
                        pnlTriangulo.Visible = false;
                        LimpiarPnlCuadro();
                        LimpiarPnlTriagulo();
                        break;

                    case 1:
                        pnlCirculo.Visible = false;
                        pnlCuadrado.Visible = true;
                        pnlTriangulo.Visible = false;
                        LimpiarPnlCirculo();
                        LimpiarPnlTriagulo();
                        break;

                    case 2:
                        pnlCirculo.Visible = false;
                        pnlCuadrado.Visible = false;
                        pnlTriangulo.Visible = true;
                        LimpiarPnlCirculo();
                        LimpiarPnlCuadro();
                        break;
                }
            }
            else
                MessageBox.Show("Tiene que seleccionar una opción antes de continuar.");
        }
    }
}
