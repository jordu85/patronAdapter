using System;
using codigoConApadater;

namespace AdapterApp
{
    // Adaptador para convertir Celsius a Kelvin
    public class AdaptadorKelvin : ISensorKelvin, ISensorTemperatura
    {
        private readonly SensorCelsius sensorCelsius;

        public AdaptadorKelvin(SensorCelsius sensor)
        {
            this.sensorCelsius = sensor ?? throw new ArgumentNullException(nameof(sensor));
        }

        // Convierte la temperatura de Celsius a Kelvin
        // Fórmula: K = °C + 273.15
        public double LeerTemperaturaKelvin()
        {
            double temperaturaCelsius = sensorCelsius.ObtenerTemperaturaCelsius();
            return ConvertirCelsiusAKelvin(temperaturaCelsius);
        }

        // Implementación de la interfaz común
        public double LeerTemperatura()
        {
            return LeerTemperaturaKelvin();
        }

        private double ConvertirCelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}