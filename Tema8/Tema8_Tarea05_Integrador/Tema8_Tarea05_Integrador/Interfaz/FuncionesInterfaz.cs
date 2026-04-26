using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Interfaz
{
    public static class FuncionesInterfaz
    {
        private const string ErrorLongitudTelefono = "El número no tiene la longitud correcta.";

        // Método que valida el nombre. En todos los métodos de validación usamos de salida un booleano.
        public static bool ValidarNombre(string nombreEntrada, out string nombreSalida)
        {
            bool esCorrecto = true;
            nombreEntrada = nombreEntrada.Trim(); // Quitamos los espacios en blanco tanto al principio como al final.
            nombreSalida = nombreEntrada;

            // Comprobamos si es null o está vacío.
            if (string.IsNullOrEmpty(nombreEntrada))
            {
                MessageBox.Show("El nombre no debe estar vacío o ser nulo.");
                esCorrecto = false;
            }
            // Aquí comprobamos que el nombre contenga letras o espacios en blanco.
            // Usamos (All) para recorrer el string de caracteres.
            // Usamos función lambda anónima para asegurarnos que todos son letras o espacios.
            else if (!nombreEntrada.All(caracter => char.IsLetter(caracter) || caracter == ' '))
            {
                MessageBox.Show("Introduce un nombre válido.");
                esCorrecto = false;
            }

            return esCorrecto;
        }

        // Método para validar correctamente el DNI.
        public static bool ValidarDNI(string dniEntrada, out string dniSalida)
        {
            bool esCorrecto = true;

            dniEntrada = dniEntrada.Trim().ToUpper(); // Quitamos los espacios en blanco y pasamos la letra a mayusculas.
            dniSalida = dniEntrada;

            // Regex para 8 números + 1 letra.
            // Declaramos una variable donde se almacena el patrón para el DNI.
            // Lo que queremos en el patrón empieza con ^ y termina con $.
            // Dentro ponemos las reglas que queremos para la validación del DNI.
            string patron = @"^[0-9]{8}[A-Z]$"; // 8 números y una letra al final.
            
            // Comprobamos si coinciden o no los datos de entrada con el patrón que hemos impuesto.
            if (!Regex.IsMatch(dniEntrada, patron)) 
            { 
                MessageBox.Show("Introduce un número de identidad válido.");
                esCorrecto = false;
            }

            return esCorrecto;
        }

        // Método para validar correctamente el Email.
        public static bool ValidarEmail(string emailEntrada, out string emailSalida)
        {
            bool esCorrecto = true;

            emailEntrada = emailEntrada.Trim().ToLower();
            emailSalida = emailEntrada;

            // Regex para validar el formato de Email.
            // En la primera parte del patrón queremos tanto letras como números y algunos signos.
            // Después ponemos un + para decir que sea de 1 caracter en adelante.
            // En la segunda parte hacemos algo muy similar.
            // En la última parte tenemos que poner una \ antes del punto para que funcione bien.
            // Y al final nos aseguramos que la extensión del email tenga desde 2 en adelante caracteres.
            string patron = @"^[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,}$";

            if (!Regex.IsMatch(emailEntrada, patron))
            {
                MessageBox.Show("Introduce un correo electrónico válido.");
                esCorrecto = false;
            }

            return esCorrecto;
        }

        // Método para validar el teléfono.
        public static bool ValidarTelefono(string prefijo, string telefonoEntrada, out string telefonoSalida)
        {
            bool esCorrecto = true;
            telefonoEntrada = telefonoEntrada.Trim();
            telefonoSalida = telefonoEntrada;

            // Nos aseguramos que no sea null o esté vacío.
            if (string.IsNullOrEmpty(telefonoEntrada))
            {
                MessageBox.Show("El teléfono no debe estar vacío o ser nulo.");
                esCorrecto = false;
            }
            // Luego que miramos si son todo dígitos o no lo son.
            else if (!telefonoEntrada.All(char.IsDigit))
            {
                MessageBox.Show("Introduce un número de teléfono válido.");
                esCorrecto = false;
            }
            // Si son dígitos pasamos a un switch para comprobar un ComboBox de prefijos.
            else
            {
                // Cada prefijo tiene unas reglas de longitud de números.
                switch (prefijo)
                {
                    case "+34":
                        if (telefonoEntrada.Length != 9)
                        {
                            MessageBox.Show(ErrorLongitudTelefono);
                            esCorrecto = false;
                        }
                        break;
                    case "+33":
                        if (telefonoEntrada.Length != 9)
                        {
                            MessageBox.Show(ErrorLongitudTelefono);
                            esCorrecto = false;
                        }
                        break;
                    case "+39":
                        if (telefonoEntrada.Length < 9 || telefonoEntrada.Length > 10)
                        {
                            MessageBox.Show(ErrorLongitudTelefono);
                            esCorrecto = false;
                        }
                        break;
                    case "+49":
                        if (telefonoEntrada.Length < 7 || telefonoEntrada.Length > 11)
                        {
                            MessageBox.Show(ErrorLongitudTelefono);
                            esCorrecto = false;
                        }
                        break;
                }
            }

            return esCorrecto;
        }

        // Método para validar el código. Reglas de código entre cierto rango de números.
        public static bool ValidarCodigo(string codigoEntrada, out int codigoSalida)
        {
            bool esCorrecto = true;
            codigoEntrada = codigoEntrada.Trim();

            if (!int.TryParse(codigoEntrada, out codigoSalida))
            {
                MessageBox.Show("Introduce un código válido.");
                esCorrecto = false;
            }
            else if (codigoSalida < 1000 || codigoSalida > 9999)
            {
                MessageBox.Show("El código debe estar entre 1000 y 9999");
                esCorrecto = false;
            }
            
            return esCorrecto;
        }

        // Método para validar la duración. También con rango.
        public static bool ValidarDuracion(string duracionEntrada, out int duracionSalida)
        {
            bool esCorrecto = true;
            duracionEntrada = duracionEntrada.Trim();

            if (!int.TryParse(duracionEntrada, out duracionSalida))
            {
                MessageBox.Show("Introduce valores numéricos válidos.");
                esCorrecto = false;
            }
            else if (duracionSalida < 50 || duracionSalida > 500)
            {
                MessageBox.Show("La duración del proyecto debe estar entre 50 y 500 horas.");
                esCorrecto = false;
            }

            return esCorrecto;
        }

        // Método para validar la tarifa por hora. También con rango.
        public static bool ValidarTarifaHora(string tarifaEntrada, out double tarifaSalida)
        {
            bool esCorrecto = true;
            tarifaEntrada = tarifaEntrada.Trim();

            if (!double.TryParse(tarifaEntrada, out tarifaSalida))
            {
                MessageBox.Show("Introduce valores numéricos válidos.");
                esCorrecto = false;
            }
            else if (tarifaSalida < 10 || tarifaSalida > 100)
            {
                MessageBox.Show("La tarifa por hora debe estar entre 10€ y 100€");
                esCorrecto = false;
            }

            return esCorrecto;
        }

        // Método para validar el precio por palabra. También con rango.
        public static bool ValidarPrecioPalabras(string precioPalabraEntrada, out double precioPalabraSalida)
        {
            bool esCorrecto = true;
            precioPalabraEntrada = precioPalabraEntrada.Trim();

            if (!double.TryParse(precioPalabraEntrada, out precioPalabraSalida))
            {
                MessageBox.Show("Introduce valores numéricos válidos.");
                esCorrecto = false;
            }
            else if (precioPalabraSalida < 0.01 || precioPalabraSalida > 0.20)
            {
                MessageBox.Show("La duración del precio por palabra debe estar entre 0.01€ y 0.20€");
                esCorrecto = false;
            }

            return esCorrecto;
        }

        // Método para validar los números enteros.
        public static bool ValidarEntero(string mensaje, out int num)
        {
            bool esCorrecto = true;
            mensaje = mensaje.Trim();

            if (!int.TryParse(mensaje, out num) || num < 0)
            {
                MessageBox.Show("Introduce valores numéricos válidos");
                esCorrecto = false;
            }

            return esCorrecto;
        }
    }
}
