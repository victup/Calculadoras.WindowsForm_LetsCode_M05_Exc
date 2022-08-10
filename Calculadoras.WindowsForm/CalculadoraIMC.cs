namespace Calculadoras.WindowsForm
{
    public partial class frmCalculadoraIMC : Form
    {
        public frmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbAltura.Clear();
            txbPeso.Clear();
            lblResultado.Text = String.Empty;
            txbPeso.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(txbPeso.Text);
            altura = Convert.ToDouble(txbAltura.Text.Replace(".",""));

            var (descricaoImc, resultadoImc) = CalcularImc(peso, altura/100);

            lblResultado.Text = $"{descricaoImc} \n Seu IMC: {resultadoImc}";
                            
        }

        private (string, double) CalcularImc(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };


            return (resultado, imc);

            // < 20 => "Abaixo do peso",
            //>= 20 and < 25 => "Peso normal",
            //>= 25 and < 30 => "Sobre peso",
            //>= 30 and < 40 => "Obeso",
            //_ => "Obeso mórbido"
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void txbAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadoraIMC_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "SISTEMA DE CALCULO DE IMC";
            txbPeso.Focus();
        }
    }
}