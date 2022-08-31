using System;
using System.Collections;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents;
            ArrayList registro = new ArrayList();
            string nombre;
            int edad;
            int contador = 0;

            Console.WriteLine("Ingrese el numero de estudiantes: ");
            numberStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (contador < numberStudents)
            {
                Console.Write("Ingrese el nombre del estudiante");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la edad del estudiante");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Students students = new Students() { Nombre = nombre, Edad = edad };
                registro.Add(students);

                contador++;
            }
            Console.WriteLine(" --- RESULTADOS --- ");
            foreach (Students st in registro)
            {
                Console.WriteLine(st.getData());
            }

        }
    }

    public class Students
    {

        private string _nombre;
        private int _edad;

        public string Nombre
        {

            get => _nombre;
            set => _nombre = value;

        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public string getData()
        {
            return "Nombre: " + _nombre + " Edad: " + _edad;
        }

    }

}
