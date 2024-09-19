using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSemana3SistemaDeNotas
{
    class Alumno
    {
        string Nombre;
        string Apellido;
        string NumIdentificacion;
        string Carrera;
        List<double> Notas;

        public Alumno()
        {
            Notas = new List<double>();
        }

        public Alumno(string nombre, string apellido, string numIdentificacion, string carrera, List<double> notas)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumIdentificacion = numIdentificacion;
            Carrera = carrera;
            Notas = notas;
        }
        public Alumno(string nombre, string apellido, string numIdentificacion, string carrera, params double[] notas)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumIdentificacion = numIdentificacion;
            Carrera = carrera;
            Notas = new List<double>(notas);
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            Apellido = apellido;
        }
        public void setNumIdentificacion(string numIdentificacion)
        {
            NumIdentificacion = numIdentificacion;
        }
        public void setCarrera(string carrera)
        {
            Carrera = carrera;
        }
        public void AgregarNota(double nota)
        {
            Notas.Add(nota);
        }
        public Double ObtenerPromedio()
        {
            return Math.Round(Notas.Average(), 2);
        }

        public void InfoAlumno()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido} => Promedio: {ObtenerPromedio()}");
        }
    }
}