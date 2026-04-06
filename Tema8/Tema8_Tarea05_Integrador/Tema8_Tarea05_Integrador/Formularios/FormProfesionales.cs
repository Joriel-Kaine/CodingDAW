using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea05_Integrador.Profesionales;

namespace Tema8_Tarea05_Integrador
{
    public partial class FormProfesionales : Form
    {
        private List<Profesional> _listaProfesionales;

        public FormProfesionales(List<Profesional> listaProfesionales)
        {
            InitializeComponent();

            this._listaProfesionales = listaProfesionales;
        }

        private void FormProfesionales_Load(object sender, EventArgs e)
        {

        }
    }
}
