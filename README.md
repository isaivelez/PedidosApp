# PedidosApp

PedidosApp es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Su propósito es gestionar pedidos y calcular los costos de entrega según distintos métodos de envío. El diseño del sistema incorpora varios patrones de diseño para promover una arquitectura modular y escalable.

![image](https://github.com/user-attachments/assets/735b1cf3-045a-472e-8e39-b6f4da25c813)

## 🧩 Patrones de Diseño Implementados

- **Singleton**: Se utiliza para garantizar que ciertas clases tengan una única instancia global, facilitando el acceso compartido a recursos comunes.

- **Factory**: Implementado para encapsular la lógica de creación de objetos, permitiendo la instanciación de diferentes tipos de entregas sin acoplar el código cliente a clases concretas.

- **Strategy**: Aplicado para definir una familia de algoritmos de cálculo de costos de entrega, encapsulando cada uno y haciéndolos intercambiables según el tipo de entrega seleccionado.

---

## ❓ Preguntas de Comprensión

1. **¿Qué ventaja ofrece usar una interfaz en lugar de una clase concreta?**

   El uso de interfaces permite definir contratos que pueden ser implementados por múltiples clases, promoviendo la flexibilidad y facilitando la implementación de diferentes comportamientos sin modificar el código cliente. Esto es esencial para aplicar el principio de inversión de dependencias y para facilitar la prueba y mantenimiento del código.


2. **¿Por qué separamos la lógica de selección de entrega del objeto Pedido?**

   Separar la lógica de selección de entrega del objeto Pedido permite adherirse al principio de responsabilidad única, asegurando que cada clase tenga una única razón para cambiar. Esto mejora la mantenibilidad y escalabilidad del sistema, ya que nuevos métodos de entrega pueden ser añadidos sin modificar la clase Pedido.


3. **¿Cuál de los principios SOLID consideras más importante en este ejercicio? ¿Por qué?**

   El principio de abierto/cerrado (Open/Closed Principle) es fundamental en este contexto, ya que permite que el sistema sea abierto a la extensión pero cerrado a la modificación. Esto significa que podemos añadir nuevos tipos de entrega o comportamientos sin alterar el código existente, reduciendo el riesgo de introducir errores.


4. **Si se quiere añadir una entrega por "bicicleta" para pedidos ecológicos, ¿qué clases cambiarías?**

   Para añadir una nueva entrega por bicicleta, se debería:

   - Crear una nueva clase `EntregaBicicleta` que implemente la interfaz `IMetodoEntrega`, definiendo el comportamiento específico para la entrega en bicicleta.
   - Actualizar la clase `PedidoFactory` correspondiente para incluir la lógica de creación de la nueva clase de entrega cuando se seleccione la opción de bicicleta.

   No sería necesario modificar la clase Pedido ni otras clases existentes, gracias a la aplicación de los patrones de diseño mencionados.


5. **¿Cómo favorece el uso de estos patrones el mantenimiento del sistema?**

   El uso de patrones como Singleton, Factory y Strategy promueve una arquitectura desacoplada y modular. Esto facilita la adición de nuevas funcionalidades, la realización de pruebas unitarias y la localización y corrección de errores, mejorando la mantenibilidad y escalabilidad del sistema.


6. **¿En qué casos reales usarías el patrón Singleton?**

   El patrón Singleton es útil cuando se necesita asegurar que una clase tenga una única instancia en todo el sistema, como en el caso de gestores de configuración, conexiones a bases de datos, o registros de logs. Sin embargo, debe usarse con precaución para evitar problemas relacionados con el estado compartido y dificultades en las pruebas.

---
