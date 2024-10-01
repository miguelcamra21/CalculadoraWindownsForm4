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
    public partial class Frm_Cm_Polegada : Form
    {
        float cm = 0;
        float resultado = 0;
        public Frm_Cm_Polegada()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            cm = Convert.ToSingle(textbox_cm.Text);
            float resultado = (float)(cm / 2.54);
            textbox_polegada.Text = Convert.ToString(resultado);
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            textbox_cm.Clear();
            textbox_polegada.Clear();
            cm = 0;
            resultado = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
            Frm_Calculadora frm_Calculadora = new Frm_Calculadora();
            frm_Calculadora.ShowDialog();
        }
    }
}
