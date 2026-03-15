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
    public partial class FormProfesores : Form
    {
        private ListaProfesores _listaProfesores;

        public FormProfesores(ListaProfesores listaProfesores)
        {
            InitializeComponent();
            this._listaProfesores = listaProfesores;
        }



        // Profesores.
        private void btnLeerProfesor_Click(object sender, EventArgs e)
        {
            Profesor? profesor = FuncionesInterfazProfesor.AddProfesor(_listaProfesores);
            int posicion = _listaProfesores.CountProfesores();

            if (profesor != null)
            {
                lblListaNombresProfesores.Text += $"\n{posicion} - {profesor.Nombre}";
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.MostrarTodo(_listaProfesores);
        }

        private void btnMostrarProfesor_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.MostrarDatosProfesor(_listaProfesores);
        }

        private void btnOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.OrdenarPorOrdenAlfabetico(_listaProfesores);
            lblListaNombresProfesores.Text = _listaProfesores.GenerarTextoListaNombres();
        }

        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.EliminarPorPosicion(_listaProfesores);
            lblListaNombresProfesores.Text = _listaProfesores.GenerarTextoListaNombres();
        }

        private void btnEliminarNombre_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.EliminarPorNombre(_listaProfesores);
            lblListaNombresProfesores.Text = _listaProfesores.GenerarTextoListaNombres();
        }



        // Asignaturas.
        private void btnAddAsignatura_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.AddAsignatura(_listaProfesores);
        }

        private void btnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.EliminarAsignaturasProfesor(_listaProfesores);
        }

        private void btnMostrarProfesorConAsignaturas_Click(object sender, EventArgs e)
        {
            FuncionesInterfazProfesor.MostrarProfesoresConAsignaturas(_listaProfesores);
        }



        // Load.
        private void FormProfesores_Load(object sender, EventArgs e)
        {
            lblListaNombresProfesores.Text = _listaProfesores.GenerarTextoListaNombres();
        }
    }
}
