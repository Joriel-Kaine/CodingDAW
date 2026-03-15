namespace Tema7_Tarea06_Integrador
{
    public partial class FormInicial : Form
    {
        private ListaAlumnos _listaAlumnos = new();
        private ListaCursos _listaCursos = new();
        private ListaProfesores _listaProfesores = new();

        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnGestionCursos_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new(_listaCursos, _listaAlumnos);

            formCursos.ShowDialog();
        }

        private void btnGestionAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos formAlumnos = new(_listaAlumnos, _listaCursos);

            formAlumnos.ShowDialog();
        }

        private void btnGestionProfesores_Click(object sender, EventArgs e)
        {
            FormProfesores formProfesores = new(_listaProfesores);

            formProfesores.ShowDialog();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            DatosEjemploCentroEscolar.DatosEjemploAlumnos(_listaAlumnos);
            DatosEjemploCentroEscolar.DatosEjemploCursos(_listaCursos);
            DatosEjemploCentroEscolar.DatosEjemploProfesores(_listaProfesores);
        }
    }
}
