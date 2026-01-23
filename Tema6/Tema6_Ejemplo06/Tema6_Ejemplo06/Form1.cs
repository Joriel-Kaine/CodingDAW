using Microsoft.VisualBasic;

namespace Tema6_Ejemplo06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listaNombres = new();

        private string MostrarNombres(List<string> listaNombres)
        {
            string texto = "Lista de nombres:\n";
            int posicion = 0;

            foreach (string nombre in listaNombres)
            {
                // Mostramos la posición en la lista y el nombre
                texto += $"{posicion} - {nombre}\n";
                posicion++;
            }

            return texto;
        }

        private void btnAñadirNom_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre a añadir:", "Añadir Nombre");

            listaNombres.Add(nombre);

            lblLista.Text = MostrarNombres(listaNombres);
        }

        private void btnMostrarNom_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarNombres(listaNombres));
        }

        private void btnMostrarPos_Click(object sender, EventArgs e)
        {
            // Pedimos al usuario la posición y mostramos el nombre en esa posición.
            int posicion;

            if (int.TryParse(Interaction.InputBox("Introduce la posición:", "Mostrar Posición"), out posicion))
            {
                // Comprobamos que la posición introducida esté dentro de la lista.
                if (posicion >= 0 && posicion < listaNombres.Count)
                {
                    MessageBox.Show($"El nombre en {posicion} es {listaNombres[posicion]}.");
                }
                else
                {
                    MessageBox.Show("No es una posición correcta.");
                }
            }
        }

        private void btnInsertarNom_Click(object sender, EventArgs e)
        {
            string nombre;
            int posicion;

            nombre = Interaction.InputBox("Introduce un nombre: ");
            if (int.TryParse(Interaction.InputBox("Introduce la posición:", "Introducir Posición"), out posicion))
            {
                // La posición donde insertamos sí puede ser Count.
                if (posicion >= 0 && posicion <= listaNombres.Count)
                {
                    listaNombres.Insert(posicion, nombre);
                }
                else
                {
                    MessageBox.Show("No es una posición correcta.");
                }

                lblLista.Text = MostrarNombres(listaNombres);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaNombres.Sort();

            lblLista.Text = MostrarNombres(listaNombres);
        }

        private void btnEliminarNom_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre a eliminar:", "Eliminar Nombre");

            if (listaNombres.Remove(nombre))
            {
                lblLista.Text = MostrarNombres(listaNombres);
            }
            else
            {
                MessageBox.Show($"{nombre} no se encuentra en la lista.");
            }
        }

        private void btnEliminarPos_Click(object sender, EventArgs e)
        {
            int posicion;

            if (int.TryParse(Interaction.InputBox("Introduce la posición a eliminar:",
                                                  "Eliminar Posición"), out posicion))
            {
                listaNombres.RemoveAt(posicion);

                lblLista.Text = MostrarNombres(listaNombres);
            }
            else
            {
                MessageBox.Show("La posición está fuera de los elementos de la lista");
            }
        }

        private void btnEncontrarNom_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre a buscar en la lista:", "Encontrar Nombre");

            int posicion = listaNombres.IndexOf(nombre);

            if (posicion >= 0)
            {
                MessageBox.Show($"El nombre {nombre} está en la posición {posicion}");
            }
            else
            {
                MessageBox.Show($"El nombre {nombre} no se encuentra en la lista ({posicion})");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaNombres.Clear();

            lblLista.Text = MostrarNombres(listaNombres);
        }
    }
}
