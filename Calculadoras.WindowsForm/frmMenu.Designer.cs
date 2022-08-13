namespace Calculadoras.WindowsForm
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menCalculadoras = new System.Windows.Forms.ToolStripMenuItem();
            this.menCalculadoraImc = new System.Windows.Forms.ToolStripMenuItem();
            this.menCalculadoraTradicional = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menCalculadoras});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menCalculadoras
            // 
            this.menCalculadoras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menCalculadoraImc,
            this.menCalculadoraTradicional});
            this.menCalculadoras.Name = "menCalculadoras";
            this.menCalculadoras.Size = new System.Drawing.Size(87, 20);
            this.menCalculadoras.Text = "Calculadoras";
            // 
            // menCalculadoraImc
            // 
            this.menCalculadoraImc.Name = "menCalculadoraImc";
            this.menCalculadoraImc.Size = new System.Drawing.Size(197, 22);
            this.menCalculadoraImc.Text = "Calculadora IMC";
            this.menCalculadoraImc.Click += new System.EventHandler(this.menCalculadoraImc_Click);
            // 
            // menCalculadoraTradicional
            // 
            this.menCalculadoraTradicional.Name = "menCalculadoraTradicional";
            this.menCalculadoraTradicional.Size = new System.Drawing.Size(197, 22);
            this.menCalculadoraTradicional.Text = "Calculadora Tradicional";
            this.menCalculadoraTradicional.Click += new System.EventHandler(this.menCalculadoraTradicional_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadoras";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menCalculadoras;
        private ToolStripMenuItem menCalculadoraImc;
        private ToolStripMenuItem menCalculadoraTradicional;
        private PictureBox pictureBox1;
    }
}