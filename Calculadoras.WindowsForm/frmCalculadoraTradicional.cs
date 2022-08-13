using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras.WindowsForm
{
    public partial class frmCalculadoraTradicional : Form
    {

        private decimal valor1 = 0;
        private decimal valor2 = 0;
        private string operacao = "";

        public frmCalculadoraTradicional()
        {
            InitializeComponent();
        }


        private void txtTela_TextChanged(object sender, EventArgs e)
        {
            
        }

     
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            calculaAdicao();

        }

        private void btnAdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            calculaAdicao();
        }


        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calculaSubtracao();
        }
        private void btnSubtracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            calculaSubtracao();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calculaMultiplicacao();
        }
        private void btnMultiplicacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            calculaMultiplicacao();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calculaDivisao();
            
        }
  

        private void btnResultado_Click(object sender, EventArgs e)
        {

            calculaResultado();

        }

       

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTela.Text += "0";
        }


        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtTela.Text += ".";
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtTela.Text += "1";
        }

    


        private void btn2_Click(object sender, EventArgs e)
        {
            txtTela.Text += "2";
        }

     

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTela.Text += "3";
        }

    


        private void btn4_Click(object sender, EventArgs e)
        {
            txtTela.Text += "4";
        }

      

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTela.Text += "5";
        }
      

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txtTela.Text += "6";
        }
 
        private void btn7_Click(object sender, EventArgs e)
        {
            txtTela.Text += "7";
        }
    

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTela.Text += "8";
        }
   

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTela.Text += "9";
        }
   

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtTela.Text = "0";
            lblOperacao.Text = "";
            this.valor1 = 0;
            this.valor2 = 0;
           
        }
        private void btnCE_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void btnC_Click(object sender, EventArgs e)
        {
            txtTela.Text = "0";
           
        }
        private void btnC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmCalculadoraTradicional_Load(object sender, EventArgs e)
        {
            txtTela.Text = "0";
            lblOperacao.Text = "";
            btnResultado.Focus();
            
           
        }


        private void calculaAdicao()
        {
            if (txtTela.Text == "")
            {
                txtTela.Clear();
            }
            else
            {
                this.valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
                txtTela.Clear();
                this.operacao = "SOMA";
                lblOperacao.Text = Convert.ToString(this.valor1) + "+";

            }
        }

        private void calculaSubtracao()
        {
            if (txtTela.Text == "")
            {
                txtTela.Clear();
            }
            else
            {
                this.valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
                txtTela.Clear();
                this.operacao = "SUB";
                lblOperacao.Text = Convert.ToString(this.valor1) + "-";

            }
        }

        private void calculaMultiplicacao()
        {
            if (txtTela.Text == "")
            {
                txtTela.Clear();
            }
            else
            {
                this.valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
                txtTela.Clear();
                this.operacao = "MULT";
                lblOperacao.Text = Convert.ToString(this.valor1) + "x";

            }
        }

        private void calculaDivisao()
        {
            if (txtTela.Text == "")
            {
                txtTela.Text = "";
            }
            else
            {
                this.valor1 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);
                txtTela.Clear();
                this.operacao = "DIV";
                lblOperacao.Text = Convert.ToString(this.valor1) + "÷";

            }
        }

        private void calculaResultado()
        {
            if (this.valor1 != 0)
            {
                this.valor2 = decimal.Parse(txtTela.Text, CultureInfo.InvariantCulture);

            }
            else
            {
                txtTela.Text = "0";
            }

            if (this.operacao == "SOMA")
            {
                txtTela.Text = Convert.ToString(this.valor1 + this.valor2);
                lblOperacao.Text += Convert.ToString(this.valor2);
            }
            else
             if (this.operacao == "SUB")
            {
                txtTela.Text = Convert.ToString(this.valor1 - this.valor2);
                lblOperacao.Text += Convert.ToString(this.valor2);
            }
            else
                 if (this.operacao == "MULT")
            {
                txtTela.Text = Convert.ToString(this.valor1 * this.valor2);
                lblOperacao.Text += Convert.ToString(this.valor2);
            }
            else
                 if (this.operacao == "DIV")
            {
                txtTela.Text = Convert.ToString(this.valor1 / this.valor2);
                lblOperacao.Text += Convert.ToString(this.valor2);
            }
        }

       
    }

    
}
