namespace GestorAlumnos.Models
{
    public class Alumno
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Promedio { get; set; }

        public Alumno(int codigo, string nombre, string apellido, string sexo, int promedio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Promedio = promedio;
        }
    }
}
