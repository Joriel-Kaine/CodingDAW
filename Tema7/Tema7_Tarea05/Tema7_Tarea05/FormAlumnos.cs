namespace Tema7_Tarea05
{
    public partial class FormAlumnos : Form
    {
        private ListaAlumnos _listaAlumnos = new();
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void btnLeerAlumno_Click(object sender, EventArgs e)
        {
            Alumno? alumno = FuncionesInterfazAlumno.AddAlumno(_listaAlumnos);
            int posicion = _listaAlumnos.CountAlumnos();

            if (alumno != null)
            {
                lblListaNombres.Text += $"\n{posicion} - {alumno.Nombre}";
            }
        }

        private void btnAddNota_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.AddNota(_listaAlumnos);
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.AddBirthday(_listaAlumnos);
        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarDatosAlumno(_listaAlumnos);
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.DatosEjemplo(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.MostrarListaNombres();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarTodo(_listaAlumnos);
        }

        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.EliminarPorPosicion(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.MostrarListaNombres();
        }

        private void btnEliminarNombre_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.EliminarPorNombre(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.MostrarListaNombres();
        }

        private void btnMayorMedia_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarAlumnoMayorNotaMedia(_listaAlumnos);
        }

        private void btnOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.OrdenarPorOrdenAlfabetico(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.MostrarListaNombres();
        }

        private void btnOrdenarNotaMedia_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.OrdenarPorNotaMedia(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.MostrarListaNombres();
        }
    }
}
