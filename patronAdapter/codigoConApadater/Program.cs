using System;
using codigoConApadater;

namespace AdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMOSTRACIÓN DEL PATRÓN ADAPTER ===");
            Console.WriteLine("Conversor de Temperaturas\n");

            // Crear sensor original (Adaptee)
            SensorCelsius sensorOriginal = new SensorCelsius("Sensor Principal");
            double tempCelsius = sensorOriginal.ObtenerTemperaturaCelsius();
            Console.WriteLine($"Temperatura original: {tempCelsius}°C\n");

            // Crear adaptadores que implementan la interfaz común
            ISensorTemperatura[] sensores = new ISensorTemperatura[]
            {
                sensorOriginal, // Sensor en Celsius
                new AdaptadorFahrenheit(sensorOriginal), // Adaptador a Fahrenheit
                new AdaptadorKelvin(sensorOriginal) // Adaptador a Kelvin
            };

            string[] nombres = { "Celsius", "Fahrenheit", "Kelvin" };

            // Mostrar resultados usando la interfaz común
            Console.WriteLine("\n=== RESULTADOS USANDO INTERFAZ COMÚN ===");
            for (int i = 0; i < sensores.Length; i++)
            {
                Console.WriteLine($"🌡️ {nombres[i]}: {sensores[i].LeerTemperatura()}");
            }

            Console.WriteLine("\n✅ Patrón Adapter implementado exitosamente");
            Console.WriteLine("✅ Mismo sensor, múltiples representaciones usando interfaz común");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}