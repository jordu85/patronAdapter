using System;
using codigoConApadater;

namespace AdapterApp
{
    // Clase Adaptee: Sensor existente que NO podemos modificar
    // Solo puede devolver temperaturas en Celsius
    public class SensorCelsius : ISensorTemperatura
    {
        private readonly double temperatura;

        public SensorCelsius(string ubicacion)
        {
            // Temperatura fija para simplificar la demostración
            temperatura = 25.0;
        }

        // Método existente incompatible con lo que el cliente necesita
        public double ObtenerTemperaturaCelsius()
        {
            return temperatura;
        }

        // Implementación de la interfaz común
        public double LeerTemperatura()
        {
            return ObtenerTemperaturaCelsius();
        }
    }
}