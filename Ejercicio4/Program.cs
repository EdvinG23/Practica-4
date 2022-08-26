using System;
using System.Collections;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable lista = new Hashtable();
            Console.WriteLine("Cantidad: {0}", lista.Count);

            for (int i = 0; i < 10; i++)
            {
                lista.Add(i, "Dato " + i);
            }
            foreach (int key in lista.Keys)
            {
                Console.WriteLine("Clave: {0} = Valor: {1}", key, lista[key]);
            }

        }
    }
}
