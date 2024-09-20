using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistematico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            // Crear dos matrices de 4x4
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int[,] matrizResultado = new int[4, 4];

            try
            {
                // Leer los valores de la Matriz A desde los TextBox
                matrizA[0, 0] = int.Parse(txtA1.Text);
                matrizA[0, 1] = int.Parse(txtA2.Text);
                matrizA[0, 2] = int.Parse(txtA3.Text);
                matrizA[0, 3] = int.Parse(txtA4.Text);
                matrizA[1, 0] = int.Parse(txtA5.Text);
                matrizA[1, 1] = int.Parse(txtA6.Text);
                matrizA[1, 2] = int.Parse(txtA7.Text);
                matrizA[1, 3] = int.Parse(txtA8.Text);
                matrizA[2, 0] = int.Parse(txtA9.Text);
                matrizA[2, 1] = int.Parse(txtA10.Text);
                matrizA[2, 2] = int.Parse(txtA11.Text);
                matrizA[2, 3] = int.Parse(txtA12.Text);
                matrizA[3, 0] = int.Parse(txtA13.Text);
                matrizA[3, 1] = int.Parse(txtA14.Text);
                matrizA[3, 2] = int.Parse(txtA15.Text);
                matrizA[3, 3] = int.Parse(txtA16.Text);

                // Leer los valores de la Matriz B desde los TextBox
                matrizB[0, 0] = int.Parse(txtB1.Text);
                matrizB[0, 1] = int.Parse(txtB2.Text);
                matrizB[0, 2] = int.Parse(txtB3.Text);
                matrizB[0, 3] = int.Parse(txtB4.Text);
                matrizB[1, 0] = int.Parse(txtB5.Text);
                matrizB[1, 1] = int.Parse(txtB6.Text);
                matrizB[1, 2] = int.Parse(txtB7.Text);
                matrizB[1, 3] = int.Parse(txtB8.Text);
                matrizB[2, 0] = int.Parse(txtB9.Text);
                matrizB[2, 1] = int.Parse(txtB10.Text);
                matrizB[2, 2] = int.Parse(txtB11.Text);
                matrizB[2, 3] = int.Parse(txtB12.Text);
                matrizB[3, 0] = int.Parse(txtB13.Text);
                matrizB[3, 1] = int.Parse(txtB14.Text);
                matrizB[3, 2] = int.Parse(txtB15.Text);
                matrizB[3, 3] = int.Parse(txtB16.Text);

                // Calcular la suma de las matrices
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        matrizResultado[i, j] = matrizA[i, j] + matrizB[i, j];
                    }
                }

                // Mostrar la matriz resultado en el Label
                lblResultado.Text = "Suma de las matrices:\n";
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        lblResultado.Text += $"{matrizResultado[i, j]} ";
                    }
                    lblResultado.Text += "\n";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo números enteros en las matrices.");
            }
        }
    }
}
