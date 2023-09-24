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
        public string Tipofig;
        public frmBidimensional(frmPrincipal.Dato f)
        {
            InitializeComponent();
            Tipofig = f.tipofig;
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
                    Circulo circulo = new(Tipofig,
                    cmbTipoBidimensional.Text,
                    double.Parse(txtRadioCirculo.Text));
                    MessageBox.Show(circulo.ToString());
                }
                else if (cmbTipoBidimensional.Text == "Cuadrado")
                {
                    Cuadrado cuadrado = new(Tipofig,
                    cmbTipoBidimensional.Text,
                    double.Parse(txtLadoCuadrado.Text));
                    MessageBox.Show(cuadrado.ToString());
                }
                else if (cmbTipoBidimensional.Text == "Triángulo")
                {
                    Triangulo triangulo = new(Tipofig,
                    cmbTipoBidimensional.Text,
                    double.Parse(txtBaseTriangulo.Text),
                    double.Parse(txtAlturaTriangulo.Text),
                    double.Parse(txtAristaTriangulo.Text));
                    MessageBox.Show(triangulo.ToString());
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
                return "base del triángulo.";
            }
            else if (pnlTriangulo.Visible == true && txtAlturaTriangulo.Text.Trim().Length == 0)
            {
                txtAlturaTriangulo.Focus();
                return "altura del triángulo.";
            }
            else if (pnlTriangulo.Visible == true && txtAristaTriangulo.Text.Trim().Length == 0)
            {
                txtAristaTriangulo.Focus();
                return "arista del triángulo.";
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
                        txtRadioCirculo.Focus();
                        pnlCuadrado.Visible = false;
                        pnlTriangulo.Visible = false;
                        LimpiarPnlCuadro();
                        LimpiarPnlTriagulo();
                        break;

                    case 1:
                        pnlCirculo.Visible = false;
                        pnlCuadrado.Visible = true;
                        txtLadoCuadrado.Focus();
                        pnlTriangulo.Visible = false;
                        LimpiarPnlCirculo();
                        LimpiarPnlTriagulo();
                        break;

                    case 2:
                        pnlCirculo.Visible = false;
                        pnlCuadrado.Visible = false;
                        pnlTriangulo.Visible = true;
                        txtBaseTriangulo.Focus();
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
