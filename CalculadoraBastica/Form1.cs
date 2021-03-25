using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBastica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            resultado = num1 + num2;
            textResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            resultado = num1 - num2;
            textResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            resultado = num1 * num2;
            textResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);

            resultado = num1 / num2;
            textResultado.Text = resultado.ToString();
        }
    }
}
