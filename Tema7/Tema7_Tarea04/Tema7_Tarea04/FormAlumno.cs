namespace Tema7_Tarea04
{
    public partial class FormAlumno : Form
    {
        private ListaAlumnos _listaAlumnos;
        public FormAlumno()
        {
            InitializeComponent();
            _listaAlumnos = new();
        }

        private void btnLeerAlumno_Click(object sender, EventArgs e)
        {
            FuncionesInterfaz.AddAlumno(_listaAlumnos);
        }

        private void btnAddNota_Click(object sender, EventArgs e)
        {
            FuncionesInterfaz.AddNota(_listaAlumnos);
        }


    }
}
