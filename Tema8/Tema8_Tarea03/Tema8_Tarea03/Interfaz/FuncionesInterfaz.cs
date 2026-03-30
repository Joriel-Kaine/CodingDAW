using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea03.Interfaz
{
    public static class FuncionesInterfaz
    {
        public static bool ValidarEntero(string mensaje, out int num)
        {
            bool esCorrecto = int.TryParse(mensaje, out num);
            
            if (!esCorrecto)
            {
                MessageBox.Show("Introduce valores numéricos válidos");
            }

            return esCorrecto;
        }

        public static bool ValidarTexto(string mensaje, out string texto)
        {
            bool esCorrecto = true;
            texto = mensaje;
            
            if (string.IsNullOrEmpty(mensaje))   
            {    
                MessageBox.Show("No se permiten textos vacíos o nulos.");  
                esCorrecto = false;
            }  
            else if (!mensaje.All(char.IsLetter))
            {     
                MessageBox.Show("Introduce textos válidos.");   
                esCorrecto = false;
            }

            return esCorrecto;
        }
    }
}
