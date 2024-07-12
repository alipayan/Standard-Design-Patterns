# State Pattern

The State Pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

## Intent

The intent of the State Pattern is to:

- Allow an object to alter its behavior when its internal state changes.
- Encapsulate state-specific behavior and delegate behavior to the current state.

## Structure

The key components of the State Pattern are:

- **Context**: Maintains an instance of a ConcreteState subclass that defines the current state.
- **State**: Defines an interface for encapsulating the behavior associated with a particular state of the Context.
- **ConcreteState**: Each subclass implements a behavior associated with a state of the Context.

## UML Diagram

![State Pattern UML Diagram](uml-diagram.png)

## Example

Here is an example of the State Pattern implemented in c# language which you can find out in this repository.

## Benefits

- Localizes state-specific behavior and partitions behavior for different states.
- Makes state transitions explicit.
- State objects can be shared if they have no instance variables.

## Drawbacks

- Can result in a large number of subclasses that are difficult to manage.
- Context object can become complex by storing a reference to the current state and delegating behavior to state objects.

## Related Patterns

- The Strategy pattern is similar in structure but is used to define a family of algorithms.
- The Flyweight pattern can be combined with the State pattern to share state objects.

## References

- Design Patterns: Elements of Reusable Object-Oriented Software by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides
- [State blog in refoctoring.guru](https://refactoring.guru/design-patterns/state)

## Contributing

We welcome contributions! If you have examples in c# programming language or improvements to existing ones, please fork the repository and create a pull request. Ensure to follow the contribution guidelines and maintain the folder structure.

## License

This project is licensed under the MIT License - see the [LICENSE](../../LICENSE) file for details.
