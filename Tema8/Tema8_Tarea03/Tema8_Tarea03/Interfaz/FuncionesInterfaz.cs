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
        public static int ValidarEntero(string texto)
        {
            int num;
            bool esCorrecto = int.TryParse(texto, out num);
            
            if (!esCorrecto)
            {
                MessageBox.Show("Introduce valores numéricos válidos");
            }

            return num;
        }

        public static string ValidarTexto(string texto)
        {
            string correcto = texto;
            
            if (string.IsNullOrEmpty(texto))   
            {    
                MessageBox.Show("No se permiten textos vacíos o nulos.");  
                correcto = null;
            }  
            else if (!texto.All(char.IsLetter))
            {     
                MessageBox.Show("Introduce textos válidos.");   
                correcto = null;
            }

            return texto;
        }
    }
}
