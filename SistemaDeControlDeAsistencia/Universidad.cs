using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeControlDeAsistencia
{
    public class Universidad
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int TotalSesiones { get; set; }
            public int SesionesAsistidas { get; set; }

            public Estudiante(string nombre, int totalSesiones, int sesionesAsistidas)
            {
                Nombre = nombre;
                TotalSesiones = totalSesiones;
                SesionesAsistidas = sesionesAsistidas;
            }
        }

        public static void MostrarInformacionEstudiante(Estudiante estudiante)
        {
            double porcentaje = Asistencia.CalcularPorcentaje(estudiante.SesionesAsistidas, estudiante.TotalSesiones);
            bool cumple = Asistencia.CumpleAsistencia(porcentaje);

            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Porcentaje de Asistencia: {porcentaje}%");
            Console.WriteLine(cumple ? "Cumple con el mínimo de asistencia." : "No cumple con el mínimo de asistencia.");
            Console.WriteLine();
        }

        public static class Asistencia
        {
            public static double CalcularPorcentaje(int sesionesAsistidas, int totalSesiones)
            {
                return totalSesiones > 0 ? ((double)sesionesAsistidas / totalSesiones) * 100 : 0;
            }

            public static bool CumpleAsistencia(double porcentaje)
            {
                return porcentaje >= 75;
            }
        }
    }
}
