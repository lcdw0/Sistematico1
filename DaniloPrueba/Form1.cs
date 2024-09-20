using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaniloPrueba
{
    public partial class Form1 : Form
    {
        int iIntentos = 0;
        const int iMaxIntentos = 3;
        const int iUsuarioCorrecto = 12;
        const int iContrasenaCorrecta = 1234;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificar si los valores ingresados son números enteros
            if (int.TryParse(txtUsuario.Text, out int usuario) &&
                int.TryParse(txtContrasena.Text, out int contrasena))
            {
                // Verificar credenciales
                if (usuario == iUsuarioCorrecto && contrasena == iContrasenaCorrecta)
                {
                    lblMensaje.Text = "Inicio de sesión exitoso.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    btnLogin.Enabled = false; // Deshabilitar el botón después del éxito
                }
                else
                {
                    iIntentos++;
                    lblMensaje.Text = $"Credenciales incorrectas. Intento {iIntentos} de {iMaxIntentos}.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;

                    // Verificar si se alcanzó el máximo de intentos
                    if (iIntentos >= iMaxIntentos)
                    {
                        MessageBox.Show("Has alcanzado el número máximo de intentos.", "Acceso denegado");
                        btnLogin.Enabled = false; // Deshabilitar el botón después de alcanzar el máximo de intentos
                    }
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, ingrese valores numéricos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}
