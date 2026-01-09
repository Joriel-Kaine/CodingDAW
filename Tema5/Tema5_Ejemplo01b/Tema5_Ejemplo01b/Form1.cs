using Microsoft.VisualBasic;

namespace Tema5_Ejemplo01b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empleado emp = new();

        private void btnIntroDatosEmp_Click(object sender, EventArgs e)
        {
            try
            {
                emp.Nombre = Interaction.InputBox("Introduzca el nombre del empleado.", "Nombre Empleado", "nombre");
                emp.Edad = int.Parse(Interaction.InputBox("Introduzca la edad del empleado.", "Edad Empleado", "edad"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha saltado la siguiente excepción: {ex.Message}");
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(emp.MostrarDatos());
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            emp.Birthday();
        }

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            double venta;

            venta = double.Parse(Interaction.InputBox("Introduzca la venta: ", "Ventas", "venta"));

            emp.AddVenta(venta);
        }
    }
}
