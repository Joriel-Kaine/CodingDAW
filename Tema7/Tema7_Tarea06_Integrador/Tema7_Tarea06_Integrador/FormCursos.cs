using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema7_Tarea06_Integrador
{
    public partial class FormCursos : Form
    {
        private ListaCursos _listaCursos;

        public FormCursos(ListaCursos listaCursos)
        {
            InitializeComponent();
            this._listaCursos = listaCursos;
        }

        private void btnLeerCurso_Click(object sender, EventArgs e)
        {
            FuncionesInterfazCurso.AddCurso(_listaCursos);
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            FuncionesInterfazCurso.EliminarCurso(_listaCursos);
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            FuncionesInterfazCurso.MostrarTodo(_listaCursos);
        }

        private void btnMostrarAlumnosDeCurso_Click(object sender, EventArgs e)
        {

        }
    }
}
