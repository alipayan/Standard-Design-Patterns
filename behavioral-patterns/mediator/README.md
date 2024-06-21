# Mediator Pattern

The Mediator Pattern defines an object that encapsulates how a set of objects interact. This pattern promotes loose coupling by preventing objects from referring to each other explicitly, and it lets you vary their interaction independently.

## Intent

The intent of the Mediator Pattern is to:

- Centralize complex communications and control between related objects.
- Promote loose coupling by keeping objects from referring to each other explicitly.

## Structure

The key components of the Mediator Pattern are:

- **Mediator**: The interface for communicating with Colleague objects.
- **ConcreteMediator**: Implements cooperative behavior by coordinating Colleague objects and knows and maintains its colleagues.
- **Colleague**: Each Colleague communicates with its Mediator whenever it would have otherwise communicated with another Colleague.

## UML Diagram

![Mediator Pattern UML Diagram](uml-diagram.png)

## Example

Here is an example of the Mediator Pattern implemented this direcotry.

## Benefits

- Decouples the communication between colleague objects.
- Centralizes control logic to simplify maintenance and extension.

## Drawbacks

- Can create a single point of failure, as the Mediator's complexity increases.
- Mediator can become overly complex as more Colleague objects are added.

## Related Patterns

- The Observer pattern can be used for communication between objects when there is no need for a central point of control.
- The Facade pattern provides a simplified interface to a larger body of code but doesn't centralize the communication like the Mediator.

## References

- Design Patterns: Elements of Reusable Object-Oriented Software by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides

## Contributing

We welcome contributions! If you have examples in c# programming language or improvements to existing ones, please fork the repository and create a pull request. Ensure to follow the contribution guidelines and maintain the folder structure.

## License

This project is licensed under the MIT License - see the [LICENSE](../../LICENSE) file for details.
