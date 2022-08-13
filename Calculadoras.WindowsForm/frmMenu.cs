using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras.WindowsForm
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menCalculadoraImc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCalculadoraIMC frmCalculadoraIMC = new frmCalculadoraIMC();  
            frmCalculadoraIMC.ShowDialog();
            this.Show();
            

        }

        private void menCalculadoraTradicional_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCalculadoraTradicional frmCalculadoraTradicional = new frmCalculadoraTradicional();
            frmCalculadoraTradicional.ShowDialog();
            this.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
