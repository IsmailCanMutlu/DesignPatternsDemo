# Decorator Pattern

## Overview
The Decorator pattern allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class. This pattern is used to extend the functionalities of objects in a flexible and reusable way.

## Structure
- **Component (ICar):** Defines the interface for objects that can have responsibilities added to them.
- **Concrete Component (Car):** Defines an object to which additional responsibilities can be added.
- **Decorator (CarDecorator):** Maintains a reference to a Component object and defines an interface that conforms to Component's interface.
- **Concrete Decorator (LuxuryCar, SportsCar):** Adds responsibilities to the component.

## Example
This example demonstrates extending the functionality of cars with different features using the Decorator pattern.

## Code Explanation
- The `ICar` interface defines the component.
- The `Car` class is the concrete component.
- The `CarDecorator` class maintains a reference to a component.
- The `LuxuryCar` and `SportsCar` classes extend `CarDecorator` to add additional features.
- The `Program` class demonstrates the use of decorators to add features to cars.

## Usage
```bash
dotnet run --project DesignPatternsDemo/Decorator
