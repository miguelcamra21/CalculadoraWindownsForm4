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
    public partial class Frm_Calculadora : Form
    {
        float valor1 = 0;
        string operacao = "";



        public Frm_Calculadora()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "0";
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "+";
            Visor.Clear();
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "-";
            Visor.Clear();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "*";
            Visor.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "/";
            Visor.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Visor.Clear();
            valor1 = 0;
            operacao = "";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (this.operacao == "+")
            {   float resultado = valor1 + Convert.ToSingle(Visor.Text);
                Visor.Text = Convert.ToString(resultado);
            }
           

            if (this.operacao == "-")
            { float resultado = valor1 - Convert.ToSingle(Visor.Text);
                Visor.Text = Convert.ToString(resultado);
            }
            

            if (this.operacao == "*")
            { float resultado = valor1 * Convert.ToSingle(Visor.Text);
                Visor.Text = Convert.ToString(resultado);
            }
           

            if (this.operacao == "/")
            {  float resultado = valor1 / Convert.ToSingle(Visor.Text);
                Visor.Text = Convert.ToString(resultado);
            }
            
        }
    }
}
