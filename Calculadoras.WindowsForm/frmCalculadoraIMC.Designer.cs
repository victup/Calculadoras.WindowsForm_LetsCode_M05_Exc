namespace Calculadoras.WindowsForm
{
    partial class frmCalculadoraIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraIMC));
            this.txbAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbAltura
            // 
            this.txbAltura.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txbAltura.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbAltura.Location = new System.Drawing.Point(157, 192);
            this.txbAltura.Mask = "0,00";
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(191, 35);
            this.txbAltura.TabIndex = 3;
            this.txbAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbAltura_MaskInputRejected);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(157, 243);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 35);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(260, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 35);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(27, 278);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(410, 69);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "0,00";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAltura.Location = new System.Drawing.Point(98, 197);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(53, 20);
            this.lblAltura.TabIndex = 14;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPeso.Location = new System.Drawing.Point(98, 159);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 20);
            this.lblPeso.TabIndex = 13;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(80, 83);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SISTEMA DE CALCULO DE IMC";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txbPeso
            // 
            this.txbPeso.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPeso.Location = new System.Drawing.Point(157, 154);
            this.txbPeso.MaxLength = 10;
            this.txbPeso.Multiline = true;
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(191, 32);
            this.txbPeso.TabIndex = 2;
            this.txbPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPeso.TextChanged += new System.EventHandler(this.txbPeso_TextChanged);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(193, 13);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(78, 67);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 10;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // frmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 356);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.imgLogo);
            this.Name = "frmCalculadoraIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora IMC";
            this.Load += new System.EventHandler(this.frmCalculadoraIMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txbAltura;
        private Button btnLimpar;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblAltura;
        private Label lblPeso;
        private Label lblTitulo;
        private TextBox txbPeso;
        private PictureBox imgLogo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menCalculadoras;
        private ToolStripMenuItem menCalculadoraImc;
        private ToolStripMenuItem menCalculadoraTradicional;
    }
}