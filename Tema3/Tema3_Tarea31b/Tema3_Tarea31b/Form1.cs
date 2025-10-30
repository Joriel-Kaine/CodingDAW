using Microsoft.VisualBasic;

namespace Tema3_Tarea31b
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

            while (intentos < MaxIntentos)
            {
                usuario = Interaction.InputBox("Introduce el nombre de usuario", "Verificar usuario", "usuario");
                password = Interaction.InputBox("introduce la contraseña", "Verificar contraseña", "contraseña");

                if (usuario == "root" && password == "1234")
                {
                    MessageBox.Show("Bienvenido al sistema.", "Mensaje de bienvenida");
                    break;
                }
                else if (intentos == 0)
                {
                    intentos++;
                    MessageBox.Show($"Has usado {intentos} intento para ingresar usuario y contraseña.", "Intentos");
                }
                else
                {
                    intentos++;
                    MessageBox.Show($"Has usado {intentos} intentos para ignorar usuario y contraseña.", "Intentos");
                }
            }

            if (intentos == MaxIntentos)
            {
                MessageBox.Show("Se ha superado el número de intentos permitido.", "Límite superado");
            }
        }
    }
}
