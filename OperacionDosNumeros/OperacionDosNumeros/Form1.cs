using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionDosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //  Definir variables
            double num1, num2, result = 0;
            string operacion;

            //  Asignar valores a las variables
            num1 = Convert.ToDouble(tbNumero1.Text);
            num2 = Convert.ToDouble(tbNumero2.Text);
            operacion = tbOperacion.Text;

            //  Switch para realizar la operacion deseada de los dos numeros
            switch (operacion)
            {
                case "+":   //  Case para realizar la suma
                    result = num1 + num2; break;
                case "-":   //  Case para realizar la resta
                    result = num1 - num2; break;
                case "*":   //  Case para realizar la multiplicacion
                    result = num1 * num2; break;
                case "/":   //  Case para realizar la division
                    if (num2 != 0)  //  Si el numero es distinto de 0, se realiza la division
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("ERROR: No se puede dividir entre 0.");
                    }; break;
                default:
                    MessageBox.Show("No se digito ninguna operacion"); return ;
            }

            //  Se muestra en pantalla el resultado de la operacion
            label4.Text = "Resultado: " + result.ToString();

        }
    }
}
