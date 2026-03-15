using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public static class DatosEjemploCentroEscolar
    {
        // Datos de ejemplo.
        public static void DatosEjemploAlumnos(ListaAlumnos listaAlumnos)
        {
            listaAlumnos.AddAlumno(new("Manu", 43, "82280208M", 119));
                listaAlumnos.AddNotaAlumno("Manu", "82280208M", 8.5);
                listaAlumnos.AddNotaAlumno("Manu", "82280208M", 10);
                listaAlumnos.AddNotaAlumno("Manu", "82280208M", 9.5);

            listaAlumnos.AddAlumno(new("Lito", 34, "45651387H", 119));
                listaAlumnos.AddNotaAlumno("Lito", "45651387H", 6);
                listaAlumnos.AddNotaAlumno("Lito", "45651387H", 7.5);
                listaAlumnos.AddNotaAlumno("Lito", "45651387H", 9.5);

            listaAlumnos.AddAlumno(new("Marina", 28, "98563240J", 119));
                listaAlumnos.AddNotaAlumno("Marina", "98563240J", 7);
                listaAlumnos.AddNotaAlumno("Marina", "98563240J", 5.5);
                listaAlumnos.AddNotaAlumno("Marina", "98563240J", 4.5);

            listaAlumnos.AddAlumno(new("Lidia", 38, "48974231I", 129));
                listaAlumnos.AddNotaAlumno("Lidia", "48974231I", 2.5);
                listaAlumnos.AddNotaAlumno("Lidia", "48974231I", 1);
                listaAlumnos.AddNotaAlumno("Lidia", "48974231I", 9.5);

            listaAlumnos.AddAlumno(new("Carlos", 51, "21321836P", 108));
                listaAlumnos.AddNotaAlumno("Carlos", "21321836P", 6);
                listaAlumnos.AddNotaAlumno("Carlos", "21321836P", 3.5);
                listaAlumnos.AddNotaAlumno("Carlos", "21321836P", 8.5);

            listaAlumnos.AddAlumno(new("Kathy", 25, "88475621S", 108));
                listaAlumnos.AddNotaAlumno("Kathy", "88475621S", 7);
                listaAlumnos.AddNotaAlumno("Kathy", "88475621S", 4);
                listaAlumnos.AddNotaAlumno("Kathy", "88475621S", 10);

            listaAlumnos.AddAlumno(new("Lina", 45, "87451321M", 139));
                listaAlumnos.AddNotaAlumno("Lina", "87451321M", 7.5);
                listaAlumnos.AddNotaAlumno("Lina", "87451321M", 3.5);
                listaAlumnos.AddNotaAlumno("Lina", "87451321M", 9);

            listaAlumnos.AddAlumno(new("Pedro", 20, "00215463L", 139));
                listaAlumnos.AddNotaAlumno("Pedro", "00215463L", 5.5);
                listaAlumnos.AddNotaAlumno("Pedro", "00215463L", 8);
                listaAlumnos.AddNotaAlumno("Pedro", "00215463L", 4.5);

            listaAlumnos.AddAlumno(new("David", 48, "05489135Z", 108));
                listaAlumnos.AddNotaAlumno("David", "05489135Z", 10);
                listaAlumnos.AddNotaAlumno("David", "05489135Z", 7);
                listaAlumnos.AddNotaAlumno("David", "05489135Z", 6);

            listaAlumnos.AddAlumno(new("Nika", 18, "54562188F", 119));
                listaAlumnos.AddNotaAlumno("Nika", "54562188F", 8.5);
                listaAlumnos.AddNotaAlumno("Nika", "54562188F", 6.5);
                listaAlumnos.AddNotaAlumno("Nika", "54562188F", 9);

            listaAlumnos.AddAlumno(new("Juan Manuel", 22, "41218435Y", 118));
                listaAlumnos.AddNotaAlumno("Juan Manuel", "41218435Y", 2.5);
                listaAlumnos.AddNotaAlumno("Juan Manuel", "41218435Y", 4);
                listaAlumnos.AddNotaAlumno("Juan Manuel", "41218435Y", 1.5);

            listaAlumnos.AddAlumno(new("Juanjo", 56, "31518898C", 118));
                listaAlumnos.AddNotaAlumno("Juanjo", "31518898C", 4);
                listaAlumnos.AddNotaAlumno("Juanjo", "31518898C", 7);
                listaAlumnos.AddNotaAlumno("Juanjo", "31518898C", 3);

            listaAlumnos.AddAlumno(new("Marta", 27, "44582339V", 119));
                listaAlumnos.AddNotaAlumno("Marta", "44582339V", 6.5);
                listaAlumnos.AddNotaAlumno("Marta", "44582339V", 10);
                listaAlumnos.AddNotaAlumno("Marta", "44582339V", 4.5);

            listaAlumnos.AddAlumno(new("Luna Camila", 33, "22217875B", 139));
                listaAlumnos.AddNotaAlumno("Luna Camila", "22217875B", 6);
                listaAlumnos.AddNotaAlumno("Luna Camila", "22217875B", 10);
                listaAlumnos.AddNotaAlumno("Luna Camila", "22217875B", 5);

            listaAlumnos.AddAlumno(new("Victoria", 40, "08723614A", 138));
                listaAlumnos.AddNotaAlumno("Victoria", "08723614A", 10);
                listaAlumnos.AddNotaAlumno("Victoria", "08723614A", 8.5);
                listaAlumnos.AddNotaAlumno("Victoria", "08723614A", 7.5);
        }

        public static void DatosEjemploProfesores(ListaProfesores listaProfesores)
        {
            listaProfesores.AddProfesor(new("David", "22446688D", 118));
            listaProfesores.AddAsignaturaProfesor("22446688D", "Programación");
            listaProfesores.AddAsignaturaProfesor("22446688D", "Desarrollo de interfaces");

            listaProfesores.AddProfesor(new("Juan Carlos", "11335599J", 109));
            listaProfesores.AddAsignaturaProfesor("11335599J", "Sistemas operativos en red");
            listaProfesores.AddAsignaturaProfesor("11335599J", "Fundamentos del hardware");

            listaProfesores.AddProfesor(new("Lola", "12457830L", -1));
            listaProfesores.AddAsignaturaProfesor("12457830L", "Sostenibilidad");
            listaProfesores.AddAsignaturaProfesor("12457830L", "Introducción a la nube");
            listaProfesores.AddAsignaturaProfesor("12457830L", "Proyecto intermodular II");

            listaProfesores.AddProfesor(new("Jesus", "96307410S", -1));
            listaProfesores.AddAsignaturaProfesor("96307410S", "Redes locales");
            listaProfesores.AddAsignaturaProfesor("96307410S", "Servicios en red");
            listaProfesores.AddAsignaturaProfesor("96307410S", "Programación de servicios y procesos");

            listaProfesores.AddProfesor(new("Gerardo", "14253698G", 139));
            listaProfesores.AddAsignaturaProfesor("14253698G", "Digitalización");
            listaProfesores.AddAsignaturaProfesor("14253698G", "Bases de datos");

            listaProfesores.AddProfesor(new("Catalina", "14702580C", 108));
            listaProfesores.AddAsignaturaProfesor("14702580C", "Aplicaciones ofimáticas");
            listaProfesores.AddAsignaturaProfesor("14702580C", "Sistemas operativos monopuesto");

            listaProfesores.AddProfesor(new("Alberto", "96857412A", -1));
            listaProfesores.AddAsignaturaProfesor("96857412A", "Diseño de interfaces web");

            listaProfesores.AddProfesor(new("Rosa", "00881234R", 128));
            listaProfesores.AddAsignaturaProfesor("00881234R", "Itinerario para la empleabilidad I");
            listaProfesores.AddAsignaturaProfesor("00881234R", "Itinerario para la empleabilidad II");
            listaProfesores.AddAsignaturaProfesor("00881234R", "Despliegue de aplicaciones web");
        }

        public static void DatosEjemploCursos(ListaCursos listaCursos)
        {
            listaCursos.AddCurso(new("1º- SMR O", 108));
            listaCursos.AddCurso(new("2º- SMR N", 109));
            listaCursos.AddCurso(new("1º- DAW Y", 118));
            listaCursos.AddCurso(new("2º- DAW V", 119));
            listaCursos.AddCurso(new("1º- DAM F", 128));
            listaCursos.AddCurso(new("2º- DAM P", 129));
            listaCursos.AddCurso(new("1º- ASIR L", 138));
            listaCursos.AddCurso(new("2º- ASIR I", 139));
        }
    }
}
