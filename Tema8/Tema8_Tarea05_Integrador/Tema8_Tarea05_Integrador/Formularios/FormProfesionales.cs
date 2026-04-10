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
        private ListaProfesionales _listaProfesionales;

        public FormProfesionales(ListaProfesionales listaProfesionales)
        {
            InitializeComponent();
            this._listaProfesionales = listaProfesionales;
        }

        private void FormProfesionales_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            switch (cmbAddProfesional.Text)
            {
                case "Diseñador":
                    FormDesigner formDesigner = new(_listaProfesionales);

                    formDesigner.ShowDialog();
                    break;
                case "Desarrollador":
                    FormDesarrollador formDesarrollador = new(_listaProfesionales);

                    formDesarrollador.ShowDialog();
                    break;
                case "Redactor":
                    FormRedactor formRedactor = new(_listaProfesionales);

                    formRedactor.ShowDialog();
                    break;
            }
        }
    }
}
