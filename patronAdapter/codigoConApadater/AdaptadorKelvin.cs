using System;

namespace AdapterApp
{
    // Adaptador para convertir Celsius a Kelvin
    public class AdaptadorKelvin : ISensorKelvin
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

        private double ConvertirCelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}