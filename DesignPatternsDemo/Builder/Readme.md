
# Builder Pattern

## Overview
The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations. This pattern is used when the construction process of an object is complex and should be independent of the parts that make up the object.

## Structure
- **Product (House):** Represents the complex object to be built.
- **Builder (IHouseBuilder):** Specifies an abstract interface for creating parts of a Product object.
- **Concrete Builder (ConcreteHouseBuilder):** Constructs and assembles parts of the product by implementing the Builder interface.
- **Director (HouseDirector):** Constructs an object using the Builder interface.

## Example
This example demonstrates building a house with different parts (walls, roof, windows) using the Builder pattern.

## Code Explanation
- The `House` class represents the product being built.
- The `IHouseBuilder` interface defines the building steps.
- The `ConcreteHouseBuilder` class implements these steps to construct the house.
- The `HouseDirector` class directs the construction process.
- The `Program` class demonstrates the use of the builder to create a house.

## Usage
```bash
dotnet run --project DesignPatternsDemo/Builder
