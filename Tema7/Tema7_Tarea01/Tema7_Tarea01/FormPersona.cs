namespace Tema7_Tarea01
{
    public partial class FormPersona : Form
    {
        private ListaPersonas _lista;

        public FormPersona()
        {
            InitializeComponent();
            _lista = new ListaPersonas();
        }

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            FuncionesInterfaz.LeerPersona(_lista);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            lblMostrar.Text = _lista.MostrarListaPersonas();
        }
    }
}
