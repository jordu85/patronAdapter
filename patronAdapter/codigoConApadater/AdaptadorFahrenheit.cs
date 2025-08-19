using System;

namespace AdapterApp
{
    // Clase Adapter que implementa la interfaz ISensorFahrenheit
    // y usa internamente SensorCelsius para las conversiones
    public class AdaptadorFahrenheit : ISensorFahrenheit
    {
        private readonly SensorCelsius sensorCelsius;

        public AdaptadorFahrenheit(SensorCelsius sensor)
        {
            this.sensorCelsius = sensor ?? throw new ArgumentNullException(nameof(sensor));
        }

        // Convierte la temperatura de Celsius a Fahrenheit
        // Fórmula: °F = (°C × 9/5) + 32
        public double LeerTemperaturaFahrenheit()
        {
            double temperaturaCelsius = sensorCelsius.ObtenerTemperaturaCelsius();
            return ConvertirCelsiusAFahrenheit(temperaturaCelsius);
        }

        private double ConvertirCelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32.0;
        }
    }
}
