namespace CalculoFiguras
{
    partial class frmBidimensional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBidimensional));
            label1 = new Label();
            label2 = new Label();
            cmbTipoBidimensional = new ComboBox();
            pictureBox2 = new PictureBox();
            txtLadoCuadrado = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnCalcularCuadra = new Button();
            pictureBox1 = new PictureBox();
            txtRadioCirculo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnCalcularCir = new Button();
            btnSeleccion = new Button();
            pnlCuadrado = new Panel();
            pnlCirculo = new Panel();
            pnlTriangulo = new Panel();
            pictureBox3 = new PictureBox();
            txtAristaTriangulo = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtAlturaTriangulo = new TextBox();
            txtBaseTriangulo = new TextBox();
            btncalcularTrian = new Button();
            label11 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCuadrado.SuspendLayout();
            pnlCirculo.SuspendLayout();
            pnlTriangulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 42);
            label1.TabIndex = 0;
            label1.Text = "CÁLCULO DE ÁREAS Y PERÍMETROS \r\n   DE FIGURAS BIDIMENSIONALES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 1;
            label2.Text = "Seleccione";
            // 
            // cmbTipoBidimensional
            // 
            cmbTipoBidimensional.FormattingEnabled = true;
            cmbTipoBidimensional.Location = new Point(103, 65);
            cmbTipoBidimensional.Name = "cmbTipoBidimensional";
            cmbTipoBidimensional.Size = new Size(108, 23);
            cmbTipoBidimensional.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtLadoCuadrado
            // 
            txtLadoCuadrado.Location = new Point(109, 120);
            txtLadoCuadrado.Name = "txtLadoCuadrado";
            txtLadoCuadrado.Size = new Size(70, 23);
            txtLadoCuadrado.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 109);
            label5.Name = "label5";
            label5.Size = new Size(97, 34);
            label5.TabIndex = 2;
            label5.Text = "Ingrese el lado\r\n del cuadrado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 6);
            label6.Name = "label6";
            label6.Size = new Size(213, 17);
            label6.TabIndex = 1;
            label6.Text = "Área y perímetro de un Cuadrado";
            // 
            // btnCalcularCuadra
            // 
            btnCalcularCuadra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularCuadra.Location = new Point(206, 153);
            btnCalcularCuadra.Name = "btnCalcularCuadra";
            btnCalcularCuadra.Size = new Size(75, 29);
            btnCalcularCuadra.TabIndex = 0;
            btnCalcularCuadra.Text = "Calcular";
            btnCalcularCuadra.UseVisualStyleBackColor = true;
            btnCalcularCuadra.Click += btnCalcularCuadra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Circulo;
            pictureBox1.Location = new Point(79, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtRadioCirculo
            // 
            txtRadioCirculo.Location = new Point(109, 128);
            txtRadioCirculo.Name = "txtRadioCirculo";
            txtRadioCirculo.Size = new Size(70, 23);
            txtRadioCirculo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(106, 34);
            label4.TabIndex = 2;
            label4.Text = "Ingrese el radio \r\n    del círculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 5);
            label3.Name = "label3";
            label3.Size = new Size(195, 17);
            label3.TabIndex = 1;
            label3.Text = "Área y perímetro de un Círculo";
            // 
            // btnCalcularCir
            // 
            btnCalcularCir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularCir.Location = new Point(206, 152);
            btnCalcularCir.Name = "btnCalcularCir";
            btnCalcularCir.Size = new Size(75, 29);
            btnCalcularCir.TabIndex = 0;
            btnCalcularCir.Text = "Calcular";
            btnCalcularCir.UseVisualStyleBackColor = true;
            btnCalcularCir.Click += btnCalcularCir_Click;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccion.Location = new Point(225, 66);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(84, 23);
            btnSeleccion.TabIndex = 4;
            btnSeleccion.Text = "Seleccionar";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // pnlCuadrado
            // 
            pnlCuadrado.Controls.Add(pictureBox2);
            pnlCuadrado.Controls.Add(label6);
            pnlCuadrado.Controls.Add(txtLadoCuadrado);
            pnlCuadrado.Controls.Add(btnCalcularCuadra);
            pnlCuadrado.Controls.Add(label5);
            pnlCuadrado.Location = new Point(24, 104);
            pnlCuadrado.Name = "pnlCuadrado";
            pnlCuadrado.Size = new Size(285, 185);
            pnlCuadrado.TabIndex = 7;
            // 
            // pnlCirculo
            // 
            pnlCirculo.Controls.Add(pictureBox1);
            pnlCirculo.Controls.Add(label3);
            pnlCirculo.Controls.Add(txtRadioCirculo);
            pnlCirculo.Controls.Add(btnCalcularCir);
            pnlCirculo.Controls.Add(label4);
            pnlCirculo.Location = new Point(24, 104);
            pnlCirculo.Name = "pnlCirculo";
            pnlCirculo.Size = new Size(285, 185);
            pnlCirculo.TabIndex = 8;
            // 
            // pnlTriangulo
            // 
            pnlTriangulo.Controls.Add(pictureBox3);
            pnlTriangulo.Controls.Add(txtAristaTriangulo);
            pnlTriangulo.Controls.Add(label10);
            pnlTriangulo.Controls.Add(label8);
            pnlTriangulo.Controls.Add(label9);
            pnlTriangulo.Controls.Add(txtAlturaTriangulo);
            pnlTriangulo.Controls.Add(txtBaseTriangulo);
            pnlTriangulo.Controls.Add(btncalcularTrian);
            pnlTriangulo.Controls.Add(label11);
            pnlTriangulo.Controls.Add(label7);
            pnlTriangulo.Location = new Point(24, 104);
            pnlTriangulo.Name = "pnlTriangulo";
            pnlTriangulo.Size = new Size(285, 185);
            pnlTriangulo.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(79, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(121, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // txtAristaTriangulo
            // 
            txtAristaTriangulo.Location = new Point(45, 157);
            txtAristaTriangulo.Name = "txtAristaTriangulo";
            txtAristaTriangulo.Size = new Size(70, 23);
            txtAristaTriangulo.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(8, 165);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 6;
            label10.Text = "Arísta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(36, 5);
            label8.Name = "label8";
            label8.Size = new Size(210, 17);
            label8.TabIndex = 1;
            label8.Text = "Área y perímetro de un Triángulo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 136);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 5;
            label9.Text = "Altura";
            // 
            // txtAlturaTriangulo
            // 
            txtAlturaTriangulo.Location = new Point(45, 128);
            txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            txtAlturaTriangulo.Size = new Size(70, 23);
            txtAlturaTriangulo.TabIndex = 8;
            // 
            // txtBaseTriangulo
            // 
            txtBaseTriangulo.Location = new Point(45, 98);
            txtBaseTriangulo.Name = "txtBaseTriangulo";
            txtBaseTriangulo.Size = new Size(70, 23);
            txtBaseTriangulo.TabIndex = 3;
            // 
            // btncalcularTrian
            // 
            btncalcularTrian.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcularTrian.Location = new Point(206, 152);
            btncalcularTrian.Name = "btncalcularTrian";
            btncalcularTrian.Size = new Size(75, 29);
            btncalcularTrian.TabIndex = 0;
            btncalcularTrian.Text = "Calcular";
            btncalcularTrian.UseVisualStyleBackColor = true;
            btncalcularTrian.Click += btncalcularTrian_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 77);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 7;
            label11.Text = "Ingrese";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 101);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 2;
            label7.Text = "Base";
            // 
            // frmBidimensional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 313);
            Controls.Add(btnSeleccion);
            Controls.Add(cmbTipoBidimensional);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlTriangulo);
            Controls.Add(pnlCuadrado);
            Controls.Add(pnlCirculo);
            Name = "frmBidimensional";
            Text = "frmBidimensional";
            Load += frmBidimensional_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCuadrado.ResumeLayout(false);
            pnlCuadrado.PerformLayout();
            pnlCirculo.ResumeLayout(false);
            pnlCirculo.PerformLayout();
            pnlTriangulo.ResumeLayout(false);
            pnlTriangulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTipoBidimensional;
        private Button btnSeleccion;
        private PictureBox pictureBox2;
        private TextBox txtLadoCuadrado;
        private Label label5;
        private Label label6;
        private Button btnCalcularCuadra;
        private PictureBox pictureBox1;
        private TextBox txtRadioCirculo;
        private Label label4;
        private Label label3;
        private Button btnCalcularCir;
        private Panel pnlCuadrado;
        private Panel pnlCirculo;
        private Panel pnlTriangulo;
        private Button btncalcularTrian;
        private Label label8;
        private Label label7;
        private TextBox txtBaseTriangulo;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtAlturaTriangulo;
        private TextBox txtAristaTriangulo;
    }
}