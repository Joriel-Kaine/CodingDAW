namespace Tema7_Tarea06_Integrador
{
    public partial class FormInicial : Form
    {
        private ListaAlumnos _listaAlumnos = new();

        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnGestionCursos_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos formAlumnos = new(_listaAlumnos);

            formAlumnos.ShowDialog();
        }

        private void btnGestionProfesores_Click(object sender, EventArgs e)
        {

        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            DatosEjemploCentroEscolar.DatosEjemploAlumnos(_listaAlumnos);
        }
    }
}
