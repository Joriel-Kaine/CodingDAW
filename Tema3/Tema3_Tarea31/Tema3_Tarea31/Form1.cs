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

        private void btnAccederSistema_Click(object sender, EventArgs e)
        {
            string usuario;
            string password;
            int intentos = 1;

            usuario = Interaction.InputBox("Introduce el nombre de usuario", "Verificar usuario", "usuario");
            password = Interaction.InputBox("Introduce la contraseña", "Verificar contraseña", "contraseña");

            while (intentos <= 5)
            {
                if (usuario != "root" && password != "1234")
                {

                    intentos++;
                    MessageBox.Show($"Te quedan {intentos} intentos por usar.", "Intentos");
                }
                else
                {
                    MessageBox.Show("Bienvenido al sistema.", "Weldome");
                }
            }
        }
    }
}
