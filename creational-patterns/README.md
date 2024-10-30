# Creational Design Patterns

Creational design patterns are focused on handling object creation mechanisms. They aim to make a system independent of how its objects are created, composed, and represented, thereby enhancing flexibility and reuse. These patterns help to encapsulate the instantiation process and provide ways to control the complexity associated with object creation.

## Overview of Creational Patterns

Each creational design pattern tackles object creation with a unique approach, making it easier to handle complex instantiation processes or change an object’s instantiation strategy without modifying existing code.

| Pattern                | Description                                                                                                   |
|------------------------|---------------------------------------------------------------------------------------------------------------|
| [Abstract Factory](./abstract-factory) | Creates families of related objects without specifying their concrete classes.                    |
| [Builder](./builder)                   | Separates the construction of a complex object from its representation, allowing the same process to create different representations. |
| [Factory Method](./factory-method)     | Defines an interface for creating an object but lets subclasses alter the type of object that will be created. |
| [Prototype](./prototype)               | Allows copying of existing objects without depending on their classes, making it possible to avoid costly creation steps. |
| [Singleton](./singleton)               | Ensures a class has only one instance and provides a global point of access to it.               |

## When to Use Creational Patterns

Use creational patterns when:

- You want to create objects without explicitly specifying the exact class.
- The instantiation of objects should be managed or controlled.
- You wish to hide the instantiation logic and avoid tight coupling.
- You need flexibility for various instantiation options.

## Benefits

- **Encapsulation**: Hide the instantiation logic of complex objects.
- **Reusability**: Improve code reuse by providing standardized object creation processes.
- **Decoupling**: Decouple the client code from the specific classes of the objects it needs to create.

## Drawbacks

- May introduce complexity by adding additional classes and factory methods.
- In some cases, they may limit subclassing if used inappropriately, such as in strict Singleton implementations.

## References

- *Design Patterns: Elements of Reusable Object-Oriented Software* by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides.

## Contributing

We welcome contributions! If you have examples in c# programming language or improvements to existing ones, please fork the repository and create a pull request. Ensure to follow the contribution guidelines and maintain the folder structure.

## License

This project is licensed under the MIT License - see the [LICENSE](../../LICENSE) file for details.
