namespace CalculoFiguras
{
    partial class frmTridimensional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTridimensional));
            btnSeleccionTrid = new Button();
            cmbTipoTridimensional = new ComboBox();
            label2 = new Label();
            pnlCubo = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            txtLadoCubo = new TextBox();
            btnCalcularCubo = new Button();
            label5 = new Label();
            label1 = new Label();
            pnlEsfera = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtRadioEsfera = new TextBox();
            btnCalcularEsf = new Button();
            label4 = new Label();
            pnlTetraedro = new Panel();
            pictureBox3 = new PictureBox();
            txtAristaTetraedro = new TextBox();
            label10 = new Label();
            label8 = new Label();
            btncalcularTetra = new Button();
            pnlCubo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlEsfera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTetraedro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnSeleccionTrid
            // 
            btnSeleccionTrid.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionTrid.Location = new Point(222, 65);
            btnSeleccionTrid.Name = "btnSeleccionTrid";
            btnSeleccionTrid.Size = new Size(84, 23);
            btnSeleccionTrid.TabIndex = 13;
            btnSeleccionTrid.Text = "Seleccionar";
            btnSeleccionTrid.UseVisualStyleBackColor = true;
            btnSeleccionTrid.Click += btnSeleccionTrid_Click;
            // 
            // cmbTipoTridimensional
            // 
            cmbTipoTridimensional.FormattingEnabled = true;
            cmbTipoTridimensional.Location = new Point(100, 64);
            cmbTipoTridimensional.Name = "cmbTipoTridimensional";
            cmbTipoTridimensional.Size = new Size(108, 23);
            cmbTipoTridimensional.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 11;
            label2.Text = "Seleccione";
            // 
            // pnlCubo
            // 
            pnlCubo.Controls.Add(pictureBox2);
            pnlCubo.Controls.Add(label6);
            pnlCubo.Controls.Add(txtLadoCubo);
            pnlCubo.Controls.Add(btnCalcularCubo);
            pnlCubo.Controls.Add(label5);
            pnlCubo.Location = new Point(20, 105);
            pnlCubo.Name = "pnlCubo";
            pnlCubo.Size = new Size(285, 185);
            pnlCubo.TabIndex = 14;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(45, 6);
            label6.Name = "label6";
            label6.Size = new Size(179, 17);
            label6.TabIndex = 1;
            label6.Text = "Área y volúmen de un Cubo";
            // 
            // txtLadoCubo
            // 
            txtLadoCubo.Location = new Point(109, 131);
            txtLadoCubo.Name = "txtLadoCubo";
            txtLadoCubo.Size = new Size(70, 23);
            txtLadoCubo.TabIndex = 3;
            // 
            // btnCalcularCubo
            // 
            btnCalcularCubo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularCubo.Location = new Point(206, 153);
            btnCalcularCubo.Name = "btnCalcularCubo";
            btnCalcularCubo.Size = new Size(75, 29);
            btnCalcularCubo.TabIndex = 0;
            btnCalcularCubo.Text = "Calcular";
            btnCalcularCubo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 120);
            label5.Name = "label5";
            label5.Size = new Size(97, 34);
            label5.TabIndex = 2;
            label5.Text = "Ingrese el lado\r\n    del cubo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 42);
            label1.TabIndex = 10;
            label1.Text = "CÁLCULO DE ÁREAS Y VOLÚMENES \r\n DE FIGURAS TRIIDIMENSIONALES";
            // 
            // pnlEsfera
            // 
            pnlEsfera.Controls.Add(pictureBox1);
            pnlEsfera.Controls.Add(label3);
            pnlEsfera.Controls.Add(txtRadioEsfera);
            pnlEsfera.Controls.Add(btnCalcularEsf);
            pnlEsfera.Controls.Add(label4);
            pnlEsfera.Location = new Point(20, 105);
            pnlEsfera.Name = "pnlEsfera";
            pnlEsfera.Size = new Size(285, 185);
            pnlEsfera.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 5);
            label3.Name = "label3";
            label3.Size = new Size(190, 17);
            label3.TabIndex = 1;
            label3.Text = "Área y volúmen de una Esfera";
            // 
            // txtRadioEsfera
            // 
            txtRadioEsfera.Location = new Point(109, 128);
            txtRadioEsfera.Name = "txtRadioEsfera";
            txtRadioEsfera.Size = new Size(70, 23);
            txtRadioEsfera.TabIndex = 3;
            // 
            // btnCalcularEsf
            // 
            btnCalcularEsf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularEsf.Location = new Point(206, 152);
            btnCalcularEsf.Name = "btnCalcularEsf";
            btnCalcularEsf.Size = new Size(75, 29);
            btnCalcularEsf.TabIndex = 0;
            btnCalcularEsf.Text = "Calcular";
            btnCalcularEsf.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(106, 34);
            label4.TabIndex = 2;
            label4.Text = "Ingrese el radio \r\n   de la esfera";
            // 
            // pnlTetraedro
            // 
            pnlTetraedro.Controls.Add(pictureBox3);
            pnlTetraedro.Controls.Add(txtAristaTetraedro);
            pnlTetraedro.Controls.Add(label10);
            pnlTetraedro.Controls.Add(label8);
            pnlTetraedro.Controls.Add(btncalcularTetra);
            pnlTetraedro.Location = new Point(20, 105);
            pnlTetraedro.Name = "pnlTetraedro";
            pnlTetraedro.Size = new Size(285, 185);
            pnlTetraedro.TabIndex = 16;
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
            // txtAristaTetraedro
            // 
            txtAristaTetraedro.Location = new Point(109, 134);
            txtAristaTetraedro.Name = "txtAristaTetraedro";
            txtAristaTetraedro.Size = new Size(70, 23);
            txtAristaTetraedro.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(6, 123);
            label10.Name = "label10";
            label10.Size = new Size(105, 34);
            label10.TabIndex = 6;
            label10.Text = "Ingrese el valor \r\n    de la arísta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(33, 3);
            label8.Name = "label8";
            label8.Size = new Size(205, 17);
            label8.TabIndex = 1;
            label8.Text = "Área y volúmen de un Tetraedro";
            // 
            // btncalcularTetra
            // 
            btncalcularTetra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcularTetra.Location = new Point(206, 152);
            btncalcularTetra.Name = "btncalcularTetra";
            btncalcularTetra.Size = new Size(75, 29);
            btncalcularTetra.TabIndex = 0;
            btncalcularTetra.Text = "Calcular";
            btncalcularTetra.UseVisualStyleBackColor = true;
            // 
            // frmTridimensional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 309);
            Controls.Add(btnSeleccionTrid);
            Controls.Add(cmbTipoTridimensional);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlCubo);
            Controls.Add(pnlEsfera);
            Controls.Add(pnlTetraedro);
            Name = "frmTridimensional";
            Text = "frmTridimensional";
            Load += frmTridimensional_Load;
            pnlCubo.ResumeLayout(false);
            pnlCubo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlEsfera.ResumeLayout(false);
            pnlEsfera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTetraedro.ResumeLayout(false);
            pnlTetraedro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSeleccionTrid;
        private ComboBox cmbTipoTridimensional;
        private Label label2;
        private Panel pnlCubo;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox txtLadoCubo;
        private Button btnCalcularCubo;
        private Label label5;
        private Label label1;
        private Panel pnlEsfera;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtRadioEsfera;
        private Button btnCalcularEsf;
        private Label label4;
        private Panel pnlTetraedro;
        private PictureBox pictureBox3;
        private TextBox txtAristaTetraedro;
        private Label label10;
        private Label label8;
        private Button btncalcularTetra;
    }
}