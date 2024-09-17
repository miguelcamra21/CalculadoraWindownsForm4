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
            {
                progressBar1.Value = progressBar1.Value + 1;
            }

            if (progressBar1.Value == 100)
            {
                TMRCarregamento.Enabled = false;
                this.Hide();
                Frm_Calculadora frm_Calculadora = new Frm_Calculadora();
                frm_Calculadora.ShowDialog();
                
            }
        }
    }
}

