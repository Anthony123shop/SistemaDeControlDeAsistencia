using SistemaDeControlDeAsistencia;

public class Program
{
    static void Main(string[] args)
    {
        Universidad.Estudiante estudiante = new Universidad.Estudiante("Monky Donky", 20, 15);

        Universidad.MostrarInformacionEstudiante(estudiante);

        Universidad.Estudiante otroEstudiante = new Universidad.Estudiante("Sanky stanky", 20, 18);
        Universidad.MostrarInformacionEstudiante(otroEstudiante);
    }
}