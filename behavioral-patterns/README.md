# Behavioral Patterns

Behavioral design patterns are concerned with algorithms and the assignment of responsibilities between objects. They help define how objects interact and communicate with each other. These patterns not only describe the patterns of objects or classes but also the pattern of communication between them.

## List of Behavioral Patterns

This folder contains examples and explanations of the following behavioral design patterns:

1. [Chain of Responsibility](chain-of-responsibility/README.md)
2. [Command](command/README.md)
3. [Interpreter](interpreter/README.md)
4. [Iterator](iterator/README.md)
5. [Mediator](mediator/README.md)
6. [Memento](memento/README.md)
7. [Observer](observer)
8. [State](state/README.md)
9. [Strategy](strategy/README.md)
10. [Template Method](template-method/README.md)
11. [Visitor](visitor/README.md)

## Pattern Descriptions

### Chain of Responsibility

The Chain of Responsibility pattern allows an object to pass a request along a chain of potential handlers until an object handles the request. This pattern decouples the sender and receiver of a request.

### Command

The Command pattern turns a request into a stand-alone object that contains all information about the request. This transformation allows for parameterizing methods with different requests, queuing or logging requests, and supporting undoable operations.

### Interpreter

The Interpreter pattern is used to define a grammatical representation for a language and an interpreter to interpret the grammar. It is commonly used in SQL parsing, symbol processing engine, and more.

### Iterator

The Iterator pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

### Mediator

The Mediator pattern defines an object that encapsulates how a set of objects interact. This pattern promotes loose coupling by preventing objects from referring to each other explicitly, and it lets you vary their interaction independently.

### Memento

The Memento pattern provides the ability to restore an object to its previous state. It is useful in implementing undo mechanisms.

### Observer

The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

### State

The State pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

### Strategy

The Strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. This pattern lets the algorithm vary independently from the clients that use it.

### Template Method

The Template Method pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. It allows subclasses to redefine certain steps of an algorithm without changing the algorithm's structure.

### Visitor

The Visitor pattern allows you to add further operations to objects without having to modify them. This pattern uses a visitor class that changes the executing algorithm of an element class.

## Contributing

We welcome contributions! If you have examples in different programming languages or improvements to existing ones, please fork the repository and create a pull request. Ensure to follow the contribution guidelines and maintain the folder structure.

## License

This project is licensed under the MIT License - see the [LICENSE](../LICENSE) file for details.

