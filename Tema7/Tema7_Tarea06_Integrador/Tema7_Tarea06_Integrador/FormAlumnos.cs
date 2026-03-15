namespace Tema7_Tarea06_Integrador
{
    public partial class FormAlumnos : Form
    {
        private ListaAlumnos _listaAlumnos;
        private ListaCursos _listaCursos;
        public FormAlumnos(ListaAlumnos listaAlumnos, ListaCursos listaCursos)
        {
            InitializeComponent();
            this._listaAlumnos = listaAlumnos;
            this._listaCursos = listaCursos;
        }


        // Alumnos.
        private void btnLeerAlumno_Click(object sender, EventArgs e)
        {
            Alumno? alumno = FuncionesInterfazAlumno.AddAlumno(_listaAlumnos);
            int posicion = _listaAlumnos.CountAlumnos();

            if (alumno != null)
            {
                lblListaNombres.Text += $"\n{posicion} - {alumno.Nombre}";
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarTodo(_listaAlumnos);
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.AddBirthday(_listaAlumnos);
        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarDatosAlumno(_listaAlumnos);
        }

        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.EliminarPorPosicion(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.GenerarTextoListaNombres();
        }

        private void btnEliminarNombre_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.EliminarPorNombre(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.GenerarTextoListaNombres();
        }

        private void btnAlumnosEnCurso_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarAlumnosPorCurso(_listaAlumnos, _listaCursos);
        }



        // Notas y ordenación.
        private void btnAddNota_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.AddNota(_listaAlumnos);
        }

        private void btnMayorMedia_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarAlumnoMayorNotaMedia(_listaAlumnos);
        }

        private void btnOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.OrdenarPorOrdenAlfabetico(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.GenerarTextoListaNombres();
        }

        private void btnOrdenarNotaMedia_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.OrdenarPorNotaMedia(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.GenerarTextoListaNombres();
        }

        private void btnAlumnosAprobados_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarAlumnosAprobados(_listaAlumnos);
        }

        private void btnAlumnosSuspensos_Click(object sender, EventArgs e)
        {
            FuncionesInterfazAlumno.MostrarAlumnosSuspendidos(_listaAlumnos);
        }

        // Load.
        private void FormAlumno_Load(object sender, EventArgs e)
        {
            lblListaNombres.Text = _listaAlumnos.GenerarTextoListaNombres();
        }
    }
}
