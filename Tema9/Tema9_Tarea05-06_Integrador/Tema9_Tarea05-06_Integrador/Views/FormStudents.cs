using Tema9_Tarea05_06_Integrador.Controllers;

namespace Tema9_Tarea05_06_Integrador
{
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }


        // Métodos auxiliares.
        private static int ReadInteger(string message)
        {
            int num;
            bool isCorrect;

            Console.Write(message);
            isCorrect = int.TryParse(Console.ReadLine(), out num);

            if (!isCorrect)
            {
                throw new FormatException("Introduce valores numéricos válidos.");
            }

            return num;
        }

        private static string ReadString(string message, string displayName)
        {
            Console.Write(message);
            var value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"El {displayName} no puede estar vacío.");
            }

            return value;
        }

        private static int? ReadNullInteger(string message)
        {
            Console.Write(message);
            var value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            if (!int.TryParse(value, out int num))
            {
                throw new FormatException("Introduce valores numéricos válidos.");
            }

            return num;
        }

        private static async Task SafeExecuteAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }

        private static async Task PrintAllStudents(StudentsController controller)
        {
            var students = await controller.GetAsyncAll();

            if (students.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }


        // Load del formulario.
        private void FormStudents_Load(object sender, EventArgs e)
        {

        }


        // Botones.
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnShowStudentById_Click(object sender, EventArgs e)
        {

        }

        private void btnShowStudentByDni_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteStudentById_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteStudentByDni_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnIconAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnIconDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnIconShow_Click(object sender, EventArgs e)
        {

        }

        private void btnIconModify_Click(object sender, EventArgs e)
        {

        }

        private void btnIconStart_Click(object sender, EventArgs e)
        {

        }

        private void btnIconPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnIconNext_Click(object sender, EventArgs e)
        {

        }

        private void btnIconEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
