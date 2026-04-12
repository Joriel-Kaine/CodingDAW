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
            switch (cmbProfesional.Text)
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

        private void btnMostrarProfesional_Click(object sender, EventArgs e)
        {
            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();

            switch (cmbProfesional.Text)
            {
                case "Diseñador":
                    lstProfesionales.Items.Clear();

                    foreach (Profesional profesional in listaProfesionales)
                    {
                        if (profesional is Designer designer)
                        {
                            lstProfesionales.Items.Add(profesional);
                        }
                    }
                    break;
                case "Desarrollador":
                    lstProfesionales.Items.Clear();

                    foreach (Profesional profesional in listaProfesionales)
                    {
                        if (profesional is Desarrollador desarrollador)
                        {
                            lstProfesionales.Items.Add(profesional);
                        }
                    }
                    break;
                case "Redactor":
                    lstProfesionales.Items.Clear();

                    foreach (Profesional profesional in listaProfesionales)
                    {
                        if (profesional is Redactor redactor)
                        {
                            lstProfesionales.Items.Add(profesional);
                        }
                    }
                    break;
            }
        }

        private void btnEliminarPorDNI_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            lstProfesionales.Items.Clear();
            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();

            foreach (Profesional profesional in listaProfesionales)
            {
                lstProfesionales.Items.Add(profesional);
            }
        }
    }
}
