using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,   
        Multiplicacion = 4,
        Modulo = 5
    }


    public partial class Calculator : Form
    {
        double Valor1 = 0;
        double Valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        bool unNumeroLeido = false; 
        public Calculator()
        {
            InitializeComponent();
        }
        private void LeerNumero(string numero)
        {

            unNumeroLeido=true;
            if (ResultBox.Text == "0" && ResultBox.Text != null)
            {
                ResultBox.Text = numero;
            }
            else
            {
                ResultBox.Text += numero;
            }
        }
        private double EjecutarOperacion ()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = Valor1 + Valor2;
                    break;
                case Operacion.Resta:
                    resultado = Valor1 - Valor2;
                    break;
                case Operacion.Division:
                    if (Valor2 == 0)
                    {
                        MessageBox.Show("No se puede divir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = Valor1 / Valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = Valor1 * Valor2;
                    break;
                case Operacion.Modulo:
                    resultado = Valor1 % Valor2;
                    break;
            }
            return resultado;
;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Valor2 == 0 && unNumeroLeido)
            {
                Valor2 = Convert.ToDouble(ResultBox.Text);
                double resultado = EjecutarOperacion();
                Valor1 = 0;
                Valor2 = 0;
                unNumeroLeido = false;
                ResultBox.Text = Convert.ToString(resultado);

            }
        }
        private void ObtenerValor (string operador)
        {
            Valor1 = Convert.ToDouble(ResultBox.Text);
            ResultBox.Text = "0";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 1)
            {
                string txtResultado = ResultBox.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);
                
                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    ResultBox.Text = "0";
                }
                else
                {
                    ResultBox.Text = txtResultado;
                }
            }
            else
            {
                ResultBox.Text = "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            unNumeroLeido = true;
            if(ResultBox.Text == "0")
            {
                return;
            }
            else
            {
                ResultBox.Text += "0";
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            LeerNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Contains("."))
            {
                return;
            }
            ResultBox.Text += ".";
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
