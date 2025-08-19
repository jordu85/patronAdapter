# 🌡️ Patrón de Diseño Adapter - Conversor de Temperaturas

## 📋 Descripción del Proyecto

Este proyecto demuestra la implementación simplificada del **Patrón de Diseño Adapter** (también conocido como Wrapper) usando un conversor de temperaturas como ejemplo práctico.

### 🎯 Problema Resuelto
- **Clase de Servicio**: `SensorCelsius` - Sensor existente que solo puede leer temperaturas en grados Celsius
- **Cliente**: Necesita trabajar con temperaturas en diferentes unidades (Fahrenheit y Kelvin)
- **Solución**: Implementar adaptadores que traduzcan automáticamente sin modificar el código existente

## 🏗️ Estructura del Proyecto

```
AdapterApp/
├── AdapterApp.csproj         # Archivo de proyecto .NET
├── ISensorFahrenheit.cs      # 🎯 Interfaz Target para Fahrenheit
├── ISensorKelvin.cs          # 🎯 Interfaz Target para Kelvin
├── SensorCelsius.cs          # 🔧 Clase Adaptee (Servicio existente)
├── AdaptadorFahrenheit.cs    # 🔄 Adapter Celsius → Fahrenheit
├── AdaptadorKelvin.cs        # 🔄 Adapter Celsius → Kelvin
├── Program.cs                # 👤 Cliente que demuestra el uso
├── DiagramaClasesSimple.puml # 📊 Diagrama de clases simplificado
├── DiagramaFlujoSimple.puml  # 📊 Diagrama de flujo simplificado
├── DiagramasMermaid.md       # 📊 Diagramas en formato Mermaid
└── README.md                 # Este archivo
```

## 🎭 Participantes del Patrón

| Participante | Rol en el Patrón | Implementación | Descripción |
|--------------|------------------|----------------|-------------|
| **Target (Objetivo)** | Define la interfaz que el cliente espera | `ISensorFahrenheit`<br>`ISensorKelvin` | Interfaces para temperaturas en Fahrenheit y Kelvin |
| **Adaptee (Adaptado)** | Clase existente con interfaz incompatible | `SensorCelsius` | Sensor que devuelve temperatura fija de 25°C |
| **Adapter (Adaptador)** | Traduce la interfaz del Adaptado a la del Objetivo | `AdaptadorFahrenheit`<br>`AdaptadorKelvin` | Convierten Celsius → Fahrenheit y Celsius → Kelvin |
| **Client (Cliente)** | Usa la interfaz esperada | `Program.Main()` | Código que necesita trabajar con diferentes unidades |

## 🔄 Flujo del Patrón

### 🌡️ **Para Fahrenheit:**
1. **Cliente** solicita temperatura en Fahrenheit → `ISensorFahrenheit.LeerTemperaturaFahrenheit()`
2. **AdaptadorFahrenheit** recibe la solicitud → `AdaptadorFahrenheit.LeerTemperaturaFahrenheit()`
3. **Adaptador** llama al sensor original → `SensorCelsius.ObtenerTemperaturaCelsius()`
4. **Adaptador** convierte la temperatura → `(25°C × 9/5) + 32 = 77°F`
5. **Cliente** recibe temperatura en Fahrenheit → Problema resuelto ✅

### 🧪 **Para Kelvin:**
1. **Cliente** solicita temperatura en Kelvin → `ISensorKelvin.LeerTemperaturaKelvin()`
2. **AdaptadorKelvin** recibe la solicitud → `AdaptadorKelvin.LeerTemperaturaKelvin()`
3. **Adaptador** llama al sensor original → `SensorCelsius.ObtenerTemperaturaCelsius()`
4. **Adaptador** convierte la temperatura → `25°C + 273.15 = 298.15K`
5. **Cliente** recibe temperatura en Kelvin → Problema resuelto ✅

### 🔄 **Mismo sensor, múltiples formatos simultáneamente**

## ✅ Ventajas Demostradas

### 🎯 Principio de Responsabilidad Única
- **SensorCelsius**: Solo lee temperaturas en Celsius (25°C fijo)
- **AdaptadorFahrenheit**: Solo convierte Celsius → Fahrenheit  
- **AdaptadorKelvin**: Solo convierte Celsius → Kelvin
- **Program**: Solo coordina la demostración

