using System;
using codigoConApadater;

namespace AdapterApp
{
    // Clase Adapter que implementa la interfaz ISensorFahrenheit
    // y usa internamente SensorCelsius para las conversiones
    public class AdaptadorFahrenheit : ISensorFahrenheit, ISensorTemperatura
    {
        private readonly SensorCelsius sensorCelsius;

        public AdaptadorFahrenheit(SensorCelsius sensor)
        {
            this.sensorCelsius = sensor ?? throw new ArgumentNullException(nameof(sensor));
        }

            public double LeerTemperaturaFahrenheit()
            {
                double temperaturaCelsius = sensorCelsius.ObtenerTemperaturaCelsius();
                return ConvertirCelsiusAFahrenheit(temperaturaCelsius);
            }

            // Implementación de la interfaz común
            public double LeerTemperatura()
            {
                return LeerTemperaturaFahrenheit();
            }

        private double ConvertirCelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32.0;
        }
    }
}
