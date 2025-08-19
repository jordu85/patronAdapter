using System;

namespace AdapterApp
{
    // PASO 2: Interfaz Target (Objetivo)
    // Define la interfaz que el cliente espera usar.
    // En nuestro caso, el cliente necesita ver las temperaturas en Fahrenheit.
    public interface ISensorFahrenheit
    {
        // Método que el cliente espera para obtener temperatura en Fahrenheit
        double LeerTemperaturaFahrenheit();
    }
}
