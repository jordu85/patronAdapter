using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoSinAdapter
{
    internal class ListaTemperaturas
    {
        public string unidad;
        public List<Temperatura> temperaturas;

        public ListaTemperaturas(List<Temperatura> lista, string unidad)
        {
            this.unidad = unidad;
            this.temperaturas = new List<Temperatura>();

            foreach (Temperatura temperatura in lista)
            {
                if (temperatura.Unidad == this.unidad)
                {
                    this.temperaturas.Add(temperatura);
                }
            }

        }
        public void MostrarTemperaturas()
        {
            foreach (Temperatura temperatura in this.temperaturas)
            {
                Console.WriteLine($"{temperatura.Valor}, {temperatura.Unidad}");
            }
        }

    }

}