using System;

namespace AdapterApp
{
    // Nueva interfaz Target para temperaturas en Kelvin
    // Demuestra cómo podemos agregar nuevas interfaces sin modificar código existente
    public interface ISensorKelvin
    {
        // Método que el cliente espera para obtener temperatura en Kelvin
        double LeerTemperaturaKelvin();
    }
}
