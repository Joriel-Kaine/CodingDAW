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
            Alumno? alumno = FuncionesInterfaz.AddAlumno(_listaAlumnos);
            int posicion = _listaAlumnos.CountAlumnos();

            if (alumno != null)
            {
                lblListaNombres.Text += $"\n{posicion} - {alumno.Nombre}";
            }
        }

        private void btnAddNota_Click(object sender, EventArgs e)
        {
            FuncionesInterfaz.AddNota(_listaAlumnos);
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            FuncionesInterfaz.AddBirthday(_listaAlumnos);
        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
            FuncionesInterfaz.MostrarDatosAlumno(_listaAlumnos);
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            FuncionesInterfaz.DatosEjemplo(_listaAlumnos);
            lblListaNombres.Text = _listaAlumnos.MostrarListaNombres();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            FuncionesInterfaz.MostrarTodo(_listaAlumnos);
        }

        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {

        }
    }
}
