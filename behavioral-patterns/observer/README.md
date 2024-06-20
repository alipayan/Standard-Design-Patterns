# Observer Pattern

The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. This pattern is often used to implement distributed event-handling systems.

## Intent

The intent of the Observer Pattern is to:

- Define a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.
- Promote loose coupling between the subject (the object being observed) and the observers.

## Structure

The key components of the Observer Pattern are:

- **Subject**: The object being observed.
- **Observer**: The objects that observe the subject.
- **ConcreteSubject**: A concrete implementation of the subject.
- **ConcreteObserver**: A concrete implementation of the observer.

## UML Diagram

![Observer Pattern UML Diagram](uml-diagram.png)

## Example

You can checkout the examples in the repo.

## Benefits

- Promotes loose coupling between the subject and observers.
- Supports broadcast communication.

## Drawbacks

- Observers are notified in a random order, which may lead to inconsistency.
- Can lead to memory leaks if observers are not correctly removed.

## Related Patterns

- The Publish-Subscribe pattern is a more complex variant of the Observer pattern.
- The Mediator pattern can be used to avoid direct dependencies between observers and subjects.

## References

- Design Patterns: Elements of Reusable Object-Oriented Software by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides

## Contributing

We welcome contributions! If you have examples in c# programming language or improvements to existing ones, please fork the repository and create a pull request. Ensure to follow the contribution guidelines and maintain the folder structure.

## License

This project is licensed under the MIT License - see the [LICENSE](../../LICENSE) file for details.
