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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbTipofigura.SelectedIndex != -1)
            {
                switch (cmbTipofigura.SelectedIndex)
                {
                    case 0:
                        frmBidimensional b = new frmBidimensional();
                        b.ShowDialog();
                    break;

                    case 1:
                        frmTridimensional t = new frmTridimensional();
                        t.ShowDialog();
                    break;
                }
            }
            else
                MessageBox.Show("Tiene que seleccionar una opción antes de continuar");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbTipofigura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipofigura.Items.Add("Figura Bidimensional");
            cmbTipofigura.Items.Add("Figura Tridimensional");
        }
    }
}
