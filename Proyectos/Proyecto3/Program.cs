﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSemana3SistemaDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.setNombre("Juan");
            alumno1.setApellido("Perez");
            alumno1.setNumIdentificacion("0001");
            alumno1.AgregarNota(59);
            alumno1.AgregarNota(89.45);
            alumno1.AgregarNota(83.3);
            alumno1.AgregarNota(43);

            Alumno alumno2 = new Alumno("Elmer", "Santos", "0002", "Informatica", new List<double> { 80, 60.4, 70, 65 });

            Alumno alumno3 = new Alumno("Rodrigo", "García", "0003", "Ciencias", 80, 23.45, 32.34, 79);

            List<Alumno> alumnos = new List<Alumno> { alumno1, alumno2, alumno3};

            Console.WriteLine("--------CONTROL ACADÉMICO--------- \n");

            foreach(var datos in alumnos)
            {
                datos.InfoAlumno();
            }

            Console.WriteLine("\nAlumnos con promedio arriba de 60 \n");

            foreach (var datos in alumnos.Where(x => x.ObtenerPromedio() >= 60))
            {
                datos.InfoAlumno();
            }

            double promedioGeneral = Math.Round(alumnos.Average(x => x.ObtenerPromedio()), 2);

            Console.WriteLine($"\nEl promedio general de la clase es de {promedioGeneral}");

            Console.ReadKey();
        }
    }
}