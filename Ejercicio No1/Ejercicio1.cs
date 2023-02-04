using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_No1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        decimal Calculo = 0;
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(ValortextBox.Text);

            Calculo = parImpar(valor1);
            Calculo = positivoNegativo(valor1);
        }

        private decimal parImpar(decimal numero)
        {
            Decimal Resultado;

            numero = Convert.ToDecimal(ValortextBox.Text);
            Resultado = numero % 2;

            if (Resultado == 0)
            {
                //MessageBox.Show("El numero " + numero + " es par");
                parImparlabel.Text = "El numero " + numero + " es par";
            }
            else
            {
                //MessageBox.Show("El numero " + numero + " es impar");
                parImparlabel.Text = "El numero " + numero + " es impar";
            }
            return Resultado;
        }

        private decimal positivoNegativo(decimal numero)
        {
            numero = Convert.ToDecimal(ValortextBox.Text);
            if (numero < 0)
            {
                //MessageBox.Show("El numero " + numero + " es negativo");
                PosiNegalabel.Text = "El numero " + numero + " es negativo";
            }
            else
            {
                //MessageBox.Show("El numero " + numero + " es positivo");
                PosiNegalabel.Text = "El numero " + numero + " es positivo";
            }
            return numero;
        }

    }
}
