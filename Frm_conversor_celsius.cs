using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindownsForm
{
    public partial class Frm_conversor_celsius : Form
    {
        float tempcelsius = 0;
        float resultado = 0;

        public Frm_conversor_celsius()
        {
            InitializeComponent();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Close();
            Frm_Calculadora frm_Calculadora = new Frm_Calculadora();
            frm_Calculadora.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TB_TempC.Clear();
            TB_Fahrenheit.Clear(); 
            tempcelsius = 0;
            resultado = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempcelsius = Convert.ToSingle(TB_TempC.Text);
            float resultado = (float)(tempcelsius * 1.8 + 32);
            TB_Fahrenheit.Text = Convert.ToString(resultado);
        }
    }
}
