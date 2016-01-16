using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritimeticos
{
    public partial class frmCalculadora : Form
    {

        int num1, num2, resultado;

        public frmCalculadora()
        {
            InitializeComponent();
        }



        private void btnSomar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txbNum1.Text);
            num2 = Convert.ToInt32(txbNum2.Text);
            txtResultado.Text = Somar(num1, num2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txbNum1.Text);
            num2 = Convert.ToInt32(txbNum2.Text);
            txtResultado.Text = Subtrair(num1, num2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txbNum1.Text);
            num2 = Convert.ToInt32(txbNum2.Text);
            txtResultado.Text = Multiplicar(num1, num2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txbNum1.Text);
            num2 = Convert.ToInt32(txbNum2.Text);
            txtResultado.Text = Dividir(num1, num2).ToString();
        }

        int Somar(params int[] numeros)
        {
            //qualquer quantidade de argumentos é valida
             resultado = 0;
            foreach(int numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
        int Subtrair(int n1, int n2)
        {
            resultado = n1 - n2;
            return resultado;
        }
        int Multiplicar(int n1, int n2)
        {
            resultado = n1 * n2;
            return resultado;
        }
        int Dividir(int n1, int n2)
        {
            resultado = n1 / n2;
            return resultado;
        }
    }
}
