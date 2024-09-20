using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarNums_Click(object sender, EventArgs e)
        {
            // Limpiar la lista de numeros
            lstNumeros.Items.Clear();

            // Leer los valores de los TextBox
            if (int.TryParse(txtN.Text, out int x) && int.TryParse(txtY.Text, out int y))
            {
                if (x < y)
                {
                    // Mostrar los numeros de x a y (ascendente)
                    for (int i = x; i <= y; i++)
                    {
                        lstNumeros.Items.Add(i); // Agregar a la lista de numeros
                    }
                }
                else
                {
                    // Mostrar los numeros de x a y (descendente)
                    for (int i = x; i >= y; i--)
                    {
                        lstNumeros.Items.Add(i); // Agregar a la lista de numeros
                    }
                }
            }
            else
            {
                // Mensaje de error si los valores no son validos
                MessageBox.Show("Por favor ingrese números validos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
