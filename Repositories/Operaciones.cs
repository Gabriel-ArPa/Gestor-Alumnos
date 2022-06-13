using GestorAlumnos.Models;
using System;
using System.Collections;
using System.IO;

namespace GestorAlumnos.Repositories
{
    class Operaciones
    {
        TextWriter tw;
        ArrayList arralumnos;
        public void escribirArchivo(Alumno a)
        {
            try
            {
                tw = new StreamWriter("alumnos.txt", true);
                tw.Write(a.Codigo + "," + a.Nombre + "," + a.Apellido + "," + a.Sexo + "," + a.Promedio + "\n");
                tw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void escribirArchivo(ArrayList alumnos)
        {
            try
            {
                tw = new StreamWriter("alumnos.txt", true);
                foreach (Alumno a in alumnos)
                {
                    tw.Write(a.Codigo + "," + a.Nombre + "," + a.Apellido + "," + a.Sexo + "," + a.Promedio + "\n");
                }
                tw.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public ArrayList leerArchivo(string grupo = "todos", string sexo = "todos")
        {
            arralumnos = new ArrayList();
            Alumno al;

            try
            {
                TextReader tr = new StreamReader("alumnos.txt");
                string[] datos;
                string cadena = tr.ReadLine();

                while (cadena != null && cadena != "")
                {
                    datos = cadena.Split(',');
                    al = new Alumno(int.Parse(datos[0]), datos[1], datos[2], datos[3], int.Parse(datos[4]));

                    if (sexo == al.Sexo)
                    {
                        switch (grupo)
                        {
                            case "todos":
                                arralumnos.Add(al);
                                break;
                            case "aprobados":
                                if (al.Promedio >= 11) arralumnos.Add(al);
                                break;
                            case "desaprobados":
                                if (al.Promedio < 11) arralumnos.Add(al);
                                break;
                            default:
                                break;
                        }
                    }
                    else if (sexo == "todos")
                    {
                        switch (grupo)
                        {
                            case "todos":
                                arralumnos.Add(al);
                                break;
                            case "aprobados":
                                if (al.Promedio >= 11) arralumnos.Add(al);
                                break;
                            case "desaprobados":
                                if (al.Promedio < 11) arralumnos.Add(al);
                                break;
                            default:
                                break;
                        }
                    }

                    cadena = tr.ReadLine();
                }

                tr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return arralumnos;
        }

        public Alumno buscar(int codigo)
        {
            foreach (Alumno x in leerArchivo())
            {
                if (x.Codigo == codigo)
                {
                    return x;
                }
            }
            return null;
        }

        public void eliminar(Alumno a)
        {
            arralumnos.Remove(a);
            TextWriter tw = new StreamWriter("alumnos.txt", false);
            tw.Write(string.Empty);
            tw.Close();
            escribirArchivo(arralumnos);
        }

        public ArrayList obtenerarrcliente()
        {
            return arralumnos;
        }


    }
}
