namespace Tema7_Tarea04
{
    public partial class FormAlumno : Form
    {
        private ListaAlumnos _listaAlumnos = new();
        public FormAlumno()
        {
            InitializeComponent();
        }

        private void btnLeerAlumno_Click(object sender, EventArgs e)
        {
            Alumno? alumno = FuncionesInterfaz.AddAlumno(_listaAlumnos);
            
            if (alumno != null)
            {
                lblListaNombres.Text += $"\n {alumno.Nombre}";
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
        }
    }
}
