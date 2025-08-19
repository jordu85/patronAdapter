using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoSinAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura1 = new Temperatura(30, "celsius");
            Temperatura temperatura2 = new Temperatura(150, "farenheit");
            Temperatura temperatura3 = new Temperatura(20, "celsius");
            Temperatura temperatura4 = new Temperatura(250, "farenheit");

            ///// Se declaran 4 temperaturas con distintas unidades y se agregan a una lista

            List<Temperatura> temperaturas = new List<Temperatura>();
            temperaturas.Add(temperatura1);
            temperaturas.Add(temperatura2);
            temperaturas.Add(temperatura3);
            temperaturas.Add(temperatura4);

            Console.WriteLine("Lista original: \n");
            foreach (Temperatura temperatura in temperaturas)
            {
                Console.WriteLine($"{temperatura.Valor}, {temperatura.Unidad}");
            }

            ListaTemperaturas lista = new ListaTemperaturas(temperaturas, "celsius");
            // Se instancia una lista de temperaturas a partir de la lista anterior

            Console.WriteLine("\n\nLista del objeto instanciado: \n");
            lista.MostrarTemperaturas();

            //Para poder pasarle todas las temperaturas de la lista, primero hay que convertirlas a una misma unidad
            foreach (Temperatura temperatura in temperaturas)
            {
                temperatura.ConvertirCelsius();
            }

            //Instanciamos una nueva lista a partir de la lista modificada
            ListaTemperaturas nuevaLista = new ListaTemperaturas(temperaturas, "celsius");
            Console.WriteLine("\n\nLista de la nueva instancia:\n");
            nuevaLista.MostrarTemperaturas();
            Console.ReadKey();
        }
    }
}