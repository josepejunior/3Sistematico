using Modelo;
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
    public partial class frmTridimensional : Form
    {
        string Tiofig;
        public frmTridimensional(frmPrincipal.Dato f)
        {
            InitializeComponent();
            Tiofig = f.tipofig;
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

        private void btnCalcularTridi_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                if (cmbTipoTridimensional.Text == "Esfera")
                {
                    Esfera esfera = new(Tiofig,
                    cmbTipoTridimensional.Text,
                    double.Parse(txtRadioEsfera.Text));
                    MessageBox.Show(esfera.ToString());
                }
                else if (cmbTipoTridimensional.Text == "Cubo")
                {
                    Cubo cubo = new(Tiofig,
                    cmbTipoTridimensional.Text,
                    double.Parse(txtLadoCubo.Text));
                    MessageBox.Show(cubo.ToString());
                }
                else if (cmbTipoTridimensional.Text == "Tetraedro")
                {
                    Tetraedro tetraedro = new(Tiofig,
                    cmbTipoTridimensional.Text,
                    double.Parse(txtAristaTetraedro.Text));
                    MessageBox.Show(tetraedro.ToString());
                }
            }
            else
                MessageBox.Show($"Por favor ingrese {Valida()}");
        }

        private string Valida()
        {
            if (pnlEsfera.Visible == true && txtRadioEsfera.Text.Trim().Length == 0)
            {
                txtRadioEsfera.Focus();
                return "radio de la esfera.";
            }
            else if (pnlCubo.Visible == true && txtLadoCubo.Text.Trim().Length == 0)
            {
                txtLadoCubo.Focus();
                return "lado del cubo.";
            }
            else if (pnlTetraedro.Visible == true && txtAristaTetraedro.Text.Trim().Length == 0)
            {
                txtAristaTetraedro.Focus();
                return "arista del tetraedro.";
            }

            return "";
        }

        private void cmbTipoTridimensional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoTridimensional.SelectedIndex != -1)
            {
                switch (cmbTipoTridimensional.SelectedIndex)
                {
                    case 0:
                        pnlEsfera.Visible = true;
                        txtRadioEsfera.Focus();
                        pnlCubo.Visible = false;
                        pnlTetraedro.Visible = false;
                        LimpiarPnlCubo();
                        LimpiarPnlTetraedro();
                        break;

                    case 1:
                        pnlEsfera.Visible = false;
                        pnlCubo.Visible = true;
                        txtLadoCubo.Focus();
                        pnlTetraedro.Visible = false;
                        LimpiarPnEsfera();
                        LimpiarPnlTetraedro();
                        break;

                    case 2:
                        pnlEsfera.Visible = false;
                        pnlCubo.Visible = false;
                        pnlTetraedro.Visible = true;
                        txtAristaTetraedro.Focus();
                        LimpiarPnEsfera();
                        LimpiarPnlCubo();
                        break;
                }
            }
            else
                MessageBox.Show("Tiene que seleccionar una opción antes de continuar.");
        }

        private void LimpiarPnEsfera()
        {
            txtRadioEsfera.Clear();
        }

        private void LimpiarPnlTetraedro()
        {
            txtAristaTetraedro.Clear();
        }

        private void LimpiarPnlCubo()
        {
            txtLadoCubo.Clear();
        }
    }
}
