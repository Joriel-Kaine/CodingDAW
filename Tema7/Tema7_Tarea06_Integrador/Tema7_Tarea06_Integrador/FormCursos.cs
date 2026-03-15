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
        private ListaAlumnos _listaAlumnos;

        public FormCursos(ListaCursos listaCursos, ListaAlumnos listaAlumnos)
        {
            InitializeComponent();
            this._listaCursos = listaCursos;
            this._listaAlumnos = listaAlumnos;
        }



        // Cursos.
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
            FuncionesInterfazAlumno.MostrarAlumnosPorCurso(_listaAlumnos, _listaCursos);
        }
    }
}
