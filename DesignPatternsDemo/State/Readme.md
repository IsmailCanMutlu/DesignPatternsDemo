# State Pattern

## Overview
The State pattern allows an object to alter its behavior when its internal state changes. This pattern is used when an object's behavior depends on its state, and it must change its behavior at runtime depending on that state.

## Structure
- **Context (Context):** Maintains an instance of a ConcreteState subclass that defines the current state.
- **State (IState):** Defines an interface for encapsulating the behavior associated with a particular state of the Context.
- **Concrete State (ConcreteStateA, ConcreteStateB):** Each subclass implements a behavior associated with a state of the Context.

## Example
This example demonstrates changing the behavior of an object based on its state using the State pattern.

## Code Explanation
- The `Context` class maintains an instance of a state.
- The `IState` interface defines the state-specific behavior.
- The `ConcreteStateA` and `ConcreteStateB` classes implement the `IState` interface.
- The `Program` class demonstrates the use of the state pattern to change behavior based on state.

## Usage
```bash
dotnet run --project DesignPatternsDemo/State
