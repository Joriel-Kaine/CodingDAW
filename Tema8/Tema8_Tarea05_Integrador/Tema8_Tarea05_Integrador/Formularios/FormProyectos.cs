using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea05_Integrador.Proyectos;

namespace Tema8_Tarea05_Integrador
{
    public partial class FormProyectos : Form
    {
        private ListaProyectos _listaProyectos;

        public FormProyectos(ListaProyectos listaProyectos)
        {
            InitializeComponent();
            this._listaProyectos = listaProyectos;
        }

        // Métodos.
        private void ActualizarComboLists()
        {
            cmbProyectos.Items.Clear();
            cmbProfesionales.Items.Clear();

            
        }


        // Load del formulario.



        // Botones.

    }
}
