﻿using System;

namespace Curso2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Modelar una solución para poder representar a Empleados y Estudiantes.
            // Todos ellos son Personas. Cada persona tiene nombre y apellido y un ID.
            // Los Empleados tienen una ocupación y trabajan.
            // Los estudiantes, tienen una carrera de estudios y por supuesto, estudian.
            // Luego existen los estudiantes que también trabajan y deben ser representados por este modelo.
            // También existe el concepto de Curso. Un curso tiene una lista de estudiantes y, para crearse, 
            //debe recibir la nómina de estudiantes.

            // Hacer un programa que cree un estudiante, un empleado, estudiante que trabaja y un curso que 
            //contenga a los estudiantes.

            // Modelar este escenario según una jerarquía de clases
            
            SolucionEjercicio1 ejercicio1 = new SolucionEjercicio1();
            ejercicio1.Ejecutar();  
            Console.ReadLine();          
            
            //  OOP_Interfaces.Program   en el repositorio está

            //Console.WriteLine("Hello World!");
        }
    }
}