### 🔓 Principio Abierto/Cerrado
- ✅ **DEMOSTRADO**: Agregamos `AdaptadorKelvin` sin modificar código existente
- ✅ `SensorCelsius` permanece cerrado a modificación
- ✅ `AdaptadorFahrenheit` no fue tocado
- ✅ Podemos agregar más adaptadores (Rankine, Réaumur) sin problemas

### ♻️ Reutilización de Código Existente  
- ✅ `SensorCelsius` usado por **AMBOS adaptadores** sin modificación
- ✅ Aprovechamos toda su funcionalidad existente
- ✅ Un sensor, múltiples representaciones simultáneas

### 🔄 Flexibilidad
- ✅ Múltiples sensores pueden usar cualquier adaptador
- ✅ El cliente elige el formato que necesita (°F, K, °C)
- ✅ Fácil intercambio de implementaciones
- ✅ Mismo patrón para diferentes unidades

### 🎯 Extensibilidad
- ✅ **PROBADA**: Agregamos Kelvin sin tocar código existente
- ✅ Mismo sensor, múltiples formatos simultáneamente
- ✅ Escalabilidad demostrada en la práctica

## 🚀 Cómo Ejecutar

### Opción 1: Con .NET SDK (Recomendado)
```bash
cd AdapterApp
dotnet run
```

### Opción 2: Desde Visual Studio
1. Abrir `AdapterApp.csproj`
2. Presionar `F5` o clic en "Ejecutar"

## 📊 Salida Esperada

```
=== DEMOSTRACIÓN DEL PATRÓN ADAPTER ===
Conversor de Temperaturas

Temperatura original: 25°C

=== RESULTADOS ===
🌡️ Celsius:    25°C
🌡️ Fahrenheit: 77°F
🌡️ Kelvin:     298,15K

✅ Patrón Adapter implementado exitosamente
✅ Mismo sensor, múltiples representaciones
✅ Código existente sin modificar
```
## 📊 Diagramas

### 🏗️ Diagrama de Clases
- **PlantUML**: `DiagramaClasesSimple.puml` - Diagrama simplificado y limpio
- **Mermaid**: `DiagramasMermaid.md` - Compatible con GitHub, GitLab, etc.

### 🔄 Diagrama de Flujo  
- **PlantUML**: `DiagramaFlujoSimple.puml` - Flujo de ejecución paso a paso
- **Mermaid**: `DiagramasMermaid.md` - Versión interactiva

## 🎓 Conceptos Clave Aprendidos

1. **Incompatibilidad de Interfaces**: Cómo resolver cuando tenemos clases útiles pero con interfaces incompatibles
2. **Delegación**: El adaptador delega el trabajo real al objeto adaptado
3. **Conversión Transparente**: El cliente no sabe que está ocurriendo una conversión
4. **Extensibilidad**: Fácil agregar nuevos tipos de conversión sin modificar código existente
5. **Simplificación**: Una temperatura fija permite enfocar la demostración en el patrón

## 💡 Casos de Uso Reales

- 🔌 **APIs de terceros**: Adaptar APIs externas a nuestras interfaces
- 🗃️ **Bases de datos**: Adaptar diferentes proveedores de BD a una interfaz común  
- 📱 **Sistemas legacy**: Integrar sistemas antiguos con nuevas aplicaciones
- 🌐 **Servicios web**: Adaptar diferentes formatos de respuesta (XML, JSON)
- 🌡️ **Conversores de unidades**: Temperatura, peso, distancia, moneda
- 🎮 **Frameworks**: Adaptar librerías externas a nuestro diseño interno

## 🔧 Tecnologías Utilizadas

- **.NET 9.0**
- **C# 12**  
- **Programación Orientada a Objetos**
- **Principios SOLID**
- **Patrones de Diseño GoF**
- **PlantUML** - Para diagramas UML
- **Mermaid** - Para diagramas en Markdown

## 🎯 Características de esta Implementación

- ✅ **Código simplificado**: Una temperatura fija (25°C) para claridad
- ✅ **Salida compacta**: Mensajes concisos y profesionales  
- ✅ **Múltiples adaptadores**: Fahrenheit y Kelvin implementados
- ✅ **Diagramas actualizados**: PlantUML y Mermaid incluidos
- ✅ **Demostración completa**: Patrón Adapter en acción

---

📝 **Proyecto creado para demostrar el Patrón Adapter de forma práctica y comprensible** 🎯
