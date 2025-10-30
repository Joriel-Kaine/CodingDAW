using Microsoft.VisualBasic;
using System.ComponentModel.Design.Serialization;

namespace Tema3_Tarea31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MaxIntentos = 5;
        private void btnAccederSistema_Click(object sender, EventArgs e)
        {
            string usuario, password;
            int intentos = 0;
            bool esCorrecto = false;

            while (!esCorrecto && intentos < MaxIntentos)
            {
                usuario = Interaction.InputBox("Introduce el nombre de usuario", "Verificar usuario", "usuario");
                password = Interaction.InputBox("Introduce la contraseña", "Verificar contraseña", "contraseña");

                if (usuario != "root" && password != "1234")
                {
                    if (intentos == 0)
                    {
                        intentos++;
                        MessageBox.Show($"Has usado {intentos} intento para ingresar usuario y contraseña.", "Intentos");
                    }
                    else
                    {
                        intentos++;
                        MessageBox.Show($"Has usado {intentos} intentos para ingresar usuario y contraseña.", "Intentos");
                    }
                }
                else
                {
                    esCorrecto = true;
                }
            }


            if (esCorrecto)
            {
                MessageBox.Show("Bienvenido al sistema", "Mensaje de bienvenida");
            }
            else
            {
                MessageBox.Show("Se ha superado el número de intentos permitido.", "Límite superado");
            }
        }
    }
}
