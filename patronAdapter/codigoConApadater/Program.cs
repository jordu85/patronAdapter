using System;

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

            // Crear adaptadores
            AdaptadorFahrenheit adaptadorF = new AdaptadorFahrenheit(sensorOriginal);
            AdaptadorKelvin adaptadorK = new AdaptadorKelvin(sensorOriginal);

            // Usar adaptadores
            double tempFahrenheit = adaptadorF.LeerTemperaturaFahrenheit();
            double tempKelvin = adaptadorK.LeerTemperaturaKelvin();

            // Mostrar resultados
            Console.WriteLine("\n=== RESULTADOS ===");
            Console.WriteLine($"🌡️ Celsius:    {tempCelsius}°C");
            Console.WriteLine($"🌡️ Fahrenheit: {tempFahrenheit}°F");
            Console.WriteLine($"🌡️ Kelvin:     {tempKelvin}K");

            Console.WriteLine("\n✅ Patrón Adapter implementado exitosamente");
            Console.WriteLine("✅ Mismo sensor, múltiples representaciones");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}