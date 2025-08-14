# **PATRON ADAPTER O ADAPTADOR**
Se lo conoce tambien como wrapper (envoltorio).


## **Proposito**
Es un patrón de diseño estructural que permite que cooperen clases que de otra forma no podrían por tener interfaces incompatibles. 


## **Motivacion**
A veces una clase que ha sido diseñada para reutilizarse, no puede hacerlo porque su interfaz no coincide con la interfaz específica del dominio que requiere la aplicación.  


## **Aplicabilidad**
- ***Cuando quiere usarse una clase existente pero su interfaz no es compatible con el resto del código.***  
*El patrón Adapter permite crear una clase intermedia que sirva como traductora entre el código actual y una clase heredada, una clase de un tercero o cualquier otra clase con una interfaz extraña.*

- ***Cuando quiere reutilizarse varias subclases existentes que carezcan de alguna funcionalidad común que no pueda añadirse a la superclase.*** 
*Se podría extender cada subclase y colocar la funcionalidad que falta, dentro de las nuevas clases hijas. No obstante, de ese modo, se duplicaría el código en todas estas nuevas clases, lo que no seria eficiente. Una solución es agregar la funcionalidad que falta dentro de una clase adaptadora. Después puedes envolver objetos a los que les falten funciones, dentro de la clase adaptadora, obteniendo esas funciones necesarias de un modo dinámico. Para que esto funcione, las clases en cuestión deben tener una interfaz común y el campo de la clase adaptadora debe seguir dicha interfaz.*


## **Implementacion**
**1. Identificar al menos dos clases con interfaces incompatibles:**
- Una clase servicio que no puedes cambiar (a menudo de un tercero, heredada o con muchas dependencias existentes). 
- Una o varias clases cliente que se beneficiarían de contar con una clase de servicio.

**2. Declarar la interfaz que espera el cliente y describir el modo en que las clases cliente se comunican con la clase de servicio.**

**3. Crear la clase adaptadora haciendo que siga la interfaz con el cliente. Dejar todos los métodos vacíos en un primer momento.**

**4. Agregar un campo a la clase adaptadora para almacenar una referencia al objeto de servicio.** La práctica común es inicializar este campo a través del constructor, pero en ocasiones es adecuado pasarlo al adaptador cuando se invocan sus métodos.

**5. Uno por uno, implementar todos los métodos de la interfaz con el cliente en la clase adaptadora.** La clase adaptadora deberá delegar la mayor parte del trabajo real al objeto de servicio, gestionando tan solo la interfaz o la conversión de formato de los datos. 

**6. Las clases cliente deberán utilizar la clase adaptadora a través de la interfaz con el cliente.** Esto permitirá cambiar o extender las clases adaptadoras sin afectar al código cliente.


## **Ventajas**
 - ***Principio de responsabilidad única:*** Separa la lógica de conversión de datos de la lógica de negocio. Esto hace que el código sea más limpio y modular. 

- ***Principio de abierto/cerrado:*** se pueden agregar nuevos adaptadores sin modificar el código existente, siempre que se usen interfaces. Esto mejora la escalabilidad. 

- ***Reutilización de código existente:*** permite integrar clases que ya existen (heredadas o de terceros) sin tener que modificarlas. 

- ***Flexibilidad:*** se pueden adaptar múltiples clases con diferentes interfaces a una interfaz común. 

 ## **Desventajas**
- ***Aumento de complejidad estructural:*** El patrón introduce nuevas clases e interfaces que pueden hacer que el diseño sea más difícil de seguir, especialmente en sistemas grandes o con múltiples adaptadores.  

- ***Dificultad en el mantenimiento.***  

 
