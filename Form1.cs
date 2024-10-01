namespace CalculadoraWindownsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TMRCarregamento_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 10)
            {
                TMRCarregamento.Enabled = false;
                this.Hide();
                Frm_Calculadora frm_Calculadora = new Frm_Calculadora();
                frm_Calculadora.Show();

            }

            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
        }
    }
}

