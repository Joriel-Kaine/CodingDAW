using System.Drawing.Drawing2D;
using System.Net;
using Tema8_Tarea05_Integrador.Profesionales;
using Tema8_Tarea05_Integrador.Proyectos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tema8_Tarea05_Integrador
{
    public partial class FormGestionEmpresa : Form
    {
        private ListaProfesionales _listaProfesionales = new();
        private ListaProyectos _listaProyectos = new();

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
            FormProyectos formProyectos = new(_listaProyectos, _listaProfesionales);

            formProyectos.ShowDialog();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            FormAnalisis formAnalisis = new();

            formAnalisis.ShowDialog();
        }

        private void btnAutorrelleno_Click(object sender, EventArgs e)
        {
            // Profesionales.
            _listaProfesionales.AddProfesional(new Designer
                ("Pedro", "98653214P", "pedro@email.com", "+34696642288", "Diseño Gráfico", 10.5));
            _listaProfesionales.AddProfesional(new Desarrollador
                ("Manu", "02088244M", "manu@email.com", "+34699822802", "CSharp", 14.8));
            _listaProfesionales.AddProfesional(new Redactor
                ("Laura", "65412388L", "laura@email.com", "+34688442200", "Tecnología", 0.14));
            _listaProfesionales.AddProfesional(new Desarrollador
                ("Lito", "92068041K", "lito@email.com", "+34666108040", "Phyton", 18));
            _listaProfesionales.AddProfesional(new Desarrollador
                ("Jane", "10050064J", "jane@email.com", "+34682005995", "Java", 13.4));
            _listaProfesionales.AddProfesional(new Designer
                ("Marina", "89142869N", "marina@email.com", "+34622189150", "Diseño Web", 12.2));
            _listaProfesionales.AddProfesional(new Designer
                ("Juan", "12385295Z", "juan@email.com", "+34600763298", "Ilustración", 11));
            _listaProfesionales.AddProfesional(new Designer
                ("Carlos", "97463182C", "carlos@email.com", "+34621366990", "Diseño UI", 15.3));
            _listaProfesionales.AddProfesional(new Desarrollador
                ("Rosa", "18903719R", "rosa@email.com", "+34659338060", "CSharp", 14));
            _listaProfesionales.AddProfesional(new Desarrollador
                ("Elena", "55739150E", "elena@email.com", "+34682582010", "Rust", 13.7));
            _listaProfesionales.AddProfesional(new Designer
                ("Marcos", "68626460S", "marcos@email.com", "+34618389271", "Diseño Gráfico", 10.8));
            _listaProfesionales.AddProfesional(new Redactor
                ("Milena", "40235689A", "milena@email.com", "+34685316497", "Entretenimiento", 0.12));
            _listaProfesionales.AddProfesional(new Redactor
                ("Javier", "85432055V", "javier@email.com", "+34677205080", "Ciencia", 0.08));
            _listaProfesionales.AddProfesional(new Desarrollador
                ("Ramón", "64825193Y", "ramon@email.com", "+34690565452", "Python", 17.3));
            _listaProfesionales.AddProfesional(new Redactor
                ("Lidia", "37246805D", "lidia@email.com", "+34628355390", "Marketing", 0.10));


            //Proyectos.
            _listaProyectos.AddProyecto(new("Atlas Web", 1420, 120));
            _listaProyectos.AddProyecto(new("Orion Security Suite", 9345, 180));
            _listaProyectos.AddProyecto(new("Aurora CRM", 4572, 160));
            _listaProyectos.AddProyecto(new("Vulcano IA", 5031, 240));
            _listaProyectos.AddProyecto(new("Neptuno ERP", 2864, 200));
            _listaProyectos.AddProyecto(new("Zenith Dashboard", 7813, 50));
            _listaProyectos.AddProyecto(new("Helix Mobile App", 3198, 75));
            _listaProyectos.AddProyecto(new("Mercurio Cloud", 6247, 90));
            _listaProyectos.AddProyecto(new("Lumen Data Sync", 8659, 140));
            _listaProyectos.AddProyecto(new("Nova Billing Tool", 7124, 110));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
