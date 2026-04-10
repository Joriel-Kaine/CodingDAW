using System.Drawing.Drawing2D;
using Tema8_Tarea05_Integrador.Profesionales;

namespace Tema8_Tarea05_Integrador
{
    public partial class FormGestionEmpresa : Form
    {
        private ListaProfesionales _listaProfesionales = new();

        public FormGestionEmpresa()
        {
            InitializeComponent();
        }

        private void FormGestionEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionProfesionales_Click(object sender, EventArgs e)
        {
            FormProfesionales formProfesionales = new(_listaProfesionales);

            formProfesionales.ShowDialog();
        }

        private void btnGestionProyectos_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {

        }

        private void btnAutorrelleno_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
